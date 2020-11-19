using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using static PointOfSalesV2.Common.Enums;
using PointOfSalesV2.Common;

namespace PointOfSalesV2.Repository
{
    public class CustomerReturnRepository : Repository<CustomerReturn>, ICustomerReturnRepository
    {
        IDataRepositoryFactory repositoryFactory;
        public CustomerReturnRepository(MainDataContext context, IDataRepositoryFactory newFactory) : base(context)
        {
            this.repositoryFactory = newFactory;
        }

        public override Result<CustomerReturn> Get(long id)
        {
           var result = this.Get(x => x.AsNoTracking().Include(x=>x.ReturnDetails).Include(x=>x.CreditNote)
           .Include(x=>x.Currency).Include(x=>x.Customer).Include(x=>x.BranchOfficeId), y => y.Active == true && y.Id == id);
            result.ReturnDetails = result.ReturnDetails.Where(x => x.Active == true).ToList();
            return new Result<CustomerReturn>(id, 0, "ok_msg", new List<CustomerReturn>() { result });
        }
        public override Result<CustomerReturn> Add(CustomerReturn entity)
        {
            var result = new Result<CustomerReturn>(-1, -1, "error_msg");
            var warehouses = _Context.Warehouses.AsNoTracking().Where(x => x.Active == true).ToList();
            using (var transaction = _Context.Database.BeginTransaction()) 
            {
               
                try
                {
                    var invoice = repositoryFactory.GetCustomDataRepositories<IInvoiceRepository>().GetByInvoiceNumber(entity.InvoiceNumber);
                    if (string.IsNullOrEmpty(entity.InvoiceNumber))
                    {
                        transaction.Rollback();
                        return new Result<CustomerReturn>(-1, -1, "invoiceNumberRequired_error");
                    }
                    if (repositoryFactory.GetDataRepositories<CustomerReturn>().Get(x => x, y => y.Active == true && y.InvoiceNumber.ToUpper() == entity.InvoiceNumber.ToUpper()) != null) 
                    {
                        transaction.Rollback();
                        return new Result<CustomerReturn>(-1, -1, "returnAlreadyApplied_error");
                    }
                    if (entity.ReturnDetails == null || entity.ReturnDetails.Count == 0 || !entity.ReturnDetails.Any(x => x.Quantity > 0))
                    {
                        transaction.Rollback();
                        return new Result<CustomerReturn>(-1, -1, "detailsRequired_error");
                    }
                    if (invoice == null)
                    {
                        transaction.Rollback();
                        return new Result<CustomerReturn>(-1, -1, "invoiceDoesNotExist_error");
                    }
                    var validStates = new char[] { (char)Enums.BillingStates.Paid, (char)Enums.BillingStates.FullPaid };
                    if (!validStates.Contains(invoice.State))
                    {
                        transaction.Rollback();
                        return new Result<CustomerReturn>(-1, -1, "invalidInvoiceStateReturn_error");
                    }
                    entity.CurrencyId = invoice.CurrencyId;
                    entity.CustomerId = invoice.CustomerId;
                    entity.InvoiceId = invoice.Id;
                    entity.BranchOfficeId = invoice.BranchOfficeId;
                    entity.Date = DateTime.Now;
                    entity.Active = true;
                    entity.BranchOffice = null;
                    entity.Currency = null;
                    entity.Customer = null;
                    entity.Invoice = null;
                    entity.BeforeTaxesAmount = entity.ReturnDetails.Sum(x => x.BeforeTaxesAmount);
                    entity.TaxesAmount = entity.ReturnDetails.Sum(x => x.TaxesAmount);
                    entity.TotalAmount = entity.BeforeTaxesAmount + entity.TaxesAmount;
                    entity.InvoiceNumber = invoice.InvoiceNumber;
                    CreditNote creditNote = new CreditNote() 
                    {
                    Active=true,
                    Amount=entity.ReturnDetails.Sum(x=>x.TotalAmount),
                    Applied=false,
                    OriginInvoiceNumber=entity.InvoiceNumber,
                    AppliedInvoiceNumber="",
                    CurrencyId=invoice.CurrencyId,
                    CustomerId=invoice.CustomerId,
                    Date=DateTime.Now,
                    Sequence= Helpers.SequencesHelper.CreateCustomersReturnsControl(repositoryFactory)
                    };
                    var creditNoteResult = repositoryFactory.GetCustomDataRepositories<ICreditNoteRepository>().Add(creditNote);
                    if (creditNoteResult.Status < 0) 
                    {
                        transaction.Rollback();
                        return new Result<CustomerReturn>(-1, -1, "error_msg");
                    }
                    entity.CreditNoteId = creditNoteResult.Data.FirstOrDefault().Id;
                    entity.CreditNoteNumber = creditNote.Sequence;
                    foreach (var d in entity.ReturnDetails) 
                    {
                        d.Active = true;
                        d.CustomerId = entity.CustomerId;
                        d.Date = DateTime.Now;
                        d.InvoiceNumber = entity.InvoiceNumber;
                        d.Reference = creditNote.Sequence;
                        d.WarehouseId = d.Defective ? warehouses.FirstOrDefault(x => x.Code.ToLower() == "def")?.Id : d.WarehouseId;
                        if (d.WarehouseId.HasValue && d.WarehouseId > 0)
                        {
                            var inventoryResult = Helpers.InventoryHelper.ReInsertInventoryToWarehouse(new InvoiceDetail() 
                            {
                            Active=true,
                            BeforeTaxesAmount=d.BeforeTaxesAmount,
                            Amount=0,
                            CreditNoteAmount=d.TotalAmount,
                            TaxesAmount=d.TaxesAmount,
                            TotalAmount=d.TotalAmount,
                            BranchOfficeId=invoice.BranchOfficeId,
                            Date=d.Date,
                            Defective=d.Defective,
                            InvoiceId=entity.InvoiceId,
                            ProductId=d.ProductId,
                            UnitId=d.UnitId,
                            WarehouseId=d.WarehouseId,
                            Quantity=d.Quantity
                            }, repositoryFactory, warehouses.FirstOrDefault(x => x.Id == d.WarehouseId.Value), d.Reference);
                            if (inventoryResult.Status < 0)
                            {
                                transaction.Rollback();
                               return new Result<CustomerReturn>(inventoryResult.Id, inventoryResult.Status, inventoryResult.Message);
                               
                            }
                        }
                    }

                    entity.ReturnDetails.ForEach(d => {
                        d.Product = null;
                        d.Customer = null;
                        d.Warehouse = null;
                    });

                    result = base.Add(entity);
                    transaction.Commit();
                }
                catch (Exception ex) 
                {
                    transaction.Rollback();
                    result = new Result<CustomerReturn>(-1, -1, "error_msg", null, ex);
                }
            }
            return result;
        }

        public override Result<CustomerReturn> Update(CustomerReturn entity, bool getFromDb = true)
        {
            return new Result<CustomerReturn>(-1, -1, "cannotUpdateCustomerReturn_msg");
        }

        public override Result<CustomerReturn> Remove(long id)
        {
            var result = new Result<CustomerReturn>(-1, -1, "cannotRemoveReturn_error");
            return result;
        }
    }
}

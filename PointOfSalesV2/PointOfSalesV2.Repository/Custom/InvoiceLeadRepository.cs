using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class InvoiceLeadRepository : Repository<InvoiceLead>, IInvoiceLeadRepository
    {
        readonly ISequenceManagerRepository sequenceManagerRepository;
        readonly IDataRepositoryFactory _repoFactory;
        public InvoiceLeadRepository(MainDataContext context, IDataRepositoryFactory dataRepositoryFactory) : base(context)
        {
            this.sequenceManagerRepository = dataRepositoryFactory.GetCustomDataRepositories<ISequenceManagerRepository>();
            this._repoFactory = dataRepositoryFactory;
        }

        public override Result<InvoiceLead> Get(long id)
        {
            var entity = _Context.InvoicesLeads.Find(id);
            _Context.Entry<InvoiceLead>(entity).State = EntityState.Detached;
            entity.LeadDetails = _Context.LeadsDetails
                .Include(x => x.Product)
                .ThenInclude(x=>x.ProductUnits).ThenInclude(x=>x.Unit)
                .Include(x=>x.Product).ThenInclude(x=>x.Taxes).ThenInclude(x=>x.Tax)
                .Include(x => x.Unit).AsNoTracking().Where(x => x.Active == true && x.InvoiceLeadId == id).ToList();
            return new Result<InvoiceLead>(entity.Id, 0, "ok_msg", new List<InvoiceLead>() { entity });
        }

        public override Result<InvoiceLead> Add(InvoiceLead entity)
        {
            Result<InvoiceLead> result = new Result<InvoiceLead>(-1, -1, "error_msg");
            using (var trans = _Context.Database.BeginTransaction())
            {
                try
                {
                    var leadDetails = entity.LeadDetails;
                    leadDetails.ForEach(d => {
                        d.Product = d.Product == null ? _Context.Products.AsNoTracking().Include(x=>x.ProductUnits).ThenInclude(x=>x.Unit).Include(x => x.Taxes).ThenInclude(x => x.Tax).FirstOrDefault(x => x.Active == true && x.Id == d.ProductId) : d.Product;
                        d.Product.Taxes= d.Product.Taxes==null? _Context.ProductTaxes.AsNoTracking().Include(x => x.Tax).Where(x => x.Active == true && x.ProductId == d.ProductId): d.Product.Taxes;
                        d.Amount = d.UnitId.HasValue ?Convert.ToDecimal( d.Product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId.Value)?.SellingPrice ): d.Product.Price;

                        d.BeforeTaxesAmount = (d.Amount * d.Quantity);
                        d.DiscountAmount = d.BeforeTaxesAmount * d.DiscountRate;
                        d.TaxesAmount = (d.BeforeTaxesAmount-d.DiscountAmount) * d.Product.Taxes.Sum(t => t.Tax.Rate);
                        d.TotalAmount = d.BeforeTaxesAmount + d.TaxesAmount - d.DiscountAmount - d.CreditNoteAmount;
                    });
                    entity.LeadDetails = null;
                    entity.SellerId = entity.SellerId.HasValue && entity.SellerId <= 0 ? null : entity.SellerId;
                    entity.InvoiceId = entity.InvoiceId.HasValue && entity.InvoiceId <= 0 ? null : entity.InvoiceId;
                    entity.CashRegisterId = entity.CashRegisterId.HasValue && entity.CashRegisterId <= 0 ? null : entity.CashRegisterId;
                    entity.MenuId = entity.MenuId.HasValue && entity.MenuId <= 0 ? null : entity.MenuId;
                    entity.WarehouseId = entity.WarehouseId.HasValue && entity.WarehouseId == 0 ? null : entity.WarehouseId;
                    entity.BranchOffice = null;
                    entity.Invoice = null;
                    entity.Customer = null;
                    entity.Menu = null;
                    entity.School = null;
                    entity.Seller = null;
                    entity.Id = 0;
                    entity.Zone = null;
                    entity.State = entity.InventoryModified ? (char)Enums.BillingStates.Generated : (char)Enums.BillingStates.GeneratedWithoutInventory;
                    entity.BeforeTaxesAmount = leadDetails.Sum(x => x.BeforeTaxesAmount);
                    entity.Cost = leadDetails.Sum(x => x.Cost);
                    entity.DiscountAmount = leadDetails.Sum(x => x.DiscountAmount);
                    entity.DiscountRate = leadDetails.Average(x => x.DiscountRate);
                    entity.TaxesAmount = leadDetails.Sum(x => x.TaxesAmount);
                    entity.TotalAmount = leadDetails.Sum(x => x.TotalAmount);
                    entity.OwedAmount = entity.TotalAmount - entity.PaidAmount;
                    entity.ReturnedAmount = entity.ReceivedAmount - entity.TotalAmount;
                    entity.DocumentNumber = this.sequenceManagerRepository.CreateSequence(Enums.SequenceTypes.Leads);

                    _Context.InvoicesLeads.Add(entity);
                    _Context.SaveChanges();
                    if (!entity.InventoryModified)
                    {
                        leadDetails.ForEach(d =>
                        {
                            var product = _Context.Products.Include(x => x.ProductUnits).ThenInclude(x=>x.Unit).Include(x => x.Taxes).ThenInclude(y => y.Tax).AsNoTracking().FirstOrDefault(x => x.Id == d.ProductId && x.Active == true);
                            d.Product = null;
                            d.Unit = null;
                            d.Id = 0;
                            d.BranchOfficeId = entity.BranchOfficeId;
                            d.WarehouseId = entity.WarehouseId;
                            d.InvoiceLeadId = entity.Id;
                            d.WarehouseId = entity.WarehouseId;
                            d.Active = true;
                            d.Date = entity.Date;
                            d.UnitId = d.UnitId.HasValue && d.UnitId <= 0 ? null : d.UnitId;
                            d.ParentId = d.ParentId.HasValue && d.ParentId <= 0 ? null : d.ParentId;
                            d.Cost = d.UnitId.HasValue ? Convert.ToDecimal(product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId && d.Active == true)?.CostPrice) : product.Cost;
                            d.Amount = d.UnitId.HasValue ? Convert.ToDecimal(product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId && d.Active == true)?.SellingPrice) : product.Price;
                            d.BeforeTaxesAmount = d.Amount * d.Quantity;
                            d.TaxesAmount = d.TaxesAmount == 0 ? product.Taxes != null ? Convert.ToDecimal(product.Taxes.Where(t => t.Active == true).Sum(x => x.Tax?.Rate) * d.Quantity) : 0 : d.TaxesAmount;
                            d.TotalAmount = d.TaxesAmount + d.BeforeTaxesAmount;

                        });
                        _Context.LeadsDetails.AddRange(leadDetails);
                        _Context.SaveChanges();
                    }
                    else
                    {
                        _Context.Entry<InvoiceLead>(entity).State = EntityState.Detached;
                        entity.LeadDetails = leadDetails;
                        var branchOffice = _Context.BranchOffices.AsNoTracking().FirstOrDefault(x => x.Id == entity.BranchOfficeId && x.Active == true);
                        Helpers.InvoiceDetailsHelper.AddDetails(entity, branchOffice, _repoFactory,false);
                    }

                    trans.Commit();
                    result = new Result<InvoiceLead>(entity.Id, 0, "ok_msg");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = new Result<InvoiceLead>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public override Result<InvoiceLead> Update(InvoiceLead entity, bool fromDb = true)
        {
            Result<InvoiceLead> result = new Result<InvoiceLead>(-1, -1, "error_msg");
            using (var trans = _Context.Database.BeginTransaction())
            {
                try
                {
                    entity.LeadDetails.ForEach(d => {
                        d.Product = d.Product == null ? _Context.Products.AsNoTracking().Include(x => x.ProductUnits).Include(x => x.Taxes).ThenInclude(x => x.Tax).FirstOrDefault(x => x.Active == true && x.Id == d.ProductId) : d.Product;
                        d.Product.ProductUnits = d.Product.ProductUnits == null ? _Context.UnitProductsEquivalences.AsNoTracking().Include(x=>x.Unit).Where(x => x.ProductId == d.ProductId && x.Active == true) : d.Product.ProductUnits;
                        d.Product.Taxes = d.Product.Taxes == null ? _Context.ProductTaxes.AsNoTracking().Include(x => x.Tax).Where(x => x.Active == true && x.ProductId == d.ProductId) : d.Product.Taxes;
                        d.Amount = d.UnitId.HasValue ? Convert.ToDecimal(d.Product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId.Value)?.SellingPrice) : d.Product.Price;

                        d.BeforeTaxesAmount = (d.Amount * d.Quantity);
                        d.DiscountAmount = d.BeforeTaxesAmount * d.DiscountRate;
                        d.TaxesAmount = (d.BeforeTaxesAmount - d.DiscountAmount) * d.Product.Taxes.Sum(t => t.Tax.Rate);
                        d.TotalAmount = d.BeforeTaxesAmount + d.TaxesAmount - d.DiscountAmount - d.CreditNoteAmount;
                    });
                    var dbEntity = _Context.InvoicesLeads.Find(entity.Id);
                    _Context.Entry<InvoiceLead>(dbEntity).State = EntityState.Detached;
                    var oldDetails = _Context.LeadsDetails.AsNoTracking()
                        .Include(x=>x.Product).ThenInclude(x=>x.Taxes).ThenInclude(x=>x.Tax)
                        .Include(x=>x.Product).ThenInclude(x=>x.ProductUnits)
                        .Where(x => x.Active == true && x.InvoiceLeadId == entity.Id).ToList();
                    dbEntity.WarehouseId = entity.WarehouseId.HasValue && entity.WarehouseId == 0 ? null : entity.WarehouseId;
                    dbEntity.BranchOffice = null;
                    dbEntity.Invoice = null;
                    dbEntity.Customer = null;
                    dbEntity.Menu = null;
                    dbEntity.School = null;
                    dbEntity.Seller = null;
                    dbEntity.Zone = null;
                    dbEntity.State = entity.InventoryModified ? (char)Enums.BillingStates.Generated : (char)Enums.BillingStates.GeneratedWithoutInventory;
                    oldDetails.AddRange(entity.LeadDetails.Where(x => x.Id == 0));
                    if (!dbEntity.InventoryModified && !entity.InventoryModified)
                        oldDetails.ForEach(d =>
                        {
                            if (d.Id > 0)
                            {
                                var newDetail = entity.LeadDetails.FirstOrDefault(x => x.Id == d.Id);
                                if (newDetail != null)
                                {
                                    var product = _Context.Products.Include(x => x.ProductUnits).ThenInclude(x=>x.Unit).Include(x => x.Taxes).ThenInclude(y => y.Tax).AsNoTracking().FirstOrDefault(x => x.Id == newDetail.ProductId && x.Active == true);
                                    d.Product = null;
                                    d.Unit = null;
                                    d.InvoiceLeadId = entity.Id;
                                    d.WarehouseId = entity.WarehouseId;
                                    d.ProductId = newDetail.ProductId;
                                    d.Quantity = newDetail.Quantity;
                                    d.UnitId = newDetail.UnitId;
                                    d.Active = true;
                                    d.Date = entity.Date;
                                    d.Cost = d.UnitId.HasValue ? Convert.ToDecimal(product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId && d.Active == true)?.CostPrice) : product.Cost;

                                    d.Amount = d.UnitId.HasValue ? Convert.ToDecimal(product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId.Value)?.SellingPrice) : product.Price;
                                    d.BeforeTaxesAmount = (d.Amount * d.Quantity);
                                    d.DiscountAmount = d.BeforeTaxesAmount * d.DiscountRate;
                                    d.TaxesAmount = (d.BeforeTaxesAmount - d.DiscountAmount) * product.Taxes.Sum(t => t.Tax.Rate);
                                    d.TotalAmount = d.BeforeTaxesAmount + d.TaxesAmount - d.DiscountAmount - d.CreditNoteAmount;
                                    _Context.LeadsDetails.Update(d);

                                }
                                else
                                {
                                    _Context.LeadsDetails.Remove(d);
                                }
                            }
                            else
                            {
                                var product = _Context.Products.Include(x => x.ProductUnits).ThenInclude(x=>x.Unit).Include(x => x.Taxes).ThenInclude(y => y.Tax).AsNoTracking().FirstOrDefault(x => x.Id == d.ProductId && x.Active == true);
                                d.Product = null;
                                d.Unit = null;
                                d.InvoiceLeadId = entity.Id;
                                d.WarehouseId = entity.WarehouseId;
                                d.Active = true;
                                d.Date = entity.Date;
                                d.Cost = d.UnitId.HasValue ? Convert.ToDecimal(product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId && d.Active == true)?.CostPrice) : product.Cost;
                                d.Amount = d.UnitId.HasValue ? Convert.ToDecimal(product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId.Value)?.SellingPrice) : product.Price;
                                d.BeforeTaxesAmount = (d.Amount * d.Quantity);
                                d.DiscountAmount = d.BeforeTaxesAmount * d.DiscountRate;
                                d.TaxesAmount = (d.BeforeTaxesAmount - d.DiscountAmount) * product.Taxes.Sum(t => t.Tax.Rate);
                                d.TotalAmount = d.BeforeTaxesAmount + d.TaxesAmount - d.DiscountAmount - d.CreditNoteAmount;
                                _Context.LeadsDetails.Add(d);
                            }



                            _Context.SaveChanges();

                        });
                    else if (!dbEntity.InventoryModified && entity.InventoryModified)
                    {
                        _Context.LeadsDetails.RemoveRange(oldDetails.Where(x => x.Id > 0).Select(x => new LeadDetail()
                        {
                            Id = x.Id,
                            ProductId = x.ProductId,
                            UnitId = x.UnitId,
                            BranchOfficeId = x.BranchOfficeId,
                            InvoiceLeadId = x.InvoiceLeadId,
                            ParentId = x.ParentId,
                            WarehouseId = x.WarehouseId
                        }));
                        _Context.SaveChanges();
                        oldDetails.ForEach(d => {
                            d.Id = 0;
                            d.Amount = d.UnitId.HasValue ? Convert.ToDecimal(d.Product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId.Value)?.SellingPrice) : d.Product.Price;
                            d.BeforeTaxesAmount = (d.Amount * d.Quantity);
                            d.DiscountAmount = d.BeforeTaxesAmount * d.DiscountRate;
                            d.TaxesAmount = (d.BeforeTaxesAmount - d.DiscountAmount) * d.Product.Taxes.Sum(t => t.Tax.Rate);
                            d.TotalAmount = d.BeforeTaxesAmount + d.TaxesAmount - d.DiscountAmount - d.CreditNoteAmount;
                        });
                        entity.LeadDetails = oldDetails;
                        var branchOffice = _Context.BranchOffices.Find(entity.BranchOfficeId);
                        _Context.Entry<BranchOffice>(branchOffice).State = EntityState.Detached;
                        Helpers.InvoiceDetailsHelper.AddDetails(entity, branchOffice, _repoFactory,false);
                    }
                    else
                    {

                        var branchOffice = _Context.BranchOffices.Find(entity.BranchOfficeId);
                        _Context.Entry<BranchOffice>(branchOffice).State = EntityState.Detached;
                        Helpers.InvoiceDetailsHelper.UpdateDetails(entity, branchOffice, _repoFactory);
                    }

                    dbEntity.BeforeTaxesAmount = oldDetails.Sum(x => x.BeforeTaxesAmount);
                    dbEntity.Cost = oldDetails.Sum(x => x.Cost);
                    dbEntity.DiscountAmount = oldDetails.Sum(x => x.DiscountAmount);
                    dbEntity.DiscountRate = oldDetails.Average(x => x.DiscountRate);
                    dbEntity.TaxesAmount = oldDetails.Sum(x => x.TaxesAmount);
                    dbEntity.TotalAmount = oldDetails.Sum(x => x.TotalAmount);
                    dbEntity.OwedAmount = dbEntity.TotalAmount - entity.PaidAmount;
                    dbEntity.InventoryModified = entity.InventoryModified;
                    dbEntity.ReturnedAmount = dbEntity.ReceivedAmount - entity.TotalAmount;
                    dbEntity.DocumentNumber = string.IsNullOrEmpty(dbEntity.DocumentNumber) ? this.sequenceManagerRepository.CreateSequence(Enums.SequenceTypes.Leads) : dbEntity.DocumentNumber;
                    dbEntity.LeadDetails = null;
                    _Context.InvoicesLeads.Update(dbEntity);
                    _Context.SaveChanges();
                    trans.Commit();
                    result = new Result<InvoiceLead>(entity.Id, 0, "ok_msg");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = new Result<InvoiceLead>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public override Result<InvoiceLead> Remove(long id)
        {
            var result = new Result<InvoiceLead>(-1, -1, "error_msg");

            using (var trans = _Context.Database.BeginTransaction())
            {
                try
                {
                    var invoiceLead = _Context.InvoicesLeads.Find(id);
                    _Context.Entry<InvoiceLead>(invoiceLead).State = EntityState.Detached;
                    if (!invoiceLead.InvoiceId.HasValue)
                    {
                        CancelLead(invoiceLead);
                    }
                    else
                    {
                        var invoice = _Context.Invoices.Find(invoiceLead.InvoiceId.Value);
                        _Context.Entry<Invoice>(invoice).State = EntityState.Detached;
                        if (invoice.BillingState != Enums.BillingStates.Nulled)
                        {
                            trans.Rollback();
                            return new Result<InvoiceLead>(-1, -1, "leadIsBilled_msg");
                        }
                        else
                            CancelLead(invoiceLead);
                    }
                    trans.Commit();
                    result = new Result<InvoiceLead>(id, 0, "ok_msg");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = new Result<InvoiceLead>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public Result<InvoiceLead> DeliverLead(long id)
        {
            var result = new Result<InvoiceLead>(-1, -1, "error_msg");
            var invoiceLead = _Context.InvoicesLeads.Find(id);
            _Context.Entry<InvoiceLead>(invoiceLead).State = EntityState.Detached;
            if (!invoiceLead.InvoiceId.HasValue)
            {
                if (invoiceLead.BillingState == Enums.BillingStates.Generated)
                {
                    invoiceLead.State = (char)Enums.BillingStates.Delivered;
                    _Context.InvoicesLeads.Update(invoiceLead);
                    _Context.SaveChanges();
                    result = new Result<InvoiceLead>(id, 0, "ok_msg");
                }
            }
            else
            {
                return new Result<InvoiceLead>(-1, -1, "leadHasInvoice_lbl");
            }

            return result;
        }
        private void CancelLead(InvoiceLead invoiceLead)
        {
            var details = _Context.LeadsDetails.AsNoTracking().Include(x => x.Product).Include(x => x.Unit).Where(x => x.Active == true && x.InvoiceLeadId == invoiceLead.Id).ToList();
            if (invoiceLead.BillingState != Enums.BillingStates.GeneratedWithoutInventory && invoiceLead.BillingState != Enums.BillingStates.NulledLead && invoiceLead.InventoryModified)
            {

                details.ForEach(d =>
                {
                    InventoryHelper.AddInventory(d, invoiceLead, _repoFactory);
                });

            }
            details.ForEach(d =>
            {
                d.Product = null;
                d.Unit = null;
            });
            invoiceLead.State = (char)Enums.BillingStates.NulledLead;
            invoiceLead.InventoryModified = false;
            _Context.InvoicesLeads.Update(invoiceLead);
            _Context.SaveChanges();
        }

        public Result<InvoiceLead> GetLeadsForBilling(long branchOfficeId=0, long customerId=0,long currencyId=0,int month=0)
        {
            var result = new Result<InvoiceLead>(-1, -1, "error_msg");
            var leads = this.GetAll<InvoiceLead>(x => x, y => y.Active == true && y.State ==(char)Enums.BillingStates.Delivered &&
            (branchOfficeId>0?y.BranchOfficeId==branchOfficeId:y.BranchOfficeId>0) &&
            (customerId > 0 ? y.CustomerId == customerId : y.CustomerId > 0) &&
            (currencyId > 0 ? y.CurrencyId == currencyId : y.CurrencyId > 0) &&
            (month>0?y.Date.Month==month:y.Id>0)
            ).ToList();
            result = new Result<InvoiceLead>(0, 0, "ok_msg", leads);
            return result;
        }

        public Result<InvoiceLead> GetLeadOrMenuInfo(long leadId, long menuId, long schoolId, string documentNumber="")
        {
            InvoiceLead invoiceLead = null;
            if (leadId > 0) 
            {
                invoiceLead = _Context.InvoicesLeads.AsNoTracking().Include(x => x.BranchOffice).Include(x => x.School).Include(x => x.Customer).Include(x => x.Zone).Include(x => x.Currency)
                    .FirstOrDefault(x => x.Id == leadId && x.Active == true);
                invoiceLead.LeadDetails = _Context.LeadsDetails.AsNoTracking().Include(x => x.Product).Include(x => x.Unit).Where(x => x.Active == true && x.InvoiceLeadId == leadId).ToList();
            }
            else 
            {
                var menu = _Context.Menus.Find(menuId);
                _Context.Entry<Menu>(menu).State = EntityState.Detached;
                var school = _Context.Schools.Include(x=>x.Currency).Include(x=>x.Customer).FirstOrDefault(x=>x.Id==schoolId);
                var details = _Context.MenuDetails.AsNoTracking().Include(x => x.Product).Include(x => x.Unit).Where(x => x.Active == true && x.MenuId == menuId).Select(x=>new LeadDetail() 
                {
                Amount=x.Amount,
                BeforeTaxesAmount=x.BeforeTaxesAmount,
                PrincipalCurrencyAmount=x.PrincipalCurrencyAmount,
                TaxesAmount=x.TaxesAmount,
                TotalAmount=x.TotalAmount,
                BranchOfficeId=x.BranchOfficeId,
                Cost=x.Cost,
                Product=x.Product,
                Unit=x.Unit,
                WarehouseId=x.WarehouseId,
                Quantity=x.Quantity,
                ParentId=x.ParentId,
                ProductId=x.ProductId,
                UnitId=x.UnitId,
                Comments=x.Comments
                }).ToList();
                invoiceLead = new InvoiceLead() 
                {
                InvoiceNumber=documentNumber,
                LeadDetails=details,
                Currency=school.Currency,
                Customer=school.Customer,
                School=school,
                BeforeTaxesAmount=details.Sum(x=>x.BeforeTaxesAmount),
                TaxesAmount=details.Sum(x=>x.TaxesAmount),
                TotalAmount = details.Sum(x=>x.TotalAmount),
                Cost=details.Sum(x=>x.Cost),
                DiscountAmount=details.Sum(x=>x.DiscountAmount),
                State = (char)Enums.BillingStates.Projected,
                
                };
            }
            return new Result<InvoiceLead>(invoiceLead.Id, 0, "ok_msg", new List<InvoiceLead>() { invoiceLead });
        }

        public override IQueryable<TResult> GetAll<TResult>(Func<IQueryable<InvoiceLead>, IQueryable<TResult>> transform, Expression<Func<InvoiceLead, bool>> filter = null, string sortExpression = null)
        {
            var _DbSet = _Context.Set<InvoiceLead>();
            var initialQuary = _DbSet.AsNoTracking().Include(x => x.Currency).Include(x => x.Customer)
                .Include(x => x.BranchOffice).Include(x => x.Seller).Include(x => x.School).Include(x => x.Zone);
            var query = filter == null ? initialQuary.OrderBy(sortExpression) : initialQuary.Where(filter).OrderBy(sortExpression);

            var notSortedResults = transform(query);

            var sortedResults = sortExpression == null ? notSortedResults : notSortedResults.OrderBy(sortExpression);

            return sortedResults.AsQueryable();
        }
    }
}

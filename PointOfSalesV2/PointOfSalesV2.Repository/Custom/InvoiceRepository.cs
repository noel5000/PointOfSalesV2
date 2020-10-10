using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PointOfSalesV2.Common;
using PointOfSalesV2.Repository.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using static PointOfSalesV2.Common.Enums;
using System.Threading.Tasks;
using NPOI.SS.Formula.Functions;

namespace PointOfSalesV2.Repository
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        private readonly IDataRepositoryFactory dataRepositoryFactory;
        readonly ISequenceManagerRepository sequenceManagerRepository;

        public InvoiceRepository(MainDataContext context, IDataRepositoryFactory newDataRepo) : base(context)
        {
            dataRepositoryFactory = newDataRepo;
            this.sequenceManagerRepository = dataRepositoryFactory.GetCustomDataRepositories<ISequenceManagerRepository>();
        }

        public override IQueryable<TResult> GetAll<TResult>(Func<IQueryable<Invoice>, IQueryable<TResult>> transform, Expression<Func<Invoice, bool>> filter = null, string sortExpression = null)
        {
            var _DbSet = _Context.Set<Invoice>();
            var query = filter == null ? _DbSet.AsNoTracking().Include(x => x.Currency).Include(x => x.Customer)
                .Include(x => x.BranchOffice).Include(x => x.TRNControl).Include(x => x.Seller)
                .OrderBy(sortExpression) : _DbSet.AsNoTracking().Include(x => x.Currency).Include(x => x.Customer)
                .Include(x => x.BranchOffice).Include(x => x.TRNControl).Include(x => x.Seller).Where(filter).OrderBy(sortExpression);

            var notSortedResults = transform(query);

            var sortedResults = sortExpression == null ? notSortedResults : notSortedResults.OrderBy(sortExpression);

            return sortedResults.AsQueryable();
        }
        public IEnumerable<Invoice> GetAccountsReceivable(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId, long? sellerId, long? branchOfficeId)
        {

            return this.GetAll<Invoice>(y => y, x =>
             x.Active == true && (startDate.HasValue ? x.BillingDate >= startDate.Value : x.BillingDate > DateTime.MinValue) &&
            (endDate.HasValue ? x.BillingDate <= endDate.Value : x.BillingDate < DateTime.Now) &&
            (customerId.HasValue && customerId.Value > 0 ? x.CustomerId == customerId.Value : x.CustomerId > 0) &&
            (currencyId.HasValue && currencyId.Value > 0 ? x.CurrencyId == currencyId.Value : x.CurrencyId > 0) &&
            (sellerId.HasValue && sellerId.Value > 0 ? x.SellerId == sellerId.Value : x.SellerId > 0 || x.SellerId == null) &&
            (branchOfficeId.HasValue && branchOfficeId.Value > 0 ? x.BranchOfficeId == branchOfficeId.Value : x.BranchOfficeId > 0) &&
            x.OwedAmount > 0 && ((x.State == (char)Enums.BillingStates.Billed) || (x.State == (char)Enums.BillingStates.Paid))
            );
        }

        public IEnumerable<object> GetAccountStatus(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId)
        {
            throw new NotImplementedException();
        }

        public Invoice GetByInvoiceNumber(string invoiceNumber)
        {
            return _Context.Invoices.AsNoTracking().FirstOrDefault(x => x.Active == true && x.InvoiceNumber.ToLower() == invoiceNumber.ToLower());
        }

        public PagedList<Invoice> GetPagedQuotes(int page, int size)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> GetSales(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId, long? sellerId, long? branchOfficeId)
        {
            Func<Invoice, bool> func = invoice => invoice.Active == true && (startDate.HasValue ? invoice.BillingDate >= startDate.Value : invoice.Id > 0) &&
             (branchOfficeId.HasValue && branchOfficeId.Value > 0 ? invoice.BranchOfficeId == branchOfficeId.Value : invoice.BranchOfficeId > 0) &&
         (endDate.HasValue ? invoice.BillingDate <= endDate.Value : invoice.Id > 0) && (customerId.HasValue && customerId.Value > 0 ? invoice.CustomerId == customerId.Value : invoice.Id > 0) &&
         (currencyId.HasValue && currencyId.Value > 0 ? invoice.CurrencyId == currencyId.Value : invoice.Id > 0) && (sellerId.HasValue && sellerId.Value > 0 ? invoice.SellerId == sellerId.Value : invoice.Id > 0)
         && (invoice.State != (char)Enums.BillingStates.Nulled);
            return _Context.Invoices.AsNoTracking().Include(x => x.Customer).Include(x => x.BranchOffice)
                .Include(x => x.Seller).Include(x => x.Currency).Include(x => x.Currency).Where(func);
        }

        public IEnumerable<Invoice> GetInvoicesToPay(long branchOfficeId = 0, long currencyId = 0, long customerId = 0)
        {
            Func<Invoice, bool> func = invoice => invoice.Active == true &&
          (customerId > 0 ? invoice.CustomerId == customerId : invoice.CustomerId > 0) &&
         (currencyId > 0 ? invoice.CurrencyId == currencyId : invoice.CurrencyId > 0) && (branchOfficeId > 0 ? invoice.BranchOfficeId == branchOfficeId : invoice.BranchOfficeId > 0)
         && (invoice.State != (char)Enums.BillingStates.Nulled) && (invoice.OwedAmount > 0) && (invoice.PaidAmount < invoice.TotalAmount);
            return _Context.Invoices.AsNoTracking().Include(x => x.Customer).Include(x => x.BranchOffice)
                .Include(x => x.Seller).Include(x => x.Currency).Include(x => x.Currency).Where(func);
        }

        public override Result<Invoice> Add(Invoice entity)
        {
            Result<Invoice> result = new Result<Invoice>(-1, -1, "error_msg");
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                    entity.Customer = entity.Customer != null && entity.Customer.Id > 0 ? entity.Customer : _Context.Customers.Find(entity.CustomerId);
                    entity.Currency = entity.Currency != null && entity.Currency.Id > 0 ? entity.Currency : _Context.Currencies.Find(entity.CurrencyId);
                    _Context.Entry<Customer>(entity.Customer).State = EntityState.Detached;
                    _Context.Entry<Currency>(entity.Currency).State = EntityState.Detached;
                    entity.TRNType = entity.Customer.TRNType;
                    entity.TRNControlId = entity.Customer.TRNControlId;
                    var trnResult = CreateTRN(entity);

                    if (trnResult.Status < 0)
                    {
                        transaction.Rollback();
                        return trnResult;
                    }
                    entity = trnResult.Data.FirstOrDefault();
                    entity.Seller = entity.Seller == null && entity.SellerId.HasValue && entity.SellerId.Value > 0 ?
                        _Context.Sellers.Find(entity.SellerId.Value) : entity.Seller;
                    if (entity.Seller != null)
                        _Context.Entry<Seller>(entity.Seller).State = EntityState.Detached;
                    CreditNote appliedCreditNote = new CreditNote();
                    if (!string.IsNullOrEmpty(entity.AppliedCreditNote))
                        appliedCreditNote = _Context.CreditNotes.AsNoTracking().FirstOrDefault(x => x.Sequence == entity.AppliedCreditNote);

                    if (entity.InvoiceDetails.Count <= 0)
                    {
                        transaction.Rollback();
                        return new Result<Invoice>(-1, -1, "emptyInvoice_msg");
                    }


                    var details = entity.InvoiceDetails;
                    details.ForEach(d => {
                        d.Product = d.Product == null ? _Context.Products.AsNoTracking().Include(x => x.ProductUnits).ThenInclude(x => x.Unit).Include(x => x.Taxes).ThenInclude(x => x.Tax).FirstOrDefault(x => x.Active == true && x.Id == d.ProductId) : d.Product;
                        d.Product.Taxes = d.Product.Taxes == null ? _Context.ProductTaxes.AsNoTracking().Include(x => x.Tax).Where(x => x.Active == true && x.ProductId == d.ProductId) : d.Product.Taxes;
                        d.Amount = d.Amount > 0 ? d.Amount : (d.UnitId.HasValue ? (d.Product.Price/ Convert.ToDecimal(d.Product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId.Value)?.Equivalence)) : d.Product.Price);
                        d.Cost =d.Cost>0?d.Cost: d.Product.Cost * d.Quantity;
                        d.BeforeTaxesAmount =d.BeforeTaxesAmount>0?d.BeforeTaxesAmount: (d.Amount * d.Quantity);
                        d.DiscountAmount =d.DiscountAmount>0?d.DiscountAmount: d.BeforeTaxesAmount * d.DiscountRate;
                        d.TaxesAmount = d.TaxesAmount>0?d.TaxesAmount:(d.BeforeTaxesAmount - d.DiscountAmount) * d.Product.Taxes.Sum(t => t.Tax.Rate);
                        d.TotalAmount =d.TotalAmount>0?d.TotalAmount: d.BeforeTaxesAmount + d.TaxesAmount - d.DiscountAmount - d.CreditNoteAmount;
                    });

                    if (entity.Seller != null && entity.Seller.Id > 0)
                    {
                        decimal comision = 0;
                        details.ForEach(d => {
                          
                             comision = entity.Seller.FixedComission ? ((d.BeforeTaxesAmount) * entity.Seller.ComissionRate) : 0;
                            if (entity.Seller.ComissionByProduct)
                            {
                               
                                    d.Product = d.Product ?? _Context.Products.AsNoTracking().FirstOrDefault(x => x.Active == true && x.Id == d.ProductId);
                                    comision += (d.Product?.SellerRate * d.BeforeTaxesAmount).Value;
                               
                            }
                            d.SellerRate = comision;
                        });
                        entity.SellerRate = details.Sum(x => x.SellerRate);

                    }
                    entity.InvoiceDetails = null;

                    entity.SellerId = entity.SellerId.HasValue && entity.SellerId <= 0 ? null : entity.SellerId;
                    entity.CashRegisterId = entity.CashRegisterId.HasValue && entity.CashRegisterId <= 0 ? null : entity.CashRegisterId;
                    entity.WarehouseId = entity.WarehouseId.HasValue && entity.WarehouseId == 0 ? null : entity.WarehouseId;
                    
                    entity.Id = 0;
                    entity.State = entity.InventoryModified ? (char)Enums.BillingStates.Billed : (char)Enums.BillingStates.Quoted;
                
                   
                  
                    entity.Id = 0;
                    entity.BeforeTaxesAmount = details.Sum(x => x.BeforeTaxesAmount);
                    entity.Cost = details.Sum(x => x.Cost);
                    entity.DiscountAmount = details.Sum(x => x.DiscountAmount);
                    entity.DiscountRate = details.Average(x => x.DiscountRate);
                    entity.TaxesAmount = details.Sum(x => x.TaxesAmount);
                    entity.ReturnedAmount = entity.ReceivedAmount - entity.TotalAmount;
                    entity.TotalAmount = entity.BeforeTaxesAmount + entity.TaxesAmount - entity.DiscountAmount;
                    entity.ExchangeRate = entity.Currency.ExchangeRate;
                    entity.OwedAmount = entity.TotalAmount - entity.PaidAmount - entity.AppliedCreditNoteAmount;
                    entity.ReturnedAmount = entity.ReceivedAmount - entity.TotalAmount;
                    entity.InvoiceNumber =SequencesHelper.CreateSequenceControl(dataRepositoryFactory, Enums.SequenceTypes.Invoices);
                    entity.BillingDate = DateTime.Now;
                    var tempBranchOfiice = entity.BranchOffice ?? _Context.BranchOffices.Find(entity.BranchOfficeId);
                    _Context.Entry<BranchOffice>(tempBranchOfiice).State = EntityState.Detached;
                    entity.State = (entity.PaidAmount == entity.TotalAmount && entity.OwedAmount == 0) ? (char)Enums.BillingStates.FullPaid : (entity.PaidAmount > 0) ? (char)Enums.BillingStates.Paid : entity.State;
                    var creditNoteResult = InvoiceHelper.ApplyCreditNote(entity, appliedCreditNote, out appliedCreditNote);
                    if (creditNoteResult.Status < 0)
                    {
                        transaction.Rollback();
                        return creditNoteResult;
                    }
                    else
                        entity = creditNoteResult.Data.FirstOrDefault();
                    if (entity.OwedAmount > 0)
                    {
                        var balance = _Context.CustomersBalance.AsNoTracking().FirstOrDefault(x => x.CustomerId == entity.CustomerId && x.CurrencyId == entity.CurrencyId && x.Active == true) ??
                            new CustomerBalance() { CustomerId = entity.CustomerId, CurrencyId = entity.CurrencyId, Id = 0, Active = true };

                        balance.OwedAmount += entity.OwedAmount;
                        if (balance.CurrencyId == entity.Customer.CurrencyId && entity.Customer.CreditAmountLimit > 0 && balance.OwedAmount > entity.Customer.CreditAmountLimit)
                        {
                            transaction.Rollback();
                            return new Result<Invoice>(-1, -1, "creditLimitReached_msg");
                        }
                        if (balance.Id > 0)
                            _Context.CustomersBalance.Update(balance);
                        else
                            _Context.CustomersBalance.Add(balance);

                        _Context.SaveChanges();

                    }
                    entity.ReturnedAmount = entity.ReturnedAmount < 0 ? 0 : entity.ReturnedAmount;
                    entity.Customer = null;
                    entity.Currency = null;
                    entity.BranchOffice = null;
                    entity.Payments = new List<CustomerPayment>();
                    entity.Seller = null;
                    entity.Taxes = new List<InvoiceTax>();
                    entity.TRNControl = null;
                    entity.Month = entity.BillingDate.HasValue ? (Enums.Month)entity.BillingDate.Value.Month : (Enums.Month.NotSet);
                    entity.InvoiceDetails = null;
                    var invoice = base.Add(entity).Data.FirstOrDefault();
                    _Context.Entry<Invoice>(invoice).State = EntityState.Detached;
                    if (!string.IsNullOrEmpty(appliedCreditNote.Sequence))
                    {
                        _Context.CreditNotes.Update(appliedCreditNote);
                        _Context.SaveChanges();
                    }

                    details.ForEach(d =>
                    {
                        d.Product = null;
                        d.Date = entity.BillingDate.Value;
                        d.BranchOfficeId = entity.BranchOfficeId;
                        d.InvoiceId = entity.Id;
                    });
                    entity.InvoiceDetails = details;
                    InvoiceDetailsHelper.UpdateInvoiceTaxes(entity, dataRepositoryFactory);
                    entity.InvoiceDetails = null;
                    invoice.BranchOffice = tempBranchOfiice;
            
                    var branchOffice = _Context.BranchOffices.AsNoTracking().FirstOrDefault(x => x.Id == entity.BranchOfficeId && x.Active == true);
                    entity.InvoiceDetails = details;
                    Helpers.InvoiceDetailsHelper.AddDetails(entity, branchOffice, dataRepositoryFactory, false);
                    if (entity.PaidAmount > 0 && entity.Payments != null && entity.Payments.Count > 0)
                    {
                        string sequencePayment = SequencesHelper.CreatePaymentControl(this.dataRepositoryFactory);
                        foreach (var payment in entity.Payments)
                        {
                            payment.InvoiceNumber = entity.InvoiceNumber;
                            payment.CreatedBy = entity.CreatedBy;
                            payment.CreatedDate = entity.CreatedDate;
                            payment.CurrentOwedAmount = payment.OutstandingAmount;
                            payment.Sequence = sequencePayment;
                            InvoiceHelper.ApplyInvoicePayment(payment, this.dataRepositoryFactory.GetCustomDataRepositories<ICustomerPaymentRepository>());
                        }
                    }


                    transaction.Commit();
                    result = new Result<Invoice>(entity.Id, 0, "ok_msg", new List<Invoice>() { invoice });

                    return result;
                }
                catch (Exception ex)
                {
                    result = new Result<Invoice>(-1, -1, "error_msg", null, new Exception(ex.Message));
                    transaction.Rollback();
                    return result;
                }
            }


        }

        private Result<Invoice> CreateTRN(Invoice obj)
        {
            if (!string.IsNullOrEmpty(obj.TRNType) && obj.TRNType != "N/A")
            {

                var trnControl = _Context.TRNsControl.AsNoTracking().FirstOrDefault(x => x.Active == true && x.Type == obj.TRNType);
                if (trnControl == null || trnControl.Quantity <= 0)
                    return new Result<Invoice>(-1, -1, "trnNotAvailable_msg");

                obj.TRN = $"{trnControl.Series}{trnControl.Type}{string.Format("{0:00000000}", trnControl.Sequence)}";
                trnControl.Sequence++;
                trnControl.Quantity--;
                trnControl.NumericControl++;
                _Context.TRNsControl.Update(trnControl);
                _Context.SaveChanges();
                return new Result<Invoice>(0, 0, "ok_msg", new List<Invoice>() { obj });
            }
            return new Result<Invoice>(0, 0, "ok_msg", new List<Invoice>() { obj });
        }

        public override Result<Invoice> Update(Invoice entity, bool getFromDb = true)
        {
            Result<Invoice> result = new Result<Invoice>(-1, -1, "error_msg");
            using (var trans = _Context.Database.BeginTransaction())
            {
                try
                {
                    entity.InvoiceDetails.ForEach(d => {
                        d.Product = d.Product == null ? _Context.Products.AsNoTracking().Include(x => x.ProductUnits).Include(x => x.Taxes).ThenInclude(x => x.Tax).FirstOrDefault(x => x.Active == true && x.Id == d.ProductId) : d.Product;
                        d.Product.ProductUnits = d.Product.ProductUnits == null ? _Context.UnitProductsEquivalences.AsNoTracking().Include(x => x.Unit).Where(x => x.ProductId == d.ProductId && x.Active == true) : d.Product.ProductUnits;
                        d.Product.Taxes = d.Product.Taxes == null ? _Context.ProductTaxes.AsNoTracking().Include(x => x.Tax).Where(x => x.Active == true && x.ProductId == d.ProductId) : d.Product.Taxes;
                        d.Amount = d.Amount > 0 ? d.Amount : (d.UnitId.HasValue ? (d.Product.Price / Convert.ToDecimal(d.Product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId.Value)?.Equivalence)) : d.Product.Price);

                        d.BeforeTaxesAmount = (d.Amount * d.Quantity);
                        d.DiscountAmount = d.BeforeTaxesAmount * d.DiscountRate;
                        d.TaxesAmount = (d.BeforeTaxesAmount - d.DiscountAmount) * d.Product.Taxes.Sum(t => t.Tax.Rate);
                        d.TotalAmount = d.BeforeTaxesAmount + d.TaxesAmount - d.DiscountAmount - d.CreditNoteAmount;
                    });
                    var dbEntity = _Context.Invoices.Find(entity.Id);
                    _Context.Entry<Invoice>(dbEntity).State = EntityState.Detached;
                    var oldDetails = _Context.InvoiceDetails.AsNoTracking()
                        .Include(x => x.Product).ThenInclude(x => x.Taxes).ThenInclude(x => x.Tax)
                        .Include(x => x.Product).ThenInclude(x => x.ProductUnits)
                        .Where(x => x.Active == true && x.InvoiceId == entity.Id).ToList();
                    dbEntity.WarehouseId = entity.WarehouseId.HasValue && entity.WarehouseId == 0 ? null : entity.WarehouseId;
                    dbEntity.BranchOffice = null;
                    dbEntity.Customer = null;
                    dbEntity.Seller = null;
                    dbEntity.State = entity.InventoryModified ? (char)Enums.BillingStates.Billed : (char)Enums.BillingStates.Quoted;
                    oldDetails.AddRange(entity.InvoiceDetails.Where(x => x.Id == 0));
                    if (!dbEntity.InventoryModified && !entity.InventoryModified)
                        oldDetails.ForEach(d =>
                        {
                            if (d.Id > 0)
                            {
                                var newDetail = entity.InvoiceDetails.FirstOrDefault(x => x.Id == d.Id);
                                if (newDetail != null)
                                {
                                    var product = _Context.Products.Include(x => x.ProductUnits).ThenInclude(x => x.Unit).Include(x => x.Taxes).ThenInclude(y => y.Tax).AsNoTracking().FirstOrDefault(x => x.Id == newDetail.ProductId && x.Active == true);
                                    d.Product = null;
                                    d.Unit = null;
                                    d.InvoiceId = entity.Id;
                                    d.WarehouseId = entity.WarehouseId;
                                    d.ProductId = newDetail.ProductId;
                                    d.Quantity = newDetail.Quantity;
                                    d.UnitId = newDetail.UnitId;
                                    d.Active = true;
                                    d.Date = entity.BillingDate.Value;
                                    d.Cost = d.UnitId.HasValue ? Convert.ToDecimal(product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId && d.Active == true)?.CostPrice) : product.Cost;

                                    d.Amount = d.Amount > 0 ? d.Amount : (d.UnitId.HasValue ?product.Price/ Convert.ToDecimal(product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId.Value)?.Equivalence) : product.Price); 
                                    d.BeforeTaxesAmount = (d.Amount * d.Quantity);
                                    d.DiscountAmount = d.BeforeTaxesAmount * d.DiscountRate;
                                    d.TaxesAmount = (d.BeforeTaxesAmount - d.DiscountAmount) * product.Taxes.Sum(t => t.Tax.Rate);
                                    d.TotalAmount = d.BeforeTaxesAmount + d.TaxesAmount - d.DiscountAmount - d.CreditNoteAmount;
                                    _Context.InvoiceDetails.Update(d);

                                }
                                else
                                {
                                    _Context.InvoiceDetails.Remove(d);
                                }
                            }
                            else
                            {
                                var product = _Context.Products.Include(x => x.ProductUnits).ThenInclude(x => x.Unit).Include(x => x.Taxes).ThenInclude(y => y.Tax).AsNoTracking().FirstOrDefault(x => x.Id == d.ProductId && x.Active == true);
                                d.Product = null;
                                d.Unit = null;
                                d.InvoiceId = entity.Id;
                                d.WarehouseId = entity.WarehouseId;
                                d.Active = true;
                                d.Date = entity.BillingDate.Value;
                                d.Cost = d.UnitId.HasValue ? Convert.ToDecimal(product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId && d.Active == true)?.CostPrice) : product.Cost;
                                d.Amount = d.UnitId.HasValue ? Convert.ToDecimal(product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId.Value)?.SellingPrice) : product.Price;
                                d.BeforeTaxesAmount = (d.Amount * d.Quantity);
                                d.DiscountAmount = d.BeforeTaxesAmount * d.DiscountRate;
                                d.TaxesAmount = (d.BeforeTaxesAmount - d.DiscountAmount) * product.Taxes.Sum(t => t.Tax.Rate);
                                d.TotalAmount = d.BeforeTaxesAmount + d.TaxesAmount - d.DiscountAmount - d.CreditNoteAmount;
                                _Context.InvoiceDetails.Add(d);
                            }



                            _Context.SaveChanges();

                        });
                    else if (!dbEntity.InventoryModified && entity.InventoryModified)
                    {
                        _Context.InvoiceDetails.RemoveRange(oldDetails.Where(x => x.Id > 0).Select(x => new InvoiceDetail()
                        {
                            Id = x.Id,
                            ProductId = x.ProductId,
                            UnitId = x.UnitId,
                            BranchOfficeId = x.BranchOfficeId,
                            InvoiceId = x.InvoiceId,
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
                        entity.InvoiceDetails = oldDetails;
                        var branchOffice = _Context.BranchOffices.Find(entity.BranchOfficeId);
                        _Context.Entry<BranchOffice>(branchOffice).State = EntityState.Detached;
                        Helpers.InvoiceDetailsHelper.AddDetails(entity, branchOffice, dataRepositoryFactory, false);
                    }
                    else
                    {

                        var branchOffice = _Context.BranchOffices.Find(entity.BranchOfficeId);
                        _Context.Entry<BranchOffice>(branchOffice).State = EntityState.Detached;
                        Helpers.InvoiceDetailsHelper.UpdateDetails(entity, branchOffice, dataRepositoryFactory);
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
                    dbEntity.InvoiceDetails = null;
                    _Context.Invoices.Update(dbEntity);
                    _Context.SaveChanges();
                    trans.Commit();
                    result = new Result<Invoice>(entity.Id, 0, "ok_msg");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = new Result<Invoice>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public override Result<Invoice> Remove(long id)
        {
            var result = new Result<Invoice>(-1, -1, "error_msg");

            using (var trans = _Context.Database.BeginTransaction())
            {
                try
                {
                 
                  
                   
                        var invoice = _Context.Invoices.Find(id);
                        _Context.Entry<Invoice>(invoice).State = EntityState.Detached;
                        if (invoice.BillingState != Enums.BillingStates.Billed)
                        {
                            trans.Rollback();
                            return new Result<Invoice>(-1, -1, "leadIsBilled_msg");
                        }
                        else
                            CancelInvoice(invoice);
                    
                    trans.Commit();
                    result = new Result<Invoice>(id, 0, "ok_msg");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = new Result<Invoice>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        private void CancelInvoice(Invoice invoiceLead)
        {
            var details = _Context.InvoiceDetails.AsNoTracking().Include(x => x.Product).Include(x => x.Unit).Where(x => x.Active == true && x.InvoiceId == invoiceLead.Id).ToList();
            if (invoiceLead.BillingState != Enums.BillingStates.Quoted && invoiceLead.BillingState != Enums.BillingStates.Nulled && invoiceLead.InventoryModified)
            {

                details.ForEach(d =>
                {
                    InventoryHelper.AddInventory(d, invoiceLead, dataRepositoryFactory);
                });

            }
            details.ForEach(d =>
            {
                d.Product = null;
                d.Unit = null;
            });
            invoiceLead.State = (char)Enums.BillingStates.Nulled;
            invoiceLead.InventoryModified = false;
            _Context.Invoices.Update(invoiceLead);
            _Context.SaveChanges();
        }

        public List<CompanyStateModel> GetCompanyStatus(DateTime? initialDate, DateTime? endDate)
        {
            
            List<CompanyStateModel> result = new List<CompanyStateModel>();
            var expenses = _Context.Expenses.Include(x => x.Payments).ThenInclude(p => p.Currency)
                .Include(x=>x.Supplier)
                .Include(x => x.Currency).AsNoTracking().Where(x => x.Active == true && (x.State == (char)BillingStates.Billed || x.State == (char)BillingStates.Paid || x.State == (char)BillingStates.FullPaid)
                && x.Date>=(initialDate.HasValue?initialDate.Value:DateTime.MinValue) && x.Date<=(endDate.HasValue?endDate.Value:DateTime.Now)).ToList();
           
            var invoices = _Context.Invoices.Include(x => x.Payments).ThenInclude(p => p.Currency)
                .Include(x=>x.Customer)
                .Include(x => x.Currency).AsNoTracking().Where(x => x.Active == true && (x.State == (char)BillingStates.Billed || x.State == (char)BillingStates.Paid || x.State == (char)BillingStates.FullPaid)
                  && x.BillingDate >= (initialDate.HasValue ? initialDate.Value : DateTime.MinValue) && x.BillingDate <= (endDate.HasValue ? endDate.Value : DateTime.Now)).ToList();

            expenses.ForEach(expense => {
                result.Add(new CompanyStateModel()
                {
                    CompanyOwedAmount = expense.TotalAmount,
                    CustomersOwedAmount = 0,
                    IncomeAmount = 0,
                    OutcomeAmount = 0,
                    CurrencyCode = expense.Currency.Code,
                    CurrencyId = expense.CurrencyId,
                    CurrencyName = expense.Currency.Name,
                    CustomerName = string.Empty,
                    Date = expense.Date,
                    Reference = expense.Sequence,
                    Details = $"{expense.Supplier.Name}",
                    ExchangeRate = expense.ExchangeRate,
                    SellerName = string.Empty
                });
                expense.Payments.Where(x => x.Active == true && x.State == (char)Enums.BillingStates.Paid).ToList().ForEach(payment => {
                    result.Add(new CompanyStateModel() {
                    CompanyOwedAmount=0,
                    CustomersOwedAmount=0,
                    IncomeAmount=0,
                    OutcomeAmount=payment.PaidAmount,
                    CurrencyCode=payment.Currency.Code,
                    CurrencyId=payment.CurrencyId,
                    CurrencyName=payment.Currency.Name,
                    CustomerName="",
                    Date=payment.Date,
                    Details=$"{expense.Supplier.Name}",
                    ExchangeRate=payment.ExchangeRate,
                    Reference=payment.Sequence,
                    SellerName=string.Empty
                    });
                });
            });


            invoices.ForEach(invoice => {
                result.Add(new CompanyStateModel()
                {
                    CompanyOwedAmount = 0,
                    CustomersOwedAmount = invoice.TotalAmount,
                    IncomeAmount = 0,
                    OutcomeAmount =invoice.Cost,
                    CurrencyCode = invoice.Currency.Code,
                    CurrencyId = invoice.CurrencyId,
                    CurrencyName = invoice.Currency.Name,
                    CustomerName = invoice.Customer.NameAndCode,
                    Date = invoice.BillingDate.Value,
                    Reference = invoice.InvoiceNumber,
                    Details = $"{invoice.Customer.NameAndCode}",
                    ExchangeRate = invoice.ExchangeRate,
                    SellerName = string.Empty
                });
                invoice.Payments.Where(x => x.Active == true && x.State==(char)BillingStates.Paid).ToList().ForEach(payment => {
                    result.Add(new CompanyStateModel()
                    {
                        CompanyOwedAmount = 0,
                        CustomersOwedAmount = 0,
                        IncomeAmount = payment.PaidAmount,
                        OutcomeAmount =0,
                        CurrencyCode = payment.Currency.Code,
                        CurrencyId = payment.CurrencyId,
                        CurrencyName = payment.Currency.Name,
                        CustomerName = "",
                        Date = payment.Date,
                        Details = $"{invoice.Customer.NameAndCode}",
                        ExchangeRate = payment.ExchangeRate,
                        Reference = payment.Sequence,
                        SellerName = string.Empty
                    });
                });
            });



            return result;
        }
    }
}

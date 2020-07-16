using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class ExpenseRepository : Repository<Expense>, IExpenseRepository
    {
        readonly ISequenceManagerRepository _sequenceRepo;
        public ExpenseRepository(MainDataContext context, ISequenceManagerRepository sequenceManagerRepository) : base(context)
        {
            this._sequenceRepo = sequenceManagerRepository;
        }

        public IEnumerable<Expense> GetDebsToPay(DateTime? startDate, DateTime? endDate, long? supplierId, long? currencyId, long? branchOfficeId)
        {
            Func<Expense, bool> func = expense => expense.Active == true && expense.OwedAmount > 0 && expense.State != (char)Enums.BillingStates.Nulled && expense.State != (char)Enums.BillingStates.FullPaid
            && (startDate.HasValue ? expense.Date >= startDate.Value : expense.Id > 0) &&
            (endDate.HasValue ? expense.Date <= endDate.Value : expense.Id > 0) && (supplierId.HasValue && supplierId.Value>0 ? expense.SupplierId == supplierId.Value : expense.Id > 0) &&
            (currencyId.HasValue && currencyId.Value > 0 ? expense.CurrencyId == currencyId.Value : expense.Id > 0) && (branchOfficeId.HasValue && branchOfficeId.Value > 0 ? expense.BranchOfficeId == branchOfficeId.Value : expense.Id > 0)
            ;
            return _Context.Expenses.Include(x=>x.BranchOffice).Include(x=>x.Currency).Include(x=>x.Supplier).Where(func);
        }

        public override Result<Expense> Add(Expense entity)
        {
            Result<Expense> result = new Result<Expense>(-1, -1, "");

            using (var trans = _Context.Database.BeginTransaction())
            {
                var currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                try
                {
                    entity.Sequence = _sequenceRepo.CreateSequence(Enums.SequenceTypes.Expenses);
                    entity.ExpenseReference = entity.ExpenseReference ?? "";
                    var taxes = entity.Taxes?.ToList();
                    entity.Currency = entity.Currency ?? _Context.Currencies.Find(entity.CurrencyId);
                    _Context.Entry<Currency>(entity.Currency).State = EntityState.Detached;
                    var currency = entity.Currency;
                    taxes.ForEach(d =>
                    {
                        d.Id = 0;
                        d.Date = entity.Date;
                        d.CurrencyId = entity.CurrencyId;
                        d.Currency = entity.Currency;
                        d.Expense = null;
                        d.TRN = entity.TRN;
                        d.Reference = entity.Sequence;
                        d.Tax = d.Tax ?? _Context.Taxes.Find(d.TaxId);
                        _Context.Entry<Tax>(d.Tax).State = EntityState.Detached;
                        d.TaxAmount = d.Tax.Rate * entity.BeforeTaxesAmount;
                        d.ExchangeRateAmount = (d.Currency.ExchangeRate * d.TaxAmount);
                        d.Currency = null;
                        d.Tax = null;
                    });
                    entity.BranchOffice = null;
                    entity.PaymentType = null;
                    entity.TotalAmount = entity.BeforeTaxesAmount + taxes.Sum(x => x.TaxAmount);
                    entity.PaidAmount = entity.PaymentTypeId.HasValue ? (entity.GivenAmount >= entity.TotalAmount ? entity.TotalAmount : entity.GivenAmount) : 0;
                    entity.ReturnedAmount = entity.PaymentTypeId.HasValue ? (entity.GivenAmount > entity.TotalAmount ? entity.GivenAmount - entity.TotalAmount : 0) : 0;
                    entity.Supplier = null;
                    entity.TaxesAmount = taxes.Sum(d => d.TaxAmount);
                    entity.Taxes = null;
                    entity.State = entity.PaidAmount > 0 ? (char)Enums.BillingStates.Paid : (char)Enums.BillingStates.Billed;
                    entity.OwedAmount = entity.TotalAmount - entity.PaidAmount;
                    entity.ExchangeRateAmount = entity.Currency.ExchangeRate * entity.TotalAmount;
                    entity.ExchangeRate = entity.Currency.ExchangeRate;
                    entity.Currency = null;
                    _Context.Expenses.Add(entity);
                    _Context.SaveChanges();

                    taxes.ForEach(x => { x.ExpenseId = entity.Id; });
                    _Context.ExpenseTaxes.AddRange(taxes);
                    _Context.SaveChanges();
                    if (entity.PaymentTypeId.HasValue && entity.PaidAmount > 0)
                    {

                        var payment = new CompanyPayments()
                        {
                            PaidAmount = entity.PaidAmount,
                            TotalAmount = entity.TotalAmount,
                            GivenAmount = entity.GivenAmount,
                            PaymentDestinationId = entity.SupplierId,
                            Date = DateTime.Now,
                            CurrencyId = entity.CurrencyId,
                            ExchangeRate = currency.ExchangeRate,
                            OutstandingAmount = entity.OwedAmount,
                            ExchangeRateAmount = entity.PaidAmount * currency.ExchangeRate,
                            DestinationType = (byte)Enums.CompanyPaymentTypes.ExpensePayment,
                            Details = entity.Details,
                            Reference = entity.ExpenseReference,
                            Sequence = _sequenceRepo.CreateSequence(Enums.SequenceTypes.CompanyPayments),
                            PaymentTypeId = entity.PaymentTypeId.Value,
                            State = entity.State,
                            PositiveBalance = entity.GivenAmount - entity.PaidAmount

                        };
                        _Context.CompanyPayments.Add(payment);
                        _Context.SaveChanges();
                        ExpensesPayment expensePayment = new ExpensesPayment()
                        {
                            Date = DateTime.Now,
                            Sequence = _sequenceRepo.CreateSequence(Enums.SequenceTypes.ExpensePayments),
                            PaymentSequence = payment.Sequence,
                            PaidAmount = entity.PaidAmount,
                            TotalAmount = entity.TotalAmount,
                            State = (char)Enums.BillingStates.Paid,
                            CurrencyId = entity.CurrencyId,
                            Details = entity.Details,
                            ExchangeRate = currency.ExchangeRate,
                            ExchangeRateAmount = entity.PaidAmount * currency.ExchangeRate,
                            PositiveBalance = entity.GivenAmount - entity.PaidAmount,
                            GivenAmount = entity.GivenAmount,
                            PaymentId = payment.Id,
                            ExpenseCurrencyId = entity.CurrencyId,
                            PaymentType = null,
                            ExpenseId = entity.Id,
                            PaymentTypeId = entity.PaymentTypeId.Value,
                            ExpenseReference = entity.Sequence,
                            OutstandingAmount = entity.OwedAmount,
                            CurrentOutstandingAmount = entity.OwedAmount,
                            SupplierId = entity.SupplierId
                        };
                        _Context.ExpensesPayments.Add(expensePayment);
                        _Context.SaveChanges();
                    }

                    trans.Commit();
                    result = new Result<Expense>(entity.Id, 0, "ok_msg", new List<Expense>() { entity });
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = new Result<Expense>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public override Result<Expense> Update(Expense entity, bool fromDb = true)
        {
            Result<Expense> result = new Result<Expense>(-1, -1, "");

            using (var trans = _Context.Database.BeginTransaction())
            {
                var oldValue = _Context.Expenses.Find(entity.Id);
                _Context.Entry<Expense>(oldValue).State = EntityState.Detached;
                if (oldValue == null || oldValue.State != (char)Enums.BillingStates.Billed || _Context.ExpensesPayments.AsNoTracking().Count(x => x.Active == true && x.State == (char)Enums.BillingStates.Paid && x.ExpenseId == entity.Id) > 0)
                {
                    trans.Rollback();
                    return new Result<Expense>(-1, -1, "CannotUpdateExpense_msg");
                }
                var currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                try
                {

                    entity.ExpenseReference = entity.ExpenseReference ?? "";
                    entity.Date = DateTime.MinValue == entity.Date ? currentDate : entity.Date;
                    var taxes = entity.Taxes?.ToList();
                    entity.Currency = entity.Currency ?? _Context.Currencies.Find(entity.CurrencyId);
                    _Context.Entry<Currency>(entity.Currency).State = EntityState.Detached;
                    var currency = entity.Currency;
                    var oldTaxes = _Context.ExpenseTaxes.AsNoTracking().Where(x => x.Active == true && x.ExpenseId == entity.Id).ToList();
                    //oldTaxes.ForEach(o => {
                    //    if (!taxes.Any(x => x.Id == o.Id)) 
                    //    {
                    //        _Context.ExpenseTaxes.Remove(o);
                    //        _Context.SaveChanges();
                    //    }
                    //});

                    _Context.ExpenseTaxes.RemoveRange(oldTaxes.Where(x => !taxes.Any(y => y.Id == x.Id)));
                    _Context.SaveChanges();
                    taxes.ForEach(d =>
                    {
                        d.Date = entity.Date;
                        d.CurrencyId = entity.CurrencyId;
                        d.Currency = entity.Currency;
                        d.Expense = null;
                        d.TRN = entity.TRN;
                        d.Reference = entity.Sequence;
                        d.Tax = d.Tax ?? _Context.Taxes.Find(d.TaxId);
                        _Context.Entry<Tax>(d.Tax).State = EntityState.Detached;
                        d.TaxAmount = d.Tax.Rate * entity.BeforeTaxesAmount;
                        d.ExchangeRateAmount = (d.Currency.ExchangeRate * d.TaxAmount);
                        d.Currency = null;
                        d.Tax = null;
                        if (d.Id == 0)
                            _Context.ExpenseTaxes.Add(d);
                        else
                            _Context.ExpenseTaxes.Update(d);

                        _Context.SaveChanges();
                    });
                    entity.BranchOffice = null;
                    entity.PaymentType = null;
                    entity.TotalAmount = entity.BeforeTaxesAmount + taxes.Sum(x => x.TaxAmount);
                    entity.PaidAmount = entity.PaymentTypeId.HasValue ? (entity.GivenAmount >= entity.TotalAmount ? entity.TotalAmount : entity.GivenAmount) : 0;
                    entity.ReturnedAmount = entity.PaymentTypeId.HasValue ? (entity.GivenAmount > entity.TotalAmount ? entity.GivenAmount - entity.TotalAmount : 0) : 0;
                    entity.Supplier = null;
                    entity.Taxes = null;
                    entity.TaxesAmount = taxes.Sum(x => x.TaxAmount);
                    entity.State = entity.PaidAmount > 0 ? (char)Enums.BillingStates.Paid : (char)Enums.BillingStates.Billed;
                    entity.OwedAmount = entity.TotalAmount - entity.PaidAmount;
                    entity.ExchangeRateAmount = entity.Currency.ExchangeRate * entity.TotalAmount;
                    entity.Currency = null;
                    _Context.Expenses.Update(entity);
                    _Context.SaveChanges();
                    if (entity.PaymentTypeId.HasValue && entity.PaidAmount > 0)
                    {
                        var payment = new CompanyPayments()
                        {
                            PaidAmount = entity.PaidAmount,
                            TotalAmount = entity.TotalAmount,
                            GivenAmount = entity.GivenAmount,
                            PaymentDestinationId = entity.SupplierId,
                            Date = DateTime.Now,
                            CurrencyId = entity.CurrencyId,
                            ExchangeRate = currency.ExchangeRate,
                            OutstandingAmount = entity.OwedAmount,
                            ExchangeRateAmount = entity.PaidAmount * currency.ExchangeRate,
                            DestinationType = (byte)Enums.CompanyPaymentTypes.ExpensePayment,
                            Details = entity.Details,
                            Reference = entity.ExpenseReference,
                            Sequence = _sequenceRepo.CreateSequence(Enums.SequenceTypes.CompanyPayments),
                            PaymentTypeId = entity.PaymentTypeId.Value,
                            State = entity.State,
                            PositiveBalance = entity.GivenAmount - entity.PaidAmount

                        };
                        _Context.CompanyPayments.Add(payment);
                        _Context.SaveChanges();
                        ExpensesPayment expensePayment = new ExpensesPayment()
                        {
                            PaidAmount = entity.PaidAmount,
                            Date = DateTime.Now,
                            Sequence = _sequenceRepo.CreateSequence(Enums.SequenceTypes.ExpensePayments),
                            TotalAmount = entity.TotalAmount,
                            State = (char)Enums.BillingStates.Paid,
                            CurrencyId = entity.CurrencyId,
                            Details = entity.Details,
                            ExchangeRate = currency.ExchangeRate,
                            ExchangeRateAmount = entity.PaidAmount * currency.ExchangeRate,
                            PositiveBalance = entity.GivenAmount - entity.PaidAmount,
                            GivenAmount = entity.GivenAmount,
                            PaymentId = payment.Id,
                            ExpenseCurrencyId = entity.CurrencyId,
                            PaymentType = null,
                            ExpenseId = entity.Id,
                            PaymentTypeId = entity.PaymentTypeId.Value,
                            ExpenseReference = entity.Sequence,
                            OutstandingAmount = entity.OwedAmount,
                            PaymentSequence = payment.Sequence,
                            CurrentOutstandingAmount = entity.OwedAmount,
                            SupplierId = entity.SupplierId
                        };
                        _Context.ExpensesPayments.Add(expensePayment);
                        _Context.SaveChanges();
                    }

                    trans.Commit();
                    result = new Result<Expense>(entity.Id, 0, "ok_msg", new List<Expense>() { entity });
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = new Result<Expense>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public override Result<Expense> Remove(long id)
        {
            Result<Expense> result = new Result<Expense>(-1, -1, "");

            using (var trans = _Context.Database.BeginTransaction())
            {
                var entity = _Context.Expenses.Find(id);
                _Context.Entry<Expense>(entity).State = EntityState.Detached;

                if (entity == null || entity.State != (char)Enums.BillingStates.Billed || _Context.ExpensesPayments.AsNoTracking().Count(x => x.Active == true && x.State != (char)Enums.BillingStates.Paid && x.ExpenseId == id) > 0)
                {
                    trans.Rollback();
                    return new Result<Expense>(-1, -1, "CannotDeleteExpense_msg");
                }

                try
                {
                    entity.State = (char)Enums.BillingStates.Nulled;
                    _Context.Expenses.Update(entity);
                    _Context.SaveChanges();
                    trans.Commit();
                    result = new Result<Expense>(entity.Id, 0, "ok_msg", new List<Expense>() { entity });
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = new Result<Expense>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }
    }
}

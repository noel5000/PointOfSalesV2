using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository
{
    public class ExpensesPaymentRepository : Repository<ExpensesPayment>, IExpensesPaymentRepository
    {
        readonly ISequenceManagerRepository _sequenceRepo;
        public ExpensesPaymentRepository(MainDataContext context, ISequenceManagerRepository sequenceManagerRepository) : base(context)
        {
            this._sequenceRepo = sequenceManagerRepository;
        }



        public override Result<ExpensesPayment> Add(ExpensesPayment entity)
        {
            throw new NotImplementedException();
        }

        public override Result<ExpensesPayment> Update(ExpensesPayment entity, bool fromDb = true)
        {
            return new Result<ExpensesPayment>(-1, -1, "cannotUpdatePayment_msg");
        }

        public override Result<ExpensesPayment> Remove(long id)
        {
            Result<ExpensesPayment> result = new Result<ExpensesPayment>(-1, -1, "");

            using (var trans = _Context.Database.BeginTransaction())
            {
                var entity = _Context.ExpensesPayments.Find(id);
                _Context.Entry<ExpensesPayment>(entity).State = EntityState.Detached;

                if (entity == null)
                {
                    trans.Rollback();
                    return new Result<ExpensesPayment>(-1, -1, "CannotDeleteExpense_msg");
                }

                try
                {
                    var expense = _Context.Expenses.Find(entity.ExpenseId);
                    if (expense.State != (char)Enums.BillingStates.Paid)
                    {
                        trans.Rollback();
                        return new Result<ExpensesPayment>(-1, -1, "CannotDeleteExpense_msg");
                    }
                    _Context.Entry<Expense>(expense).State = EntityState.Detached;
                    entity.State = (char)Enums.BillingStates.Nulled;
                    expense.OwedAmount += entity.PaidAmount;
                    expense.OwedAmount = expense.OwedAmount > expense.TotalAmount ? expense.TotalAmount : expense.OwedAmount;

                    expense.PaidAmount -= entity.PaidAmount;
                    expense.PaidAmount = expense.PaidAmount <= 0 ? 0 : expense.PaidAmount;
                    expense.State = expense.PaidAmount <= 0 && expense.State == (char)Enums.BillingStates.Paid ? (char)Enums.BillingStates.Billed : expense.State;
                    _Context.ExpensesPayments.Update(entity);
                    _Context.SaveChanges();
                    _Context.Expenses.Update(expense);
                    _Context.SaveChanges();
                    trans.Commit();
                    result = new Result<ExpensesPayment>(entity.Id, 0, "ok_msg", new List<ExpensesPayment>() { entity });
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = new Result<ExpensesPayment>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public Result<Payment> AddPayment(CompanyPayments payment, List<Expense> expenses)
        {
            Result<Payment> result = new Result<Payment>(-1, -1, "");

            using (var trans = _Context.Database.BeginTransaction())
            {
                var currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                try
                {
                    var currency = _Context.Currencies.Find(payment.CurrencyId);
                    _Context.Entry<Currency>(currency).State = EntityState.Detached;
                    var paymentEntity = new CompanyPayments()
                    {
                        PaidAmount = payment.PaidAmount,
                        TotalAmount = payment.TotalAmount,
                        PaymentDestinationId=payment.PaymentDestinationId,
                        GivenAmount = payment.GivenAmount,
                        Date = DateTime.Now,
                        CurrencyId = payment.CurrencyId,
                        ExchangeRate = currency.ExchangeRate,
                        OutstandingAmount = payment.OutstandingAmount,
                        ExchangeRateAmount = payment.PaidAmount * currency.ExchangeRate,
                        DestinationType = (byte)Enums.CompanyPaymentTypes.ExpensePayment,
                        Details = payment.Details,
                        Reference = payment.Reference,
                        Sequence = _sequenceRepo.CreateSequence(Enums.SequenceTypes.CompanyPayments),
                        PaymentTypeId = payment.PaymentTypeId,
                        State = (char)Enums.BillingStates.Paid,
                        PositiveBalance = payment.GivenAmount - payment.PaidAmount,
                    };
                    _Context.CompanyPayments.Add(paymentEntity);
                    _Context.SaveChanges();

                    var expensePaymentSeq = _Context.SequencesControl.AsNoTracking().FirstOrDefault(x => x.Active == true && x.Code == (short)Enums.SequenceTypes.ExpensePayments);
                    expenses.ForEach(e =>
                    {
                        string sequence = String.Format("{0}{1:00000}", ((SequenceTypeCode)(short)expensePaymentSeq.Code).ToString(), (expensePaymentSeq.NumericControl + 1));
                        expensePaymentSeq.NumericControl += 1;

                        ExpensesPayment expensesPayment = new ExpensesPayment()
                        {
                            ExchangeRateAmount = currency.ExchangeRate * e.CurrentPaidAmount,
                            GivenAmount = payment.GivenAmount,
                            Sequence = sequence,
                            OutstandingAmount = e.OwedAmount - e.CurrentPaidAmount,
                            CurrentOutstandingAmount = e.OwedAmount - e.CurrentPaidAmount,
                            PaidAmount = e.CurrentPaidAmount,
                            TotalAmount = e.TotalAmount,
                            ExchangeRate = currency.ExchangeRate,
                            CurrencyId = currency.Id,
                            Date = paymentEntity.Date,
                            Details = payment.Details,
                            ExpenseCurrencyId = e.CurrencyId,
                            ExpenseId = e.Id,
                            ExpenseReference = e.Sequence,
                            PaymentSequence = paymentEntity.Sequence,
                            PaymentId = paymentEntity.Id,
                            PaymentTypeId = payment.PaymentTypeId,
                            PositiveBalance = e.OwedAmount - e.CurrentPaidAmount,
                            State = (char)Enums.BillingStates.Paid,
                            SupplierId = e.SupplierId
                        };
                        _Context.ExpensesPayments.Add(expensesPayment);
                        _Context.SaveChanges();

                        e.State = (char)Enums.BillingStates.Paid;
                        e.PaidAmount += expensesPayment.PaidAmount;
                        e.PaidAmount = e.PaidAmount > e.TotalAmount ? e.TotalAmount : e.PaidAmount;
                        e.OwedAmount -= expensesPayment.PaidAmount;
                        e.OwedAmount = e.OwedAmount < 0 ? 0 : e.OwedAmount;
                        e.CurrentPaidAmount = e.PaidAmount;
                        e.Currency = null;
                        e.Supplier = null;
                        e.BranchOffice = null;
                        e.Payments = null;
                        e.PaymentType = null;
                        e.Taxes = null;
                        _Context.Expenses.Update(e);
                        _Context.SaveChanges();
                    });
                    _Context.SequencesControl.Update(expensePaymentSeq);
                    _Context.SaveChanges();
                    trans.Commit();
                    result = new Result<Payment>(0, (int)paymentEntity.Id, "ok_msg");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = new Result<Payment>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }
    }
}

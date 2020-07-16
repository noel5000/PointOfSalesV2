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
    public class CompanyPaymentRepository : Repository<CompanyPayments>, ICompanyPaymentRepository
    {
        readonly ISequenceManagerRepository _sequenceRepo;
        public CompanyPaymentRepository(MainDataContext context, ISequenceManagerRepository sequenceManagerRepository) : base(context)
        {
            this._sequenceRepo = sequenceManagerRepository;
        }



        public override Result<CompanyPayments> Add(CompanyPayments entity)
        {

            Result<CompanyPayments> result = new Result<CompanyPayments>(-1, -1, "error_msg");

            using (var trans = _Context.Database.BeginTransaction())
            {
                var currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                try
                {
                    var currency = _Context.Currencies.Find(entity.CurrencyId);
                    _Context.Entry<Currency>(currency).State = EntityState.Detached;
                    var paymentEntity = new CompanyPayments()
                    {
                        PaidAmount = entity.PaidAmount,
                        TotalAmount = entity.TotalAmount,
                        PaymentDestinationId = entity.PaymentDestinationId,
                        GivenAmount = entity.GivenAmount,
                        Date = DateTime.Now,
                        CurrencyId = entity.CurrencyId,
                        ExchangeRate = currency.ExchangeRate,
                        OutstandingAmount = entity.OutstandingAmount,
                        ExchangeRateAmount = entity.PaidAmount * currency.ExchangeRate,
                        DestinationType = entity.DestinationType,
                        Details = entity.Details,
                        Reference = entity.Reference,
                        Sequence = _sequenceRepo.CreateSequence(Enums.SequenceTypes.CompanyPayments),
                        PaymentTypeId = entity.PaymentTypeId,
                        State = (char)Enums.BillingStates.Paid,
                        PositiveBalance = entity.GivenAmount - entity.PaidAmount,
                    };
                    _Context.CompanyPayments.Add(paymentEntity);
                    _Context.SaveChanges();
                    trans.Commit();
                    result = new Result<CompanyPayments>(0, (int)paymentEntity.Id, "ok_msg");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = new Result<CompanyPayments>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
           
        }

        public override Result<CompanyPayments> Update(CompanyPayments entity, bool fromDb = true)
        {
            Result<CompanyPayments> result = new Result<CompanyPayments>(-1, -1, "error_msg");

            using (var trans = _Context.Database.BeginTransaction())
            {
                var currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                try
                {
                    var currency = _Context.Currencies.Find(entity.CurrencyId);
                    _Context.Entry<Currency>(currency).State = EntityState.Detached;
                    var paymentEntity = new CompanyPayments()
                    {
                        Id=entity.Id,
                        PaidAmount = entity.PaidAmount,
                        TotalAmount = entity.TotalAmount,
                        PaymentDestinationId = entity.PaymentDestinationId,
                        GivenAmount = entity.GivenAmount,
                        Date = DateTime.Now,
                        CurrencyId = entity.CurrencyId,
                        ExchangeRate = currency.ExchangeRate,
                        OutstandingAmount = entity.OutstandingAmount,
                        ExchangeRateAmount = entity.PaidAmount * currency.ExchangeRate,
                        DestinationType = entity.DestinationType,
                        Details = entity.Details,
                        Reference = entity.Reference,
                        PaymentTypeId = entity.PaymentTypeId,
                        State = (char)Enums.BillingStates.Paid,
                        PositiveBalance = entity.GivenAmount - entity.PaidAmount,
                    };
                    _Context.CompanyPayments.Update(paymentEntity);
                    _Context.SaveChanges();
                    trans.Commit();
                    result = new Result<CompanyPayments>(0, (int)paymentEntity.Id, "ok_msg");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = new Result<CompanyPayments>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public override Result<CompanyPayments> Remove(long id)
        {
            Result<CompanyPayments> result = new Result<CompanyPayments>(-1, -1, "error_msg");

            var payment = _Context.CompanyPayments.Find(id);
            _Context.Entry<CompanyPayments>(payment).State = EntityState.Detached;
            IEnumerable<ICommonData> children = null;

            switch (payment.DestinationType) 
            {
                case (byte)Enums.CompanyPaymentTypes.ExpensePayment:
                    children = _Context.ExpensesPayments.AsNoTracking().Where(x => x.PaymentId == id && x.Active == true && x.State != (char)Enums.BillingStates.Nulled);
                    break;
                case (byte)Enums.CompanyPaymentTypes.CustomerPayment:
                    throw new NotImplementedException();
                    break;
            }
            if (children !=null && children.Count() > 0) 
            {
                return result;
            }
            payment.State = (char)Enums.BillingStates.Nulled;
            _Context.CompanyPayments.Update(payment);
            _Context.SaveChanges();

            return result;
        }

     
    }
}

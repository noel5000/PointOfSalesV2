using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface ICustomerPaymentRepository: IBase<CustomerPayment>
    {
        CustomerPayment ApplyInvoicePayment(CustomerPayment payment);
        public List<CustomerPayment> IncomesReport(long branchOfficeId, long customerId, long currencyId, long paymentTypeId, DateTime? initialDate, DateTime? endDate);
        public object CommisionsReport(object searchParams);

        Result<object> PayInvoices(InvoicesPaymentModel model);
        Result<object> ReversePayment(string sequence, string userId);
    }
}

using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IBusinessStateRepository 
    {
        List<object> GetFinancialState(DateTime? startDate, DateTime? endDate);

        public List<TaxesReport> GetTaxesReport(DateTime? startDate, DateTime? endDate);
    }
}

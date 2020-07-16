using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers.BillServices
{
    public abstract class BillProductServiceBase : IBillProductsServices
    {
        public Result<LeadDetail> ProcessProductService(long branchOfficeId, LeadDetail detail, IDataRepositoryFactory _dataRepositoryFactory, InvoiceLead lead)
        {
            return ProcessDetail(branchOfficeId, detail, _dataRepositoryFactory, lead);
        }

        public Result<LeadDetail> ReturnProductService(long branchOfficeId, LeadDetail detail, IDataRepositoryFactory _dataRepositoryFactory, InvoiceLead lead)
        {
            return ProcessReturnDetail(branchOfficeId, detail, _dataRepositoryFactory, lead);
        }

        protected abstract Result<LeadDetail> ProcessDetail(long branchOfficeId, LeadDetail detail, IDataRepositoryFactory dataRepositoryFactory, InvoiceLead lead);

        protected abstract Result<LeadDetail> ProcessReturnDetail(long branchOfficeId, LeadDetail detail, IDataRepositoryFactory dataRepositoryFactory, InvoiceLead lead);

    }
}

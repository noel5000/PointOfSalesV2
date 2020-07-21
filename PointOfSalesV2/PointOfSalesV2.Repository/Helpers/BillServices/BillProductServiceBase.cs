using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers.BillServices
{
    public abstract class BillProductServiceBase : IBillProductsServices
    {
        public Result<InvoiceDetail> ProcessProductService(long branchOfficeId, InvoiceDetail detail, IDataRepositoryFactory _dataRepositoryFactory, Invoice lead)
        {
            return ProcessDetail(branchOfficeId, detail, _dataRepositoryFactory, lead);
        }

        public Result<InvoiceDetail> ReturnProductService(long branchOfficeId, InvoiceDetail detail, IDataRepositoryFactory _dataRepositoryFactory, Invoice lead)
        {
            return ProcessReturnDetail(branchOfficeId, detail, _dataRepositoryFactory, lead);
        }

        protected abstract Result<InvoiceDetail> ProcessDetail(long branchOfficeId, InvoiceDetail detail, IDataRepositoryFactory dataRepositoryFactory, Invoice lead);

        protected abstract Result<InvoiceDetail> ProcessReturnDetail(long branchOfficeId, InvoiceDetail detail, IDataRepositoryFactory dataRepositoryFactory, Invoice lead);

    }
}

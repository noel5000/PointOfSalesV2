using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers.BillServices
{
    public interface IBillProductsServices
    {
        Result<InvoiceDetail> ProcessProductService(long branchOfficeId, InvoiceDetail details, IDataRepositoryFactory _dataRepositoryFactory, Invoice invoice);

        Result<InvoiceDetail> ReturnProductService(long branchOfficeId, InvoiceDetail details, IDataRepositoryFactory _dataRepositoryFactory, Invoice invoice);
    }
}

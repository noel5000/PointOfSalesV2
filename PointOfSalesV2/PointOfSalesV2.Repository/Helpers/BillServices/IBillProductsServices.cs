using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository.Helpers.BillServices
{
    public interface IBillProductsServices
    {
        Result<LeadDetail> ProcessProductService(long branchOfficeId, LeadDetail details, IDataRepositoryFactory _dataRepositoryFactory, InvoiceLead invoice);

        Result<LeadDetail> ReturnProductService(long branchOfficeId, LeadDetail details, IDataRepositoryFactory _dataRepositoryFactory, InvoiceLead invoice);
    }
}

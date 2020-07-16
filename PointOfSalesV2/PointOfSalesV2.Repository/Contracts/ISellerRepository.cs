using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface ISellerRepository : IBase<Seller>
    {
        ComissionsReport SalesComissions(ComissionsSearch search);
        ComissionsReport PaymentsComissions(ComissionsSearch search);
    }
}

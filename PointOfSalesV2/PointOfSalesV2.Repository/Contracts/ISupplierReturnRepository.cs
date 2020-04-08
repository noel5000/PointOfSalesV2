using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface ISupplierReturnRepository: IBase<SupplierReturn>
    {
        Result<object> AddInventoryList(List<SupplierReturn> entries, string reference, string details);
        Result<object> RemoveEntries(string sequence);
    }
}

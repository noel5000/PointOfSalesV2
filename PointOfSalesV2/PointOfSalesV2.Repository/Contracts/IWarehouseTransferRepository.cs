using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IWarehouseTransferRepository: IBase<WarehouseTransfer>
    {
        Result<object> AddTransfersList(List<WarehouseTransfer> entries, string reference, string details);
        Result<object> RemoveTransfers(string sequence);
    }
}

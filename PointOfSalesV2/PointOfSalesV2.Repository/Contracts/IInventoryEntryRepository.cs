using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IInventoryEntryRepository: IBase<InventoryEntry>
    {
        Result<object> RemoveEntries(string sequence);
        Result<object> AddInventoryList(List<InventoryEntry> entries, string reference, string details);
    }
}

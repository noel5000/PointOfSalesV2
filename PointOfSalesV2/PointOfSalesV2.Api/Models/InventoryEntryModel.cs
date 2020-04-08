using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSalesV2.Api.Models
{
    public class InventoryEntryModel
    {
        public string Reference { get; set; }
        public string Details { get; set; }

        public List<InventoryEntry> Entries { get; set; }
    }
}

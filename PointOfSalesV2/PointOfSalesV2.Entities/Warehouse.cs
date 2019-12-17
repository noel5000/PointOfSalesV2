﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class Warehouse : CommonData
    {
        public long BranchOfficeId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public List<Inventory> Inventory { get; set; }
        [ForeignKey("BranchOfficeId")]
        public BranchOffice BranchOffice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class Seller : CommonData
    {
        [MaxLength(100)]
        [Export(Order = 0)]
        public string Name { get; set; }
        [MaxLength(20)]
        [Export(Order = 1)]
        public string CardId { get; set; }
        [MaxLength(20)]
        [Export(Order = 2)]
        public string PhoneNumber { get; set; }
        [MaxLength(500)]
        [Export(Order = 3)]
        public string Address { get; set; }
        [MaxLength(50)]
        [Export(Order = 4)]
        public string Code { get; set; }
        public long? ZoneId { get; set; }
        [Export(Order = 5)]
        public decimal ComissionRate { get; set; }
        [Export(Order = 6)]
        public bool ComissionByProduct { get; set; }
        [Export(Order = 7)]
        public bool FixedComission { get; set; }

        [NotMapped]
        public string NameAndCode { get { return $"{Code ?? ""}  {Name}"; } }



        [ForeignKey("ZoneId")]
        [Export(Order = 8, ChildProperty ="Name")]
        public Zone Zone { get; set; }
    }
}

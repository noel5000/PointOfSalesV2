using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PointOfSalesV2.Common;
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
    public class Menu : CommonData
    {

        public Menu() { }

        public byte WeekNumber { get; set; }

        [MaxLength(50)]
        public string Sequence { get; set; }
        
        
        public DayOfWeek DayOfWeek { get; set; }
      

        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }





        public virtual List<MenuDetail> MenuDetails { get; set; }



        //[NotMapped]
        //public DayOfWeek DayOfWeekEnum
        //{
        //    get
        //    {
        //        return (DayOfWeek)this.Day;
        //    }
        //}


    }

}


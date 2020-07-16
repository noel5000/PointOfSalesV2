using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSalesV2.Api.Models
{
    public class WeekMenuModel
    {
        public int WeekNumber { get; set; }
        public List<DayMenuModel> Days { get; set; }

    }

    public class DayMenuModel 
    {
    public DayOfWeek DayOfWeek { get; set; }
    public List<MenuDetail> MenuDetails { get; set; }
    }
}

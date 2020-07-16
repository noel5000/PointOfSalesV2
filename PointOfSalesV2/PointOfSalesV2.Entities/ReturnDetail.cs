using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class ReturnDetail : LeadDetail
    {
        public ReturnDetail() { }

        public ReturnDetail(ReturnDetail newDetail)
        {
            this.Id = newDetail.Id;
           
        }



       


        

    }

}


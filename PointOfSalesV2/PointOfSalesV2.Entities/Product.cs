using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSalesV2.Entities
{
    public class Product : CommonData
    {


        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Price2 { get; set; }
        public decimal Price3 { get; set; }

        public string Code { get; set; }
        public string DetailsClass { get; set; }

        public bool IsService { get; set; }
        public bool IsCompositeProduct { get; set; }

        public decimal Cost { get; set; }
        public decimal SellerRate { get; set; } = 0;

        public long CurrencyId { get; set; }
        public decimal Existence { get; set; }
      
        public string Name { get; set; }

      

        public string Details { get; set; }





        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

      

     
        public List<ProductTax> Taxes { get; set; }





      
        public List<UnitProductEquivalence> ProductUnits { get; set; }

   
        public List<CompositeProduct> BaseCompositeProducts { get; set; }



    }
}
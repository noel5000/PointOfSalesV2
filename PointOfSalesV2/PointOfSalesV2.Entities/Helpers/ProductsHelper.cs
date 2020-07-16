using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Entities
{
    public class ProductsHelper
    {
        public static Result<object> ConvertToProductPrincipalUnit(decimal quantity, long unitId, List<UnitProductEquivalence> units)
        {
            var actualUnit = units.Where(u => u.UnitId == unitId).FirstOrDefault();
            if (actualUnit == null) 
                return new Result<object>(-1, -1, "unitDoesntExist_msg");
            
            var parentUnit = units.Where(u => u.IsPrimary).FirstOrDefault();
            if (parentUnit == null)
                return new Result<object>(-1, -1, "parentUnitDoesntExist_msg"); 

            decimal equivalence = (quantity * parentUnit.Equivalence) / actualUnit.Equivalence;

            return new Result<object>(0,0,"ok_msg",new List<object>() { equivalence});
        }

        public static Result<object> ConvertFromProductPrincipalUnit(decimal quantity, long unitId, List<UnitProductEquivalence> units)
        {
            var actualUnit = units.Where(u => u.UnitId == unitId).FirstOrDefault();
            if (actualUnit == null)
                return new Result<object>(-1, -1, "unitDoesntExist_msg");

            decimal equivalence = (quantity * actualUnit.Equivalence);

            return new Result<object>(0, 0, "ok_msg", new List<object>() { equivalence });
        }
    }
}

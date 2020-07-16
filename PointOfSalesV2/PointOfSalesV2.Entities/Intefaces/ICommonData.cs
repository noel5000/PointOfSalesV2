using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesV2.Entities
{
    public interface ICommonData:IDeletedEntity,IAuditableEntity, IEntityTranslate
    {

       
        long Id { get; set; }

    }

    public interface IDeletedEntity
    {
        bool Active { get; set; }

    }

    public interface IAuditableEntity 
    {

        Guid CreatedBy { get; set; }
        Guid? ModifiedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string CreatedByName { get; set; }
        string ModifiedByName { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}

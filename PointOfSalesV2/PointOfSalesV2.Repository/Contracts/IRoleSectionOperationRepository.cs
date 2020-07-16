using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IRoleSectionOperationRepository : IBase<RoleSectionOperation>
    {
        IQueryable<RoleSectionOperation> GetWithAllChildren();
    }
}

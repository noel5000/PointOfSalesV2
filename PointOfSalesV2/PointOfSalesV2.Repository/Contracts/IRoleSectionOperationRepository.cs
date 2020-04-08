using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IRoleSectionOperationRepository : IBase<RoleSectionOperation>
    {
        IEnumerable<RoleSectionOperation> GetWithAllChildren();
    }
}

using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface ISequenceManagerRepository : IBase<SequenceControl>
    {
        string CreateSequence(Enums.SequenceTypes sequenceCode);
    }
}

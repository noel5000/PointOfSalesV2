using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository
{
    public class SequenceManagerRepository : Repository<SequenceControl>, ISequenceManagerRepository
    {
        public SequenceManagerRepository(MainDataContext context) : base(context)
        {
        }

        public string CreateSequence(Enums.SequenceTypes sequenceCode)
        {
            string result = "";
            var sequence = _Context.SequencesControl.AsNoTracking().FirstOrDefault(x => x.Active == true && x.Code == (short)sequenceCode);
            
            if (sequence != null) 
            {
                result = String.Format("{0}{1:00000}", ((SequenceTypeCode)(short)sequence.Code).ToString() , (sequence.NumericControl + 1));
                sequence.NumericControl += 1;
                _Context.SequencesControl.Update(sequence);
                _Context.SaveChanges();
            }
            return result;
        }

    }
}

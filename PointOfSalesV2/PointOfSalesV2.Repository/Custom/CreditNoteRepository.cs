using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class CreditNoteRepository : Repository<CreditNote>, ICreditNoteRepository
    {
        public CreditNoteRepository(MainDataContext context) : base(context)
        {
        }

        public CreditNote GetBySequence(string sequence)
        {
            return _Context.CreditNotes.AsNoTracking().FirstOrDefault(x => x.Active == true && x.Sequence == sequence);
        }
    }
}

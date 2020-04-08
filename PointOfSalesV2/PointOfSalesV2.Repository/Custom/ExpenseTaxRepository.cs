using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PointOfSalesV2.Repository
{
    public class ExpenseTaxRepository : Repository<ExpenseTax>, IExpenseTaxRepository
    {
        public ExpenseTaxRepository(MainDataContext context) : base(context)
        {
        }

        public IEnumerable<ExpenseTax> GetExpenseTaxes(string reference)
        {
            return _Context.ExpenseTaxes.AsNoTracking().Where(x => x.Active == true && x.Reference.ToLower() == reference.ToLower());
        }

        public IEnumerable<ExpenseTax> GetExpenseTaxes(long id)
        {
            return _Context.ExpenseTaxes.AsNoTracking().Where(x => x.Active == true && x.ExpenseId==id);
        }
    }
}

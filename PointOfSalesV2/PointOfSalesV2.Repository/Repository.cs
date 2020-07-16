using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using PointOfSalesV2.Entities;

namespace PointOfSalesV2.Repository
{
    public class Repository<T> : Base<T, MainDataContext> where T : class, ICommonData, new()
    {
        public Repository(MainDataContext context) : base(context) { }
    }
}

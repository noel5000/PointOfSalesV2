using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using PointOfSalesV2.Entities;
using Microsoft.EntityFrameworkCore.Storage;

namespace PointOfSalesV2.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly MainDataContext _DataContext;

        public UnitOfWork(MainDataContext dataContext)
        {
            _DataContext = dataContext;
        }

        public IDbContextTransaction CreateTransaction()
        {
            return this._DataContext.Database.BeginTransaction();
        }

        public int SaveChanges()
        {
            return _DataContext.SaveChanges();
        }

        public void Dispose()
        {
            if (_DataContext != null)
            {
                _DataContext.Dispose();
            }
        }

        IDbContextTransaction IUnitOfWork.CreateTransaction()
        {
            throw new NotImplementedException();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        protected readonly IOptions<AppSettings> _appSettings;
        public CustomerRepository(MainDataContext context, IOptions<AppSettings> appSettings) : base(context)
        {
            this._appSettings = appSettings;
        }

      
      

        public override Result<Customer> Add(Customer entity)
        {
            if (_Context.Customers.AsNoTracking().Count(x => x.Active == true && x.CardId.ToUpper() == entity.CardId.ToUpper()) > 0) 
            {
                return new Result<Customer>(-1, -1, "cardIdAlreadyExist_error");
            }
            return base.Add(entity);
        }

        public override Result<Customer> Update(Customer entity, bool fromDb = true)
        {
            if (_Context.Customers.AsNoTracking().Count(x => x.Active == true && x.Id!=entity.Id &&
            x.CardId.ToUpper() == entity.CardId.ToUpper()) > 0)
            {
                return new Result<Customer>(-1, -1, "cardIdAlreadyExist_error");
            }
            return base.Update(entity);
        }
    }
}

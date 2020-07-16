using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class SchoolRepository : Repository<School>, ISchoolRepository
    {
        readonly ISequenceManagerRepository _sequenceRepo;
        public SchoolRepository(MainDataContext context, ISequenceManagerRepository sequenceRepo) : base(context)
        {
            this._sequenceRepo = sequenceRepo;
        }

        public override Result<School> Add(School entity)
        {
            Result<School> result = new Result<School>(-1, -1, "error_msg");
            

            using (var trans = _Context.Database.BeginTransaction()) 
            {
                try
                {
                    var customer = _Context.Customers.Find(entity.CustomerId);
                    _Context.Entry<Customer>(customer).State = EntityState.Detached;
                    entity.Code = _sequenceRepo.CreateSequence(Common.Enums.SequenceTypes.Schools);
                    entity.Currency = null;
                    entity.CurrencyId = customer.CurrencyId;
                    entity.Customer = null;
                    entity.Warehouse = null;
                    entity.Zone = null;
                    entity.Contacts = entity.Contacts ?? new List<SchoolContact>();
                    entity.Contacts.ToList().ForEach(c => {
                        c.School = null;
                        c.Active = true;
                    });
                    _Context.Schools.Add(entity);
                    _Context.SaveChanges();
                    result = new Result<School>(entity.Id, 0, "ok_msg");
                    trans.Commit();
                }
                catch (Exception ex) 
                {
                    result = new Result<School>(-1, -1, "error_msg", null, new Exception(ex.Message));
                    trans.Rollback();
                }
            }

            return result;
        }
        public override Result<School> Get(long id)
        {
            var entity = _Context.Schools.Find(id);
            _Context.Entry<School>(entity).State = EntityState.Detached;
            entity.Contacts = _Context.SchoolContacts.AsNoTracking().Where(x => x.Active == true && x.SchoolId == id);
            return entity == null ? new Result<School>(-1, -1, "notFound_msg") : new Result<School>(entity.Id, 0, "ok_msg", new List<School>() { entity });
        }

        public override Result<School> Update(School entity, bool fromDb = true)
        {
            Result<School> result = new Result<School>(-1, -1, "error_msg");


            using (var trans = _Context.Database.BeginTransaction())
            {
                try
                {
                    var customer = _Context.Customers.Find(entity.CustomerId);
                    _Context.Entry<Customer>(customer).State = EntityState.Detached;
                    var previousContacts = _Context.SchoolContacts.AsNoTracking().Where(x => x.Active == true && x.SchoolId == entity.Id).ToList();
                    _Context.SchoolContacts.RemoveRange(previousContacts);
                    _Context.SaveChanges();
                    entity.Code =string.IsNullOrEmpty(entity.Code)? _sequenceRepo.CreateSequence(Common.Enums.SequenceTypes.Schools):entity.Code;
                    entity.Currency = null;
                    entity.CurrencyId = customer.CurrencyId;
                    entity.Customer = null;
                    entity.Warehouse = null;
                    entity.Zone = null;
                    entity.Contacts = entity.Contacts ?? new List<SchoolContact>();
                    entity.Contacts.ToList().ForEach(c => {
                        c.School = null;
                        c.Active = true;
                        c.Id = 0;
                    });
                    _Context.Schools.Update(entity);
                    _Context.SaveChanges();
                    result = new Result<School>(entity.Id, 0, "ok_msg");
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    result = new Result<School>(-1, -1, "error_msg", null, new Exception(ex.Message));
                    trans.Rollback();
                }
            }

            return result;
        }

    }
}

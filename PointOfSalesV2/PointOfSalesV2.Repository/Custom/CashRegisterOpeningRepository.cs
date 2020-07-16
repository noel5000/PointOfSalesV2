using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository
{
    public class CashRegisterOpeningRepository : Repository<CashRegisterOpening>, ICashRegisterOpeningRepository
    {
        public CashRegisterOpeningRepository(MainDataContext context) : base(context)
        {
        }

       

        public override Result<CashRegisterOpening> Add(CashRegisterOpening entity)
        {
            Result<CashRegisterOpening> result = new Result<CashRegisterOpening>(-1,-1,"");
           
                using (var trans = _Context.Database.BeginTransaction()) 
                {

                try
                {
                    entity.Details = entity.Details?.Where(x => x.IsClosing == false);
                    entity.IsClosing = false;
                    entity.OpeningDate = DateTime.Now;
                    entity.State = (char)CashRegisterOpeningStates.Open;
                    entity.Currency = null;
                    entity.BranchOffice = null;
                    var user = entity.User ?? _Context.Users.Find(entity.UserId);
                    _Context.Entry<User>(user).State = EntityState.Detached;
                    entity.User = null;
                    entity.TotalOpeningAmount = entity.Details.Sum(x => x.TotalAmount);
                    entity.MaxClosureDate = user.CashRegisterOpenningTimeHours > 0 ? DateTime.Now.AddHours(user.CashRegisterOpenningTimeHours) : DateTime.Now.AddHours(8);
                    entity.UserName = user.UserName;
                    entity.TotalClosureAmount = 0;
                    entity.OpeningClosureDifference = entity.TotalClosureAmount - entity.TotalOpeningAmount;
                    var details = entity.Details?.ToList();
                    entity.Details = null;
                    entity.CashRegister = null;
                    entity.ClosureDate = null;
                    entity.TotalPaymentsAmount = 0;
                    _Context.CashRegisterOpenings.Add(entity);
                    _Context.SaveChanges();
                    details.ForEach(d => {
                        d.Id = 0;
                        d.IsClosing = false;
                        d.CashRegisterOpeningId = entity.Id;
                    });
                    _Context.CashRegisterOpeningDetails.AddRange(details);
                    _Context.SaveChanges();
                    trans.Commit();
                    result = new Result<CashRegisterOpening>(entity.Id, 0, "ok_msg", new List<CashRegisterOpening>() { entity });
                }
                catch (Exception ex) 
                {
                    trans.Rollback();
                    result = new Result<CashRegisterOpening>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
                }
            
            return result;
        }

        public Result<CashRegisterOpening> Closure(CashRegisterOpening entity)
        {
            Result<CashRegisterOpening> result = new Result<CashRegisterOpening>(-1, -1, "");

            using (var trans = _Context.Database.BeginTransaction())
            {

                try
                {
                    var isClosed = _Context.CashRegisterOpenings.Any(x => x.Id == entity.Id && x.State == (char)CashRegisterOpeningStates.Close);
                    if (isClosed) {
                        trans.Rollback();
                        return new Result<CashRegisterOpening>(-1, -1, "areadyClosed_error");
                    }
                    entity.State = (char)CashRegisterOpeningStates.Close;
                    entity.Currency = null;
                    entity.ClosureDate = DateTime.Now;
                    entity.BranchOffice = null;
                    var user = entity.User ?? _Context.Users.Find(entity.UserId);
                    _Context.Entry<User>(user).State = EntityState.Detached;
                    entity.User = null;
                    entity.TotalOpeningAmount = entity.Details.Where(x=>x.IsClosing==false).Sum(x => x.TotalAmount);
                    entity.UserName = user.UserName;
                    entity.TotalClosureAmount = entity.Details.Where(x => x.IsClosing == true).Sum(x => x.TotalAmount);
                    if (entity.TotalClosureAmount <= 0)
                    {
                        trans.Rollback();
                        return new Result<CashRegisterOpening>(-1, -1, "CantCloseWithZero_error");
                    }
                    entity.OpeningClosureDifference = entity.TotalClosureAmount - entity.TotalOpeningAmount;
                    var details = entity.Details?.Where(x=>x.IsClosing==true).ToList();
                    entity.Details = null;
                    entity.CashRegister = null;
                    _Context.CashRegisterOpenings.Update(entity);
                    _Context.SaveChanges();
                    details.ForEach(d => {
                        d.Id = 0;
                        d.IsClosing = true;
                        d.CashRegisterOpeningId = entity.Id;
                    });
                    _Context.CashRegisterOpeningDetails.AddRange(details);
                    _Context.SaveChanges();
                    trans.Commit();
                    result = new Result<CashRegisterOpening>(entity.Id, 0, "ok_msg", new List<CashRegisterOpening>() { entity });
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = new Result<CashRegisterOpening>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public override Result<CashRegisterOpening> Update(CashRegisterOpening entity, bool fromDb = true)
        {
            Result<CashRegisterOpening> result = new Result<CashRegisterOpening>(-1, -1, "");

            using (var trans = _Context.Database.BeginTransaction())
            {

                try
                {
                    var isClosed = _Context.CashRegisterOpenings.Any(x => x.Id == entity.Id && x.State == (char)CashRegisterOpeningStates.Close);
                    if (isClosed)
                    {
                        trans.Rollback();
                        return new Result<CashRegisterOpening>(-1, -1, "areadyClosed_error");
                    }
                    entity.Details = entity.Details?.Where(x => x.IsClosing == false);
                    entity.IsClosing = false;
                    entity.State = (char)CashRegisterOpeningStates.Open;
                    entity.Currency = null;
                    entity.BranchOffice = null;
                    var user = entity.User ?? _Context.Users.Find(entity.UserId);
                    _Context.Entry<User>(user).State = EntityState.Detached;
                    entity.User = null;
                    entity.TotalOpeningAmount = entity.Details.Sum(x => x.TotalAmount);
                    entity.UserName = user.UserName;
                    entity.TotalClosureAmount = 0;
                    entity.OpeningClosureDifference = entity.TotalClosureAmount - entity.TotalOpeningAmount;
                    var details = entity.Details?.ToList();
                    entity.Details = null;
                    entity.CashRegister = null;
                    entity.ClosureDate = null;
                    _Context.CashRegisterOpenings.Update(entity);
                    _Context.SaveChanges();

                    var oldDetails = _Context.CashRegisterOpeningDetails.AsNoTracking().Where(x => x.CashRegisterOpeningId == entity.Id).ToList();
                    oldDetails.ForEach(d => {
                        if (!details.Any(x => x.Id == d.Id)) 
                        {
                            _Context.Entry<CashRegisterOpeningDetail>(d).State = EntityState.Deleted;
                            _Context.SaveChanges();
                        }
                    });
                    details.ForEach(d => {
                        d.IsClosing = false;
                        d.CashRegisterOpeningId = entity.Id;
                        if (d.Id == 0)
                        {
                            _Context.CashRegisterOpeningDetails.Add(d);
                        }
                        else
                            _Context.CashRegisterOpeningDetails.Update(d);
                        _Context.SaveChanges();
                    });
                  
                    _Context.SaveChanges();
                    trans.Commit();
                    result = new Result<CashRegisterOpening>(entity.Id, 0, "ok_msg", new List<CashRegisterOpening>() { entity });
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = new Result<CashRegisterOpening>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }


    }
}

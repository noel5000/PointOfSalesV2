using Microsoft.EntityFrameworkCore;
using NPOI.HSSF.Record;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        readonly ISequenceManagerRepository _sequenceRepo;
        readonly IDataRepositoryFactory _repoFactory;
        public MenuRepository(MainDataContext context, ISequenceManagerRepository sequenceManagerRepository, IDataRepositoryFactory dataRepositoryFactory) : base(context)
        {
            this._repoFactory = dataRepositoryFactory;
            this._sequenceRepo = sequenceManagerRepository;
        }
        public override Result<Menu> Add(Menu entity)
        {
            var result = new Result<Menu>(-1, -1, "error_msg");
            using (var trans = _Context.Database.BeginTransaction())
            {
                try
                {
                    if ((int)entity.DayOfWeek > 6 || entity.WeekNumber > 4 || (entity.MenuDetails == null || entity.MenuDetails.Count == 0))
                    {
                        trans.Rollback();
                        result = new Result<Menu>(-1, -1, "invalidMenu_msg");
                        return result;
                    }
                    var existingMenu = _Context.Menus.Include(x => x.MenuDetails).AsNoTracking().FirstOrDefault(x => x.Active == true && x.DayOfWeek == entity.DayOfWeek && x.WeekNumber == entity.WeekNumber);
                    if (existingMenu != null)
                    {
                        _Context.MenuDetails.RemoveRange(existingMenu.MenuDetails);
                        _Context.SaveChanges();
                        entity.MenuDetails.ForEach(d =>
                        {
                            d.MenuId = existingMenu.Id;
                            d.Product = null;
                            d.Unit = null;
                            d.Menu = null;
                            d.Id = 0;

                        });
                        _Context.MenuDetails.AddRange(entity.MenuDetails);
                        _Context.SaveChanges();
                    }
                    else
                    {
                        entity.Sequence = _sequenceRepo.CreateSequence(Common.Enums.SequenceTypes.Menus);
                        entity.MenuDetails.ForEach(d =>
                        {
                            d.Product = null;
                            d.Unit = null;
                            d.Menu = null;
                        });

                        _Context.Menus.Add(entity);
                        _Context.SaveChanges();
                    }
                    result = new Result<Menu>(entity.Id, 0, "ok_msg");
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    result = new Result<Menu>(-1, -1, "error_msg", null, new Exception(ex.Message));
                    trans.Rollback();
                }
            }

            return result;
        }

        public override Result<Menu> Update(Menu entity, bool fromDb = true)
        {
            var result = new Result<Menu>(-1, -1, "error_msg");
            using (var trans = _Context.Database.BeginTransaction())
            {
                try
                {
                    if ((int)entity.DayOfWeek > 6 || entity.WeekNumber > 4 || (entity.MenuDetails == null || entity.MenuDetails.Count == 0))
                    {
                        trans.Rollback();
                        result = new Result<Menu>(-1, -1, "invalidMenu_msg");
                        return result;
                    }
                    var existingMenu = _Context.Menus.AsNoTracking().FirstOrDefault(x => x.Active == true && x.Id == entity.Id);
                    if (existingMenu != null)
                    {
                        var existinDetails = _Context.MenuDetails.AsNoTracking().Where(x => x.Active == true && x.MenuId == existingMenu.Id).ToList();
                        existingMenu.DayOfWeek = entity.DayOfWeek;
                        existingMenu.WeekNumber = existingMenu.WeekNumber;
                        entity.MenuDetails.ForEach(d =>
                        {
                            d.MenuId = existingMenu.Id;
                            d.Product = null;
                            d.Unit = null;
                            d.Menu = null;
                        });
                        _Context.Menus.Update(existingMenu);
                        _Context.SaveChanges();
                        existinDetails.ForEach(ed =>
                        {
                            int index = entity.MenuDetails.FindIndex(x => x.Id == ed.Id);
                            if (index > 0)
                            {
                                ed = entity.MenuDetails[index];
                                _Context.MenuDetails.Update(ed);
                                _Context.SaveChanges();
                            }
                            else
                            {
                                _Context.MenuDetails.Remove(ed);
                                _Context.SaveChanges();
                            }
                        });
                        _Context.MenuDetails.AddRange(entity.MenuDetails.Where(x => x.Id == 0));
                        _Context.SaveChanges();
                    }
                    else
                    {
                        trans.Rollback();
                        result = new Result<Menu>(-1, -1, "invalidMenu_msg");
                        return result;
                    }
                    result = new Result<Menu>(entity.Id, 0, "ok_msg");
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    result = new Result<Menu>(-1, -1, "error_msg", null, new Exception(ex.Message));
                    trans.Rollback();
                }
            }

            return result;
        }

        public Result<object> DeleteMenuEntry(byte weekNo, DayOfWeek dayOfWeek)
        {
            var result = new Result<object>(-1, -1, "error_msg");
            using (var trans = _Context.Database.BeginTransaction())
            {
                try
                {
                    var entity = _Context.Menus.AsNoTracking().FirstOrDefault(m => m.Active == true
                        && m.WeekNumber == weekNo && m.DayOfWeek == dayOfWeek);
                    if (entity == null)
                    {
                        trans.Rollback();
                        return new Result<object>(-1, -1, "menuNotExisting_msg");
                    }
                    if ((int)entity.DayOfWeek > 6 || entity.WeekNumber > 4)
                    {
                        trans.Rollback();
                        result = new Result<object>(-1, -1, "invalidMenu_msg");
                        return result;
                    }
                    var existingMenu = _Context.MenuDetails.AsNoTracking().Where(x => x.Active == true && x.MenuId == entity.Id);
                    if (existingMenu != null)
                    {
                        _Context.MenuDetails.RemoveRange(existingMenu);
                        _Context.SaveChanges();


                    }
                    entity.Active = false;
                    _Context.Menus.Update(entity);
                    _Context.SaveChanges();
                    result = new Result<object>(entity.Id, 0, "ok_msg");
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    result = new Result<object>(-1, -1, "error_msg", null, new Exception(ex.Message));
                    trans.Rollback();
                }
            }

            return result;
        }

        public List<InvoiceLeadProjection> MonthProjection(DateTime currentDate, long branchOfficeId = 0, long warehouseId = 0)
        {

            var startDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            var endDate = startDate.AddMonths(1);
            List<InvoiceLeadProjection> result = new List<InvoiceLeadProjection>();

            var monthLeads = _Context.InvoicesLeads.AsNoTracking().Where(x => x.Active == true &&
            x.Date >= startDate && x.Date <= endDate && x.State != (char)Enums.BillingStates.Nulled).ToList();

            var schools = _Context.Schools.AsNoTracking().Where(x => x.Active == true).ToList();
            var menus = _Context.Menus.AsNoTracking().Where(x => x.Active == true).ToList();

            var projectedSequences = _Context.SequencesControl.AsNoTracking().FirstOrDefault(x => x.Active == true
            && x.Code == (byte)Enums.SequenceTypes.Leads);

            while (startDate <= endDate)
            {
                List<Inventory> tempInventoryToUpdate = new List<Inventory>();
                var weekOfMonth = DateUtility.GetWeekOfMonth(startDate);
                DayOfWeek dayOfWeek = startDate.DayOfWeek;
                if ((int)dayOfWeek > 0 && (int)dayOfWeek < 6)
                {
                    var selectedMenu = menus.FirstOrDefault(x => x.DayOfWeek == dayOfWeek && x.WeekNumber == (weekOfMonth - 1));
                    if (selectedMenu != null)
                    {
                        var existence = branchOfficeId <= 0 ? new List<Inventory>() : _Context.Inventory.AsNoTracking().Where(x => x.Active == true && x.BranchOfficeId == branchOfficeId && (warehouseId <= 0 ? x.WarehouseId > 0 : x.WarehouseId == warehouseId)).ToList();
                        tempInventoryToUpdate.ForEach(t =>
                        {
                            int index = existence.FindIndex(x => x.Id == t.Id);
                            if (index >= 0)
                                existence[index] = t;
                        });
                        foreach (var school in schools)
                        {
                            bool notExpiredLead = startDate >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                            var enoughtExistence = notExpiredLead ? InventoryHelper.VerifyExistence(_Context.MenuDetails.AsNoTracking()
                                .Include(d => d.Product)
                                .Where(x => x.Active == true && x.MenuId == selectedMenu.Id)
                                .ToList<IDetailEntity>(), _repoFactory, existence) : true;
                            var schoolLead = monthLeads.FirstOrDefault(x => x.Date.Day == startDate.Day && x.SchoolId == school.Id);
                            string sequence = String.Format("{0}{1:00000}",
                                ((Enums.SequenceTypeCode)(short)projectedSequences.Code).ToString(),
                                (projectedSequences.NumericControl + 1));

                            projectedSequences.NumericControl += 1;
                            result.Add(new InvoiceLeadProjection()
                            {
                                Id = schoolLead == null ? 0 : schoolLead.Id,
                                DayOfWeek = dayOfWeek,
                                WeekOfMonth = (byte)weekOfMonth,
                                MenuId = selectedMenu.Id,
                                SchoolId = school.Id,
                                SchoolName = $"{school.Code} {school.Name}",
                                LeadSequence =string.IsNullOrEmpty(string.IsNullOrEmpty(schoolLead?.InvoiceNumber)?schoolLead?.DocumentNumber:schoolLead?.InvoiceNumber)? sequence:
                                (string.IsNullOrEmpty(schoolLead?.InvoiceNumber) ? schoolLead?.DocumentNumber : schoolLead?.InvoiceNumber),
                                Date = startDate,
                                EnoughExistence=enoughtExistence,
                                State = schoolLead == null ? (notExpiredLead ?
                            (enoughtExistence ? (char)Enums.BillingStates.Projected : (char)Enums.BillingStates.NotEnoughInventory)
                            : (char)Enums.BillingStates.Expired) : schoolLead.State
                            });
                            existence.ForEach(e =>
                            {
                                int index = tempInventoryToUpdate.FindIndex(x => x.Id == e.Id);
                                if (index >= 0)
                                    tempInventoryToUpdate[index] = e;
                                else
                                    tempInventoryToUpdate.Add(e);
                            });
                        }
                    }

                }
                startDate = startDate.AddDays(1);
            }
            return result;
        }

        public override Result<Menu> Get(long id)
        {
            var entity = _Context.Menus.Find(id);
            _Context.Entry<Menu>(entity).State = EntityState.Detached;
            entity.MenuDetails = _Context.MenuDetails.AsNoTracking()
                .Include(x => x.Product).ThenInclude(x=>x.Taxes).ThenInclude(x=>x.Tax)
                .Include(x=>x.Product).ThenInclude(x => x.ProductUnits).ThenInclude(x=>x.Unit)
                .Include(x => x.Unit).Where(x => x.Active == true && x.MenuId == id).ToList();

            return new Result<Menu>(id, 0, "ok_msg", new List<Menu>() { entity });
        }

    }
}

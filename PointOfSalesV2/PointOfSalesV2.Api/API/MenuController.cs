using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Api.Models;
using PointOfSalesV2.Api.Security;
using PointOfSalesV2.Entities;
using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using static PointOfSalesV2.Common.Enums;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(AppSections.SchoolMenu)]
    public class MenuController : BaseController<Menu>
    {
        readonly IMenuRepository menuRepository;
        public MenuController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory, cache, repositoryFactory.GetCustomDataRepositories<IMenuRepository>())
        {
            menuRepository = this._repositoryFactory.GetCustomDataRepositories<IMenuRepository>();
        }

        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery()]
        [EnableCors("AllowAllOrigins")]
        public override IActionResult Get()
        {
            try
            {
                var data = _baseRepo.GetAll<Menu>(x => x
                , y => y.Active == true);
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpGet("GetMenus")]
        [ActionAuthorize(Operations.READALL)]
        [EnableCors("AllowAllOrigins")]
        public IActionResult GetMenus()
        {
            try
            {
                var rawData = _baseRepo.GetAll<Menu>(x => x.Include(y => y.MenuDetails).ThenInclude(d => d.Product)
               .Include(y => y.MenuDetails).ThenInclude(d => d.Unit)
               , y => y.Active == true).ToList();
                var rawDetails = rawData.SelectMany(x => x.MenuDetails);
                var data = rawData.GroupBy(x => x.WeekNumber).ToList();
                var result = new List<WeekMenuModel>();
                data.ForEach(d =>
                {
                    WeekMenuModel model = new WeekMenuModel()
                    {
                        WeekNumber = d.Key,
                        Days = d.GroupBy(x => x.DayOfWeek).ToList().Select(x => new DayMenuModel()
                        {
                            DayOfWeek = x.Key,
                            MenuDetails=rawDetails.Where(y=>y.Active==true &&y.MenuId==x.FirstOrDefault().Id).ToList()
                        }).ToList()
                    };
                    result.Add(model);
                });

                return Ok(new { Id = 0, Status = 0, data = result });
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpGet("GetMenu/{weekNumber:int}/{dayOfWeek:int}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.READALL)]
        public IActionResult GetMenu(int weekNumber, int dayOfWeek)
        {
            try
            {
                var data = _baseRepo.GetAll<Menu>(x => x.Include(y => y.MenuDetails).ThenInclude(d => d.Product)
                .Include(y => y.MenuDetails).ThenInclude(d => d.Unit)
                , y => y.Active == true && y.WeekNumber == weekNumber && y.DayOfWeek == (DayOfWeek)dayOfWeek).ToList().GroupBy(x => x.WeekNumber).ToList();
                var result = new List<WeekMenuModel>();
                data.ForEach(d =>
                {
                    WeekMenuModel model = new WeekMenuModel()
                    {
                        WeekNumber = d.Key,
                        Days = d.GroupBy(x => x.DayOfWeek).ToList().Select(x => new DayMenuModel()
                        {
                            DayOfWeek = x.Key,
                            MenuDetails = d.Select(j => j.MenuDetails).SelectMany(r => r).ToList()
                        }).ToList()
                    };
                    result.Add(model);
                });

                return Ok(new { Id = 0, Status = 0, data = result });
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpDelete("DeleteMenu/{weekNumber:int}/{dayOfWeek:int}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.DELETE)]
        public IActionResult DeleteMenu(int weekNumber, int dayOfWeek)
        {
            try
            {
                var result = menuRepository.DeleteMenuEntry((byte)weekNumber, (DayOfWeek)dayOfWeek);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }


        [HttpGet("GetProjectedLeads/{branchOfficeId:long}/{warehouseId:long}/{selectedDate:datetime}")]
        [ActionAuthorize(Operations.READALL)]
        [EnableCors("AllowAllOrigins")]
        public IActionResult GetProjectedLeads(long branchOfficeId, long warehouseId, DateTime selectedDate)
        {
            try
            {
                var data = this.menuRepository.MonthProjection(selectedDate,branchOfficeId,warehouseId);

                return Ok(new { Id = 0, Status = 0, data });
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}
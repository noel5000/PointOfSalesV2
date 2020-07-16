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
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using static PointOfSalesV2.Common.Enums;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.InventoryIncomes)]
    public class InventoryEntryController : BaseController<InventoryEntry>
    {
        readonly IInventoryEntryRepository repo;
        public InventoryEntryController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache, IInventoryEntryRepository repo) : base(appSettings, repositoryFactory,cache, repo)
        {
            this.repo = repositoryFactory.GetCustomDataRepositories<IInventoryEntryRepository>();
        }

        [HttpGet]
        [ActionAuthorize( Operations.READALL)]
        [EnableQuery()]
        [EnableCors("AllowAllOrigins")]
        public override IActionResult Get()
        {
            try
            {
                var data = _baseRepo.GetAll<InventoryEntry>(x => x
                .Include(x => x.Warehouse)
                .Include(x=>x.BranchOffice)
                .Include(x => x.Unit)
                .Include(x => x.Product)
                .Include(x=>x.Currency)
                .Include(x => x.Supplier)
                .Where(y => y.Active == true));
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpPost("AddEntries")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ADD)]
        public IActionResult AddEntries([FromBody]InventoryEntryModel model)
        {
            try
            {
                var result = repo.AddInventoryList(model.Entries, model.Reference, model.Details);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpDelete("DeleteEntries/{sequence}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.DELETE)]
        public IActionResult DeleteEntries(string sequence)
        {
            try
            {
                var result = repo.RemoveEntries(sequence);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });

            }

        }
    }
}
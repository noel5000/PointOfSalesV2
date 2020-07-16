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
    [EnableCors("AllowAllOrigins")]
    [ControllerAuthorize(Common.Enums.AppSections.WarehouseTransfers)]
    public class WarehouseTransferController : BaseController<WarehouseTransfer>
    {
        readonly IWarehouseTransferRepository repo;
        public WarehouseTransferController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache, IWarehouseTransferRepository repo) : base(appSettings, repositoryFactory,cache, repo)
        {
            this.repo = repositoryFactory.GetCustomDataRepositories<IWarehouseTransferRepository>();
        }

        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery()]
        [EnableCors("AllowAllOrigins")]
        public virtual IActionResult Get()
        {
            try
            {
                var data = _baseRepo.GetAll<WarehouseTransfer>(x => x
                .Include(x => x.OriginBranchOffice)
                .Include(x => x.DestinyBranchOffice)
                .Include(x => x.Unit)
                .Include(x => x.Product)
                .Include(x => x.Destiny)
                .Include(x => x.Origin)
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
        public IActionResult AddEntries([FromBody]WarehouseTransferModel model)
        {
            try
            {
                var result = repo.AddTransfersList(model.Entries, model.Reference, model.Details);
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
                var result = repo.RemoveTransfers(sequence);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });

            }

        }
    }
}
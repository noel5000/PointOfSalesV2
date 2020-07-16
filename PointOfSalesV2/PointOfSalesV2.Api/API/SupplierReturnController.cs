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
    [ControllerAuthorize(Common.Enums.AppSections.SuppliersReturns)]
    public class SupplierReturnController : BaseController<SupplierReturn>
    {
        ISupplierReturnRepository repo;
        public SupplierReturnController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,repositoryFactory.GetCustomDataRepositories<ISupplierReturnRepository>())
        {
            this.repo = repositoryFactory.GetCustomDataRepositories<ISupplierReturnRepository>();
        }

        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery()]
        [EnableCors("AllowAllOrigins")]
        public override IActionResult Get()
        {
            try
            {
                var data = _baseRepo.GetAll<SupplierReturn>(x => x.Include(t => t.Currency)
                .Include(t => t.BranchOffice)
                .Include(t => t.Warehouse)
                .Include(t => t.Product)
                .Include(t => t.Unit)
                .Include(t => t.Supplier)
                , y => y.Active == true);
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
        public IActionResult AddEntries([FromBody]SupplierReturnModel model)
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
        [ActionAuthorize(Operations.DELETE)]
        [EnableCors("AllowAllOrigins")]
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
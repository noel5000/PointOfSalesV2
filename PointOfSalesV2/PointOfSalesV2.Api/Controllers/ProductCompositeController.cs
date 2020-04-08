using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Api.Security;
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ControllerAuthorize(Common.Enums.AppSections.Products)]
    [ApiController]
    public class ProductCompositeController : BaseController<CompositeProduct>
    {
        public ProductCompositeController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache)
        {
        }

        [HttpPost]
        public override IActionResult Post([FromBody] CompositeProduct model)
        {
            return BadRequest(new { Status = -1, Message = "notValid_msg" });
        }


        [HttpPut]
        public override IActionResult Put([FromBody] CompositeProduct model)
        {
            return BadRequest(new { Status = -1, Message = "notValid_msg" });
        }
    }
}
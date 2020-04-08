﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Api.Security;
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ControllerAuthorize(Common.Enums.AppSections.Products)]
    [ApiController]
    public class ProductTaxController : BaseController<ProductTax>
    {
        public ProductTaxController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache)
        {
        }

        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery()]
        public override IActionResult Get()
        {
            try
            {
                var data = _baseRepo.GetAll<ProductTax>(x => x.Include(t => t.Tax)
                .Include(t => t.Product)
                , y => y.Active == true);
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpPost]
        public override IActionResult Post([FromBody] ProductTax model)
        {
            return BadRequest(new { Status = -1, Message = "notValid_msg" });
        }


        [HttpPut]
        public override IActionResult Put([FromBody] ProductTax model)
        {
            return BadRequest(new { Status = -1, Message = "notValid_msg" });
        }
    }
}
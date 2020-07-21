using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Api.Security;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using static PointOfSalesV2.Common.Enums;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.CashRegisterOpenings)]
    public class CashRegisterOpeningController : BaseController<CashRegisterOpening>
    {
        private readonly ICashRegisterOpeningRepository _repo;
        public CashRegisterOpeningController(ICashRegisterOpeningRepository repo, IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache)
        {
            this._repo = repo;
        }

        [HttpGet]
        [ActionAuthorize(new Operations[] { Operations.READALL, Operations.READ })]
        [EnableQuery()]
        [EnableCors("AllowAllOrigins")]
        public override IActionResult Get()
        {
            try
            {
                var data = _repo.GetAll<CashRegisterOpening>(x => x.Include(x => x.BranchOffice)
                .Include(x => x.User)
                .Include(x => x.CashRegister)
                .Include(x => x.Currency)
                .Where(y => y.Active == true));
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }


        [HttpPost]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ADD)]
        public override IActionResult Post([FromBody] CashRegisterOpening model)
        {
            try
            {
                var activeEntity = model as ICommonData;
                if (activeEntity != null)
                {
                    activeEntity.Active = true;
                    model = activeEntity as CashRegisterOpening;
                }
                var result = _repo.Add(model);

                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpPut]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.UPDATE)]
        public override IActionResult Put([FromBody] CashRegisterOpening model)
        {
            try
            {
                var result = _repo.Update(model);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpPut("CloseCashRegister")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.UPDATE)]
        public virtual IActionResult CloseCashRegister([FromBody] CashRegisterOpening model)
        {
            try
            {
                var result = _repo.Closure(model);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpDelete("{id:long}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.DELETE)]
        public override IActionResult Delete(long id)
        {
            try
            {
                var model = _baseRepo.Get(id).Data.FirstOrDefault();
                if (model != null && model.State ==(char) Enums.CashRegisterOpeningStates.Open)
                {
                    model.State = (char)Enums.CashRegisterOpeningStates.Nulled;
                    var result = _baseRepo.Update(model as CashRegisterOpening);
                    return Ok(result);
                }
                else 
                {
                    if(model==null)
                    return Ok(new { status = -1, message = "error_msg" });
                    else
                    return Ok(new { status = -1, message = "cashRegisterOpeningIsClosed_msg" });
                }

            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });

            }

        }
    }
}
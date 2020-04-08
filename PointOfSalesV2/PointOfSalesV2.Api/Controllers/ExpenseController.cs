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

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize( Common.Enums.AppSections.Expenses)]
    public class ExpenseController : BaseController<Expense>
    {
        readonly IExpenseRepository _repo;
        public ExpenseController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache)
        {
            this._repo = _repositoryFactory.GetCustomDataRepositories<IExpenseRepository>();
        }


        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery()]
        public override IActionResult Get()
        {
            try
            {
                var data = _repo.GetAll<Expense>(x => x
                .Include(x=>x.Supplier)
                .Include(x=>x.Currency)
                .Include(x=>x.BranchOffice)
                .Include(x=>x.PaymentType)
                .Where(y => y.Active == true));
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpGet("{id:long}")]
        //[EnableQuery]
        [ActionAuthorize(Operations.READ)]
        public override IActionResult Get(long id)
        {
            try
            {
                var data = _repo.Get(id);
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpPost("GetOwedExpenses")]
        //[EnableQuery]
        [ActionAuthorize(Operations.READ)]
        public IActionResult GetOwedExpenses([FromBody]DebsToPaySearchModel model)
        {
            try
            {
                var data = _repo.GetDebsToPay(model.StartDate,model.EndDate,model.SupplierId,model.CurrencyId,model.BranchOfficeId);
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpPost]
        [ActionAuthorize(Operations.ADD)]
        public override IActionResult Post([FromBody] Expense model)
        {
            try
            {
                var activeEntity = model as ICommonData;
                if (activeEntity != null)
                {
                    activeEntity.Active = true;
                    model = activeEntity as Expense;
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
        [ActionAuthorize(Operations.UPDATE)]
        public override IActionResult Put([FromBody] Expense model)
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

        [HttpDelete("{id:long}")]
        [ActionAuthorize(Operations.DELETE)]
        public override IActionResult Delete(long id)
        {
            try
            {

                var result = _repo.Remove(id);
                    return Ok(result);
                

            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });

            }

        }

    }
}
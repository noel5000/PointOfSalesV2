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
    [ControllerAuthorize(Common.Enums.AppSections.ExpensesPayments)]
    public class ExpensesPaymentController : BaseController<ExpensesPayment>
    {
        readonly IExpensesPaymentRepository _repo;
        public ExpensesPaymentController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache)
        {
            this._repo = _repositoryFactory.GetCustomDataRepositories<IExpensesPaymentRepository>();
        }


        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery()]
        [EnableCors("AllowAllOrigins")]
        public override IActionResult Get()
        {
            try
            {
                var data = _repo.GetAll<ExpensesPayment>(x => x
                .Include(x => x.Supplier)
                .Include(x => x.Currency)
                .Include(x => x.ExpenseCurrency)
                .Include(x=>x.Expense)
                .Include(x => x.PaymentType)
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
        [EnableCors("AllowAllOrigins")]
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

        [HttpPost]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ADD)]
        public override IActionResult Post([FromBody] ExpensesPayment model)
        {
            try
            {
                var activeEntity = model as ICommonData;
                if (activeEntity != null)
                {
                    activeEntity.Active = true;
                    model = activeEntity as ExpensesPayment;
                }
                var result = _repo.Add(model);

                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpPost("AddPayments")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ADD)]
        public  IActionResult AddPayments([FromBody] ExpensesPaymentModel model)
        {
            try
            {
                if (model.Expenses == null || model.Expenses.Count == 0)
                    throw new Exception("error_msg");
                var result = _repo.AddPayment(model.Payment,model.Expenses);

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
        public override IActionResult Put([FromBody] ExpensesPayment model)
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
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.DELETE)]
        public override IActionResult Delete(long id)
        {
            try
            {
             var result=   _repo.Remove(id);
                return
                    Ok(result);

            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });

            }

        }

    }
}
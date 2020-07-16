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
using Microsoft.OData.Edm;
using PointOfSalesV2.Common;
using Microsoft.AspNetCore.Cors;

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
        [EnableCors("AllowAllOrigins")]
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

        [HttpPost("GetOwedExpenses")]
        [EnableCors("AllowAllOrigins")]
        //[EnableQuery]
        [ActionAuthorize(Operations.DEBTSTOPAYREPORT)]
        public IActionResult GetOwedExpenses([FromBody]DebsToPaySearchModel model)
        {
            try
            {
                var data = _repo.GetDebsToPay(model.StartDate,model.EndDate,model.SupplierId,model.CurrencyId,model.BranchOfficeId);
                return Ok(new { status = 0, data});
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpPost("GetOwedExpensesReport/{branchOfficeId:long}/{supplierId:long}/{currencyId:long}/{startDate}/{endDate}")]
        //[EnableQuery]
        [ActionAuthorize(Operations.DEBTSTOPAYREPORT)]
        [EnableCors("AllowAllOrigins")]
        public IActionResult GetOwedExpensesReport( long branchOfficeId=0,long supplierId=0,long currencyId=0, string startDate="0", string endDate="0" )
        {
            try
            {
                DateTime? start = null;
                start = startDate != "0" ? Convert.ToDateTime(startDate) : start;
                DateTime? end = null;
                end = endDate != "0" ? Convert.ToDateTime(endDate) : DateTime.Now;
                var data = _repo.GetDebsToPay(start,end,supplierId,currencyId, branchOfficeId);
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                var excelData = ExportUtility.GetExcelData<Expense>(data, requestLanguage, this.languageKeys.ToList());
                var excelStream = ExcelImport.CreateXlsStream(
                    excelData.Item1,
                   excelData.Item2
                   );
                if (data != null && excelStream != null && excelStream.Length > 0)
                {

                    return File(excelStream.ToArray(), "application/octet-stream", $"{new Product().GetType().Name}-{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}.xls");
                }
                return BadRequest(new { status = -1, message = "Documento no existe" });
              
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpPost]
        [EnableCors("AllowAllOrigins")]
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
        [EnableCors("AllowAllOrigins")]
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
        [EnableCors("AllowAllOrigins")]
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
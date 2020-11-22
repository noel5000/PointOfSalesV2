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
    [ControllerAuthorize(Common.Enums.AppSections.Customers)]
    public class CustomerController : BaseController<Customer>
    {
        readonly ISequenceManagerRepository sequence;
        public CustomerController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) 
            : base(appSettings, repositoryFactory, cache, repositoryFactory.GetCustomDataRepositories<ICustomerRepository>())
        {
            this.sequence = this._repositoryFactory.GetCustomDataRepositories<ISequenceManagerRepository>();
        }

        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery()]
        [EnableCors("AllowAllOrigins")]
        public override IActionResult Get()
        {
            try
            {
                var data = _baseRepo.GetAll<Customer>(x => x
                .Include(x => x.Currency)
                .Include(x => x.TRNControl)
                .Include(x=>x.Zone)
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
        public override IActionResult Post([FromBody] Customer model)
        {
            try
            {
                var activeEntity = model as ICommonData;
                if (activeEntity != null)
                {
                    activeEntity.Active = true;
                    model = activeEntity as Customer;
                    model.Code = sequence.CreateSequence(SequenceTypes.Customers);
                }
                var result = _baseRepo.Add(model);

                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpPost("ExportToExcel")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.EXPORT)]
        public override IActionResult ExportToExcel()
        {
            try
            {
                var data = _baseRepo.GetAll<Customer>(x => x.Include(t => t.Currency)
                .Include(x => x.TRNControl)
                 , y => y.Active == true);
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                var excelData = ExportUtility.GetExcelData<Customer>(data, requestLanguage, this.languageKeys.ToList());
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

        [HttpPost("AccountStateExport/{customerId:long}")]
        [ActionAuthorize(Operations.ACCOUNTSTATEREPORT)]
        [EnableCors("AllowAllOrigins")]
        public IActionResult AccountStateExport(long customerId)
        {
            try
            {
                var data = _repositoryFactory.GetCustomDataRepositories<ICustomerBalanceRepository>().CustomerState(customerId);
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                var excelData = ExportUtility.GetExcelData<CustomerStateModel>(data.Data, requestLanguage, this.languageKeys.ToList());
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

        [HttpGet("AccountState/{customerId:long}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ACCOUNTSTATEREPORT)]
        public IActionResult AccountState(long customerId)
        {
            try
            {
                var data = _repositoryFactory.GetCustomDataRepositories<ICustomerBalanceRepository>().CustomerState(customerId);
                return Ok(new { status = 0, data });
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}
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
using static PointOfSalesV2.Common.Enums;
using PointOfSalesV2.Api.Models;
using PointOfSalesV2.Common;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Invoices)]
    public class InvoiceTaxController : BaseController<InvoiceTax>
    {
        readonly IBusinessStateRepository businessStateRepository;
        public InvoiceTaxController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache, IBusinessStateRepository businessState) : base(appSettings, repositoryFactory,cache)
        {
            this.businessStateRepository = businessState;
        }

        [HttpGet("GetTaxesReport/{initialDate}/{endDate}")]
        //[EnableQuery]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.TAXREPORT)]
        public IActionResult GetTaxesReport(string initialDate="0",string endDate="0")
        {
            try
            {
                DateTime? startDate = null;
                startDate = initialDate != "0" ? Convert.ToDateTime(initialDate) : startDate;

                DateTime? finalDate = null;
                finalDate = endDate != "0" ? Convert.ToDateTime(endDate) : finalDate;

                var data = businessStateRepository.GetTaxesReport(startDate, finalDate);
                return Ok(new { status = 0, data });
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpPost("GetTaxesReportExcel/{initialDate}/{endDate}")]
        [EnableCors("AllowAllOrigins")]
        //[EnableQuery]
        [ActionAuthorize(Operations.TAXREPORT)]
        public IActionResult GetTaxesReportExcel(string initialDate = "0", string endDate = "0")
        {
            try
            {
                DateTime? startDate = null;
                startDate = initialDate != "0" ? Convert.ToDateTime(initialDate) : startDate;

                DateTime? finalDate = null;
                finalDate = endDate != "0" ? Convert.ToDateTime(endDate) : finalDate;

                var data = businessStateRepository.GetTaxesReport(startDate, finalDate);
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                var excelData = ExportUtility.GetExcelData<InvoiceTax>(data.SelectMany(x=>x.Taxes), requestLanguage, this.languageKeys.ToList());
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
    }
}
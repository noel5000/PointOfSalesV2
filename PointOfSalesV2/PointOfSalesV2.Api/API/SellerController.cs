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
using PointOfSalesV2.Common;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Sellers)]
    public class SellerController : BaseController<Seller>
    {
        public SellerController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache, ISellerRepository sellerRepo) : base(appSettings, repositoryFactory,cache,sellerRepo)
        {
        }

        [HttpPost("GetComissionsReport")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.COMISSIONSREPORT)]
        public virtual Task<IActionResult> GetComissionsReport([FromBody] ComissionsSearch search)
        {
            var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                try
                {
                    var t_inputs = arg as Tuple<ComissionsSearch, ISellerRepository>;
                    var invoices =t_inputs.Item1.ReportType==0?
                    t_inputs.Item2.SalesComissions(t_inputs.Item1): t_inputs.Item2.PaymentsComissions(t_inputs.Item1);
                    return Ok(new { status = 0, id = 0, data = invoices });
                }
                catch (Exception ex)
                {
                    return Ok(new { status = -1, message = ex.Message });
                }

            }, new Tuple<ComissionsSearch, ISellerRepository>(search, _repositoryFactory.GetCustomDataRepositories<ISellerRepository>()));

            return t_result;


        }

        [HttpPost("ExportComissionsReport")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.COMISSIONSREPORT)]
        public Task<IActionResult> ExportComissionsReport([FromBody] ComissionsSearch search)
        {

            var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                try
                {
                    var t_inputs = arg as Tuple<ComissionsSearch, ISellerRepository>;
                    var invoices = t_inputs.Item1.ReportType == 0 ?
                    t_inputs.Item2.SalesComissions(t_inputs.Item1) : t_inputs.Item2.PaymentsComissions(t_inputs.Item1);


                    string requestLanguage = "EN";
                    var languageIdHeader = this.Request.Headers["languageid"];
                    requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                    var excelData = ExportUtility.GetExcelData<ComissionDetail>(invoices.ComissionsByCyrrencies.SelectMany(x=>x.Details), requestLanguage, this.languageKeys.ToList());
                    var excelStream = ExcelImport.CreateXlsStream(
                        excelData.Item1,
                       excelData.Item2
                       );
                    if (invoices != null && excelStream != null && excelStream.Length > 0)
                    {

                        return File(excelStream.ToArray(), "application/octet-stream", $"{new Product().GetType().Name}-{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}.xls");
                    }
                    return BadRequest(new { status = -1, message = "Documento no existe" });



                }
                catch (Exception ex)
                {
                    return Ok(new { status = -1, message = ex.Message });
                }

            }, new Tuple<ComissionsSearch, ISellerRepository>(search, _repositoryFactory.GetCustomDataRepositories<ISellerRepository>()));

            return t_result;

        }
    }
}
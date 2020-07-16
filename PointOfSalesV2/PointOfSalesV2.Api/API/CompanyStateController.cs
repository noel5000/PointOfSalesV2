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
using NPOI.SS.Formula.Functions;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.ResultState)]
    public class CompanyStateController : ControllerBase
    {
        protected readonly IDataRepositoryFactory _repositoryFactory;
        protected readonly IOptions<AppSettings> _appSettings;
        protected readonly IMemoryCache _cache;
        protected readonly IBase<LanguageKey> languageKeysRepo;
        protected IEnumerable<LanguageKey> languageKeys;
        IInvoiceRepository _customRepo;
        public CompanyStateController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache)
        {
            this._customRepo = repositoryFactory.GetCustomDataRepositories<IInvoiceRepository>();
            _repositoryFactory = repositoryFactory;
            _appSettings = appSettings;
            _cache = cache;
            this.languageKeysRepo = repositoryFactory.GetDataRepositories<LanguageKey>();
            this.languageKeys = _cache.Get<IEnumerable<LanguageKey>>("languageKeysMem");
            if (this.languageKeys == null)
            {
                this.languageKeys = this.languageKeysRepo.GetAll(x => x, y => y.Active == true).Data;
                this._cache.Set("languageKeysMem", this.languageKeys, DateTime.Now.AddHours(24));
            }
        }



        [HttpGet("GetState/{startDate}/{endDate}")]
        [ActionAuthorize(Operations.READ)]
        [EnableCors("AllowAllOrigins")]
        public virtual Task<IActionResult> GetState(long branchOfficeId = 0, long customerId = 0,long currencyId=0, string startDate="0",string endDate="0")
        {
            var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                try
                {
                    var t_inputs = arg as Tuple<string,string>;
                    var invoices = _customRepo.GetCompanyStatus(
                        t_inputs.Item1=="0"?DateTime.MinValue:Convert.ToDateTime(t_inputs.Item1),
                        t_inputs.Item2 == "0" ? DateTime.Now : Convert.ToDateTime(t_inputs.Item2));
                    var result = new List<CompanyStateReport>();
                    invoices.GroupBy(x => x.CurrencyCode).ToList().ForEach(x => {
                        result.Add(new CompanyStateReport() 
                        {
                        TotalCompanyOwedAmount=x.Sum(r=>r.CompanyOwedAmount),
                        TotalCustomersOwedAmount=x.Sum(r=>r.CustomersOwedAmount),
                        TotalIncomesAmount=x.Sum(r=>r.IncomeAmount),
                        TotalOutComesAmount=x.Sum(r=>r.OutcomeAmount),
                        CurrencyCode=x.FirstOrDefault()?.CurrencyName??"",
                        Data=x.ToList()
                        });
                    });
                    return Ok(new { status = 0, id = 0, data = result });
                }
                catch (Exception ex)
                {
                    return Ok(new { status = -1, message = ex.Message });
                }

            }, new Tuple<string,string>(startDate,endDate));

            return t_result;


        }

        [HttpPost("ExportState/{startDate}/{endDate}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.EXPORT)]
        public  Task<IActionResult> ExportState( string startDate = "0", string endDate = "0")
        {

            var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                try
                {
                    var t_inputs = arg as Tuple<string, string>;
                    var invoices = _customRepo.GetCompanyStatus(
                        t_inputs.Item1 == "0" ? DateTime.MinValue : Convert.ToDateTime(t_inputs.Item1),
                        t_inputs.Item2 == "0" ? DateTime.Now : Convert.ToDateTime(t_inputs.Item2));
                   
                      
                        string requestLanguage = "EN";
                        var languageIdHeader = this.Request.Headers["languageid"];
                        requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                        var excelData = ExportUtility.GetExcelData<CompanyStateModel>(invoices, requestLanguage, this.languageKeys.ToList());
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

            }, new Tuple<string, string>(startDate, endDate));

            return t_result;
           
        }


    }
}
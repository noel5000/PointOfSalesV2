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
using Microsoft.EntityFrameworkCore;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Invoices)]
    public class InvoiceController : BaseController<Invoice>
    {
        IInvoiceRepository _customRepo;
        public InvoiceController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache, repositoryFactory.GetCustomDataRepositories<IInvoiceRepository>())
        {
            this._customRepo = repositoryFactory.GetCustomDataRepositories<IInvoiceRepository>();
        }

        [EnableCors("AllowAllOrigins")]
        [HttpGet("GetForPrint/{id:long}")]
        [ActionAuthorize(Operations.READ)]
        public virtual Task<IActionResult> GetForPrint(long id)
        {
            var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                try
                {
                    long t_id = (long)arg;
                    var invoice = _baseRepo.GetAll<Invoice>(x => x.AsNoTracking().Include(i=>i.Customer)
                    .Include(i => i.BranchOffice).Include(i => i.Seller).Include(i => i.Currency).Include(i => i.TRNControl)
                    .Where(y => y.Active == true && y.Id == t_id)).FirstOrDefault();
                    invoice.InvoiceDetails = _repositoryFactory.GetDataRepositories<InvoiceDetail>().GetAll<InvoiceDetail>(x =>
                    x.Include(i=>i.Product).Include(i=>i.Unit), y => y.Active == true && y.InvoiceId == id).ToList();
                    return Ok(new { status = 0, id, data = new Invoice[] { invoice } });
                }

                catch (Exception ex)
                {
                    return Ok(new { status = -1, message = ex.Message });
                }

            }, id);

            return t_result;
          
        }

        [EnableCors("AllowAllOrigins")]
        [HttpGet("GetByInvoiceNumber/{invoiceNumber}")]
        [ActionAuthorize(Operations.READ)]
        public virtual Task<IActionResult> GetByInvoiceNumber(string invoiceNumber)
        {
            var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                try
                {
                    var validStates=new char[]{ ((char)Enums.BillingStates.Paid), ((char)Enums.BillingStates.FullPaid )};
                    string t_id = (string)arg;
                    var invoice = _baseRepo.GetAll<Invoice>(x => x.AsNoTracking().Include(i => i.Customer)
                    .Include(i => i.BranchOffice).Include(i => i.Seller).Include(i => i.Currency).Include(i => i.TRNControl)
                    .Where(y => y.Active == true && validStates.Contains(y.State) && y.InvoiceNumber.ToLower() == t_id.ToLower())).FirstOrDefault();
                    if(invoice==null)
                        return Ok(new { status = -1, message ="notFound_msg" });
                    invoice.InvoiceDetails = _repositoryFactory.GetDataRepositories<InvoiceDetail>().GetAll<InvoiceDetail>(x =>
                    x.Include(i => i.Product).Include(i => i.Unit), y => y.Active == true && y.InvoiceId == invoice.Id).ToList();
                    return Ok(new { status = 0, id=0, data = new Invoice[] { invoice } });
                }

                catch (Exception ex)
                {
                    return Ok(new { status = -1, message = ex.Message });
                }

            }, invoiceNumber);

            return t_result;

        }

        [EnableCors("AllowAllOrigins")]
        [HttpPost("BillQuote/{id:long}")]
        [ActionAuthorize(Operations.UPDATE)]
        public virtual Task<IActionResult> BillQuote(long id)
        {
            var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                try
                {
                    long t_id = (long)arg;
                  var result=  _customRepo.BillQuote(t_id);
                    return  Ok(result);
                }

                catch (Exception ex)
                {
                    return Ok(new { status = -1, message = ex.Message });
                }

            }, id);

            return t_result;

        }

        [EnableCors("AllowAllOrigins")]
        [HttpGet("GetInvoicesToPay/{branchOfficeId:long}/{customerId:long}/{currencyId:long}")]
        [ActionAuthorize(Operations.READALL)]
        public virtual Task<IActionResult> GetInvoicesToPay(long branchOfficeId=0,long customerId=0, long currencyId = 0)
        {
                var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                    try 
                    {
                        var t_inputs = arg as Tuple<long, long, long>;
                        var invoices = _customRepo.GetInvoicesToPay(t_inputs.Item1,t_inputs.Item3,t_inputs.Item2);
                        return Ok(new { status = 0, id = 0, data = invoices });
                    }
                    catch (Exception ex)
                    {
                        return Ok(new { status = -1, message = ex.Message });
                    }
                   
                },new Tuple<long,long,long>(branchOfficeId,customerId,currencyId));

            return t_result;

           
        }

        [EnableCors("AllowAllOrigins")]
        [HttpGet("GetAccountReceivables/{branchOfficeId:long}/{customerId:long}/{currencyId:long}/{startDate}/{endDate}")]
        [ActionAuthorize(Operations.ACCOUNTRECEIVABLES)]
        public virtual Task<IActionResult> GetAccountReceivables(long branchOfficeId = 0, long customerId = 0,long currencyId=0, string startDate="0",string endDate="0")
        {
            var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                try
                {
                    var t_inputs = arg as Tuple<long, long, long,string,string>;
                    var invoices = _customRepo.GetAccountsReceivable(
                        t_inputs.Item4=="0"?DateTime.MinValue:Convert.ToDateTime(t_inputs.Item4),
                        t_inputs.Item5 == "0" ? DateTime.Now : Convert.ToDateTime(t_inputs.Item5),
                        t_inputs.Item1, t_inputs.Item2,null, t_inputs.Item3);
                    return Ok(new { status = 0, id = 0, data = invoices });
                }
                catch (Exception ex)
                {
                    return Ok(new { status = -1, message = ex.Message });
                }

            }, new Tuple<long, long, long,string,string>(customerId, currencyId,branchOfficeId,startDate,endDate));

            return t_result;


        }

        [HttpPost("ExportAccountReceivables/{branchOfficeId:long}/{customerId:long}/{currencyId:long}/{startDate}/{endDate}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ACCOUNTRECEIVABLES)]
        public  Task<IActionResult> ExportAccountReceivables(long branchOfficeId = 0, long customerId = 0, long currencyId = 0, string startDate = "0", string endDate = "0")
        {

            var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                try
                {
                    var t_inputs = arg as Tuple<long, long, long, string, string>;
                    var invoices = _customRepo.GetAccountsReceivable(
                        t_inputs.Item4 == "0" ? DateTime.MinValue : Convert.ToDateTime(t_inputs.Item4),
                        t_inputs.Item5 == "0" ? DateTime.Now : Convert.ToDateTime(t_inputs.Item5),
                        t_inputs.Item1, t_inputs.Item2, null, t_inputs.Item3);
                   
                      
                        string requestLanguage = "EN";
                        var languageIdHeader = this.Request.Headers["languageid"];
                        requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                        var excelData = ExportUtility.GetExcelData<Invoice>(invoices, requestLanguage, this.languageKeys.ToList());
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

            }, new Tuple<long, long, long, string, string>(customerId, currencyId, branchOfficeId, startDate, endDate));

            return t_result;
           
        }


        [EnableCors("AllowAllOrigins")]
        [HttpGet("GetSales/{branchOfficeId:long}/{customerId:long}/{currencyId:long}/{startDate}/{endDate}")]
        [ActionAuthorize(Operations.SALESREPORT)]
        public virtual Task<IActionResult> GetSales(long branchOfficeId = 0, long customerId = 0, long currencyId = 0, string startDate = "0", string endDate = "0")
        {
            var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                try
                {
                    var t_inputs = arg as Tuple<long, long, long, string, string>;
                    var invoices = _customRepo.GetSales(
                        t_inputs.Item4 == "0" ? DateTime.MinValue : Convert.ToDateTime(t_inputs.Item4),
                        t_inputs.Item5 == "0" ? DateTime.Now : Convert.ToDateTime(t_inputs.Item5),
                        t_inputs.Item1, t_inputs.Item2, null, t_inputs.Item3);
                    return Ok(new { status = 0, id = 0, data = invoices });
                }
                catch (Exception ex)
                {
                    return Ok(new { status = -1, message = ex.Message });
                }

            }, new Tuple<long, long, long, string, string>(customerId, currencyId, branchOfficeId, startDate, endDate));

            return t_result;


        }

        [HttpPost("ExportSales/{branchOfficeId:long}/{customerId:long}/{currencyId:long}/{startDate}/{endDate}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.SALESREPORT)]
        public Task<IActionResult> ExportSales(long branchOfficeId = 0, long customerId = 0, long currencyId = 0, string startDate = "0", string endDate = "0")
        {

            var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                try
                {
                    var t_inputs = arg as Tuple<long, long, long, string, string>;
                    var invoices = _customRepo.GetSales(
                        t_inputs.Item4 == "0" ? DateTime.MinValue : Convert.ToDateTime(t_inputs.Item4),
                        t_inputs.Item5 == "0" ? DateTime.Now : Convert.ToDateTime(t_inputs.Item5),
                        t_inputs.Item1, t_inputs.Item2, null, t_inputs.Item3);


                    string requestLanguage = "EN";
                    var languageIdHeader = this.Request.Headers["languageid"];
                    requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                    var excelData = ExportUtility.GetExcelData<Invoice>(invoices, requestLanguage, this.languageKeys.ToList());
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

            }, new Tuple<long, long, long, string, string>(customerId, currencyId, branchOfficeId, startDate, endDate));

            return t_result;

        }

       
    }
}
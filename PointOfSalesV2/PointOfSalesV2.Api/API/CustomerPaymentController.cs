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
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.CustomerPayments)]
    public class CustomerPaymentController : BaseController<CustomerPayment>
    {
        public CustomerPaymentController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache)
        {
        }
        [HttpPost("PayInvoices")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ADD)]
        public IActionResult PayInvoices([FromBody]InvoicesPaymentModel model) 
        {
            try
            {
                var repo = _repositoryFactory.GetCustomDataRepositories<ICustomerPaymentRepository>();
                var result = repo.PayInvoices(model);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }


        [HttpGet("GetForPrint/{sequence}")]
        [ActionAuthorize(Operations.READ)]
        [EnableCors("AllowAllOrigins")]
        public virtual Task<IActionResult> GetForPrint(string sequence)
        {
            var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                try
                {
                    string t_sequence = (string)arg;
                    var payments = _baseRepo.GetAll<CustomerPayment>(x => x.Include(t=>t.Customer)
                    .Include(t=>t.Currency)
                    ,y=>y.Active==true && y.Sequence.ToLower()==t_sequence).ToList();

                   
                    return Ok(new { status = 0, id=0, data = new object[] { new 
                    {
                    payments.FirstOrDefault().Customer,
                    payments.FirstOrDefault().Currency,
                    payments.FirstOrDefault().Date,
                    PaidInvoices=payments
                    } } });
                }

                catch (Exception ex)
                {
                    return Ok(new { status = -1, message = ex.Message });
                }

            }, sequence);

            return t_result;

        }

        [HttpDelete("ReversePayment/{sequence}/{userId}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.DELETE)]
        public virtual IActionResult ReversePayment(string sequence,string userId)
        {
            try
            {
                var result =this._repositoryFactory.GetCustomDataRepositories<ICustomerPaymentRepository>().ReversePayment(sequence, userId);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });

            }

        }


        [HttpGet("GetReceipts/{branchOfficeId:long}/{customerId:long}/{currencyId:long}/{paymentTypeId:long}/{startDate}/{endDate}")]
        [ActionAuthorize(Operations.RECEIPTSREPORT)]
        [EnableCors("AllowAllOrigins")]
        public virtual Task<IActionResult> GetReceipts(long branchOfficeId = 0, long customerId = 0, long currencyId = 0,long paymentTypeId=0, string startDate = "0", string endDate = "0")
        {
            DateTime? start = new DateTime();
            if (startDate != "0")
                start = Convert.ToDateTime(startDate);
            else
                start = null;
            DateTime? end = new DateTime();
            if (endDate != "0")
                end = Convert.ToDateTime(endDate);
            else
                end = null;
            var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                try
                {
                    
                    var t_inputs = arg as Tuple<long, long, long,long, DateTime?, DateTime?>;
                    var invoices = base._repositoryFactory.GetCustomDataRepositories<ICustomerPaymentRepository>().IncomesReport(
                        t_inputs.Item3,
                        t_inputs.Item1,
                        t_inputs.Item2,
                        t_inputs.Item4,
                        t_inputs.Item5,
                        t_inputs.Item6

                        );
                    return Ok(new { status = 0, id = 0, data = invoices });
                }
                catch (Exception ex)
                {
                    return Ok(new { status = -1, message = ex.Message });
                }

            }, new Tuple<long, long, long,long, DateTime?, DateTime?>(customerId, currencyId, branchOfficeId,paymentTypeId, start, end));

            return t_result;


        }

        [HttpPost("ExportReceipts/{branchOfficeId:long}/{customerId:long}/{currencyId:long}/{paymentTypeId:long}/{startDate}/{endDate}")]
        [ActionAuthorize(Operations.RECEIPTSREPORT)]
        [EnableCors("AllowAllOrigins")]
        public virtual Task<IActionResult> ExportReceipts(long branchOfficeId = 0, long customerId = 0, long currencyId = 0, long paymentTypeId = 0, string startDate = "0", string endDate = "0")
        {
            DateTime? start = new DateTime();
            if (startDate != "0")
                start = Convert.ToDateTime(startDate);
            else
                start = null;
            DateTime? end = new DateTime();
            if (endDate != "0")
                end = Convert.ToDateTime(endDate);
            else
                end = null;
            var t_result = Task.Factory.StartNew<IActionResult>((arg) => {
                try
                {

                    var t_inputs = arg as Tuple<long, long, long, long, DateTime?, DateTime?>;
                    var invoices = base._repositoryFactory.GetCustomDataRepositories<ICustomerPaymentRepository>().IncomesReport(
                        t_inputs.Item3,
                        t_inputs.Item1,
                        t_inputs.Item2,
                        t_inputs.Item4,
                        t_inputs.Item5,
                        t_inputs.Item6

                        );
                    string requestLanguage = "EN";
                    var languageIdHeader = this.Request.Headers["languageid"];
                    requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                    var excelData = ExportUtility.GetExcelData<CustomerPayment>(invoices, requestLanguage, this.languageKeys.ToList());
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

            }, new Tuple<long, long, long, long, DateTime?, DateTime?>(customerId, currencyId, branchOfficeId, paymentTypeId, start, end));

            return t_result;


        }

    }
}
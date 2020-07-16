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
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Invoices)]
    public class InvoiceLeadController : BaseController<InvoiceLead>
    {
        public InvoiceLeadController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,repositoryFactory.GetCustomDataRepositories<IInvoiceLeadRepository>())
        {
        }

        [HttpGet("DeliverLead/{id:long}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.UPDATE)]
        public IActionResult DeliverLead(long id)
        {
            try
            {
                var repo = _repositoryFactory.GetCustomDataRepositories<IInvoiceLeadRepository>();
                var result = repo.DeliverLead(id);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        

         [HttpGet("GetLeadForPrint/{leadId:long}/{menuId:long}/{schoolId:long}/{sequence}")]
        [ActionAuthorize(Operations.READ)]
        [EnableCors("AllowAllOrigins")]
        public IActionResult GetLeadForPrint(long leadId, long menuId, long schoolId,string sequence="")
        {
            try
            {
                var repo = _repositoryFactory.GetCustomDataRepositories<IInvoiceLeadRepository>();
                var result = repo.GetLeadOrMenuInfo(leadId,menuId,schoolId, sequence);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        
    }
}
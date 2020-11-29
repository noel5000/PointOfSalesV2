using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Api.Security;
using PointOfSalesV2.Entities;
using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using static PointOfSalesV2.Common.Enums;
using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Api.Models;
using PointOfSalesV2.Common;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.WarehouseTransfers)]
    public class WarehouseMovementController : BaseController<WarehouseMovement>
    {
        public WarehouseMovementController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory, cache)
        {
        }

        [HttpGet("GetProductMovements/{branchOfficeId:long}/{warehouseId:long}/{productId:long}/{reference}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.PRODUCTMOVEMENTS)]
        public IActionResult GetProductMovements(long branchOfficeId = 0, long warehouseId = 0, long productId = 0, string reference = "")
        {
            try
            {
                var data = _baseRepo.GetAll<WarehouseMovement>(x =>
                x.Include(t => t.Unit)
                .Include(t => t.Warehouse)
                .Include(t => t.BranchOffice)
                .Include(t => t.Product)
                 , y =>
                  (branchOfficeId > 0 ? y.BranchOfficeId == branchOfficeId : y.BranchOfficeId > 0)
                  && (warehouseId > 0 ? y.WarehouseId == warehouseId : y.WarehouseId > 0)
                  && (productId > 0 ? y.ProductId == productId : y.ProductId > 0)
                  && (!string.IsNullOrEmpty(reference) && reference != "*" ? y.Reference.ToLower() == reference : y.Reference != "")
                && y.Active == true).OrderBy(x=>x.CreatedDate).Select(x => new WarehouseMovementModel()
                {
                    BranchOffice = new BaseModel() { Id = x.BranchOffice.Id, Name = x.BranchOffice.Name },
                    Warehouse = new BaseModel() { Id = x.Warehouse.Id, Name = x.Warehouse.Name },
                    Product = new BaseModel() { Id = x.Product.Id, Name = x.Product.Name },
                    Unit = new BaseModel() { Id = x.Unit.Id, Name = x.Unit.Name },
                    UnitId=x.UnitId,
                    CurrentBalance=x.CurrentBalance,
                    BranchOfficeId=x.BranchOfficeId,
                    MovementType=x.MovementType,
                    Id=x.Id,
                    ProductId=x.ProductId,
                    Quantity=x.Quantity,
                    Reference=x.Reference,
                    WarehouseId=x.WarehouseId
                });

                return Ok(new {id=0,status=0,data=data });

            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpPost("ExportToExcel/{branchOfficeId:long}/{warehouseId:long}/{productId:long}/{reference}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.PRODUCTMOVEMENTS)]
        public IActionResult ExportToExcel(long branchOfficeId = 0, long warehouseId = 0, long productId = 0, string reference="")
        {
            try
            {
                var data = _baseRepo.GetAll<WarehouseMovement>(x =>
                x.Include(t => t.Unit)
                .Include(t => t.Warehouse)
                .Include(t => t.BranchOffice)
                .Include(t => t.Product)
                 , y =>
                  (branchOfficeId > 0 ? y.BranchOfficeId == branchOfficeId : y.BranchOfficeId > 0)
                  && (warehouseId > 0 ? y.WarehouseId == warehouseId : y.WarehouseId > 0)
                  && (productId > 0 ? y.ProductId == productId : y.ProductId > 0)
                  && (!string.IsNullOrEmpty(reference) && reference!="*" ? y.Reference.ToLower() == reference : y.Reference != "")
                && y.Active == true).OrderBy(x => x.CreatedDate);
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "ES";
                var excelData = ExportUtility.GetExcelData<WarehouseMovement>(data, requestLanguage, this.languageKeys.ToList());
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
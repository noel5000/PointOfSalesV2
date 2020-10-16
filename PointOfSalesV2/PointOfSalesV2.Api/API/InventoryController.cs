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
using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Api.Models;
using static PointOfSalesV2.Common.Enums;
using PointOfSalesV2.Common;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Inventories)]
    public class InventoryController : BaseController<Inventory>
    {
        public InventoryController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache)
        {
        }

        [HttpPatch("GetCompanyInventory/{branchOfficeId:long}/{warehouseId:long}/{productId:long}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Common.Enums.Operations.INVENTORYREPORT)]
        public IActionResult GetCompanyInventory(long branchOfficeId = 0, long warehouseId = 0,long productId=0) 
        {
            try
            {
                List<object> result = new List<object>();
                var data = _baseRepo.GetAll<Inventory>(x => x.Include(i => i.Product)
                .Include(i => i.Warehouse)
                .Include(i => i.BranchOffice)
                .Include(i=>i.Unit)
                , y => y.Active == true
                   && (branchOfficeId > 0 ? y.BranchOfficeId == branchOfficeId : y.BranchOfficeId > 0)
                   && (warehouseId > 0 ? y.WarehouseId == warehouseId : y.WarehouseId > 0)
                   && (productId > 0 ? y.ProductId == productId : y.ProductId > 0))
                   .ToList()
                    .GroupBy(x => x.BranchOfficeId)
                   .ToList();
                data.ForEach(i => {
                    BranchOfficeModel branchOffice =new BranchOfficeModel() 
                    {
                    Id= i.FirstOrDefault().BranchOffice.Id,
                    Name= i.FirstOrDefault().BranchOffice.Name
                    } ;
                    List<WarehouseModel> warehouses = new List<WarehouseModel>();
                    i.GroupBy(x => x.WarehouseId).ToList().ForEach(w =>
                    {
                        warehouses.Add(new WarehouseModel() 
                        {
                        Id= w.FirstOrDefault().Warehouse.Id,
                        Name= w.FirstOrDefault().Warehouse.Name,
                        Code= w.FirstOrDefault().Warehouse.Code
                        });
                    });
                    warehouses.ForEach(n => { 
                    n.Inventory = i.Where(e=>e.WarehouseId==n.Id).Select(x => new InventoryModel()
                    {
                        Warehouse= new BaseModel() {Name=n.Name, Id=n.Id },
                        ProductId = x.ProductId,
                        Product = new BaseModel {Id=x.Product.Id, Name=x.Product.Name },
                        Unit =new BaseModel() {Id = x.Unit.Id, Name = x.Unit.Name },
                        UnitId = x.UnitId,
                        Quantity = x.Quantity,
                    }).ToList();
                    });
                    branchOffice.Warehouses = warehouses;
                    result.Add(branchOffice);
                });

                    return Ok(new { id = 0, status = 0, message = "ok_msg", data = result });
            }
            catch (Exception ex) 
            {
                return Ok(new { id = -1, status = -1, message = "error_msg" });
            }
        }

        [HttpPost("ExportToExcel/{branchOfficeId:long}/{warehouseId:long}/{productId:long}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.INVENTORYREPORT)]
        public  IActionResult ExportToExcel(long branchOfficeId = 0, long warehouseId = 0, long productId = 0)
        {
            try
            {
                var data = _baseRepo.GetAll<Inventory>(x => x.Include(i => i.Product)
                .Include(i => i.Warehouse)
                .Include(i => i.BranchOffice)
                .Include(i => i.Unit)
                 , y => y.Active == true
                  && (branchOfficeId > 0 ? y.BranchOfficeId == branchOfficeId : y.BranchOfficeId > 0)
                  && (warehouseId > 0 ? y.WarehouseId == warehouseId : y.WarehouseId > 0)
                  && (productId > 0 ? y.ProductId == productId : y.ProductId > 0));
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "ES";
                var excelData = ExportUtility.GetExcelData<Inventory>(data, requestLanguage, this.languageKeys.ToList());
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
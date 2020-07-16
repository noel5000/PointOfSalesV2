using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Microsoft.OData.Edm;
using PointOfSalesV2.Api.Security;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using Newtonsoft.Json;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using static PointOfSalesV2.Common.Enums;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{

    //   ODataController\

    public abstract class BaseController<T> : ControllerBase where T : class, ICommonData, new()
    {
        protected readonly IDataRepositoryFactory _repositoryFactory;
        protected readonly IOptions<AppSettings> _appSettings;
        protected readonly IBase<T> _baseRepo;
        protected readonly IMemoryCache _cache;
        protected readonly IBase<LanguageKey> languageKeysRepo;
        protected IEnumerable<LanguageKey> languageKeys;
        public BaseController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory,IMemoryCache cache, IBase<T> customRepo = null)
        {
            this._cache = cache;
            _appSettings = appSettings;
            _repositoryFactory = repositoryFactory;
            this.languageKeysRepo = repositoryFactory.GetDataRepositories<LanguageKey>();
            this.languageKeys = _cache.Get<IEnumerable<LanguageKey>>("languageKeysMem");
            if (this.languageKeys == null) 
            {
                this.languageKeys = this.languageKeysRepo.GetAll(x=>x, y => y.Active == true).Data;
                this._cache.Set("languageKeysMem", this.languageKeys,DateTime.Now.AddHours(24));
            }
            this._baseRepo=customRepo?? _repositoryFactory.GetDataRepositories<T>();
        }

        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery()]
        [EnableCors("AllowAllOrigins")]
        public virtual IActionResult Get()
        {
            try
            {
                var data = _baseRepo.GetAll<T>(x => x.Where(y => y.Active == true));
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpGet("ExportToExcel")]
        [ActionAuthorize(Operations.EXPORT)]
        [EnableCors("AllowAllOrigins")]
        [EnableQuery()]
        [ODataRoute("[controller]/ExportToExcel")]
        public virtual IActionResult ExportToExcel()
        {
            try
            {
                var data = _baseRepo.GetAll<T>(x => x.Where(y => y.Active == true));
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                var excelData = ExportUtility.GetExcelData<T>(data, requestLanguage,this.languageKeys.ToList());
                var excelStream = ExcelImport.CreateXlsStream(
                    excelData.Item1,
                   excelData.Item2
                   );
                if (data != null && excelStream != null && excelStream.Length > 0)
                {

                    return File(excelStream.ToArray(), "application/octet-stream", $"{new T().GetType().Name}-{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}.xls");
                }
                return BadRequest(new { status = -1, message = "Documento no existe" });


            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpGet("{id:long}")]
        [EnableCors("AllowAllOrigins")]
        //[EnableQuery]
        [ActionAuthorize(Operations.READ)]
        public virtual IActionResult Get(long id)
        {
            try
            {
                var data = _baseRepo.Get(id);
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpGet("{number:int}/{size:int}")]
        [EnableCors("AllowAllOrigins")]
        // [EnableQuery]
        [ActionAuthorize(Operations.READALL)]
        public virtual IActionResult Get(int number, int size)
        {
            try
            {
                var data = _baseRepo.GetPaged(number, size);
                data.Status = 0;
                data.Message = "ok_msg";
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
        public virtual IActionResult Post([FromBody] T model)
        {
            try
            {
                var activeEntity = model as ICommonData;
                if (activeEntity != null)
                {
                    activeEntity.Active = true;
                    model = activeEntity as T;
                }
                var result = _baseRepo.Add(model);

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
        public virtual IActionResult Put([FromBody] T model)
        {
            try
            {
                var result = _baseRepo.Update(model);
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
        public virtual IActionResult Delete(long id)
        {
            try
            {
                var result = _baseRepo.Remove(id);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });

            }

        }

        protected virtual IBase<K> GetDataRepo<K>() where K : class, ICommonData, new()
        {
            return _repositoryFactory.GetDataRepositories<K>();
        }
    }
}
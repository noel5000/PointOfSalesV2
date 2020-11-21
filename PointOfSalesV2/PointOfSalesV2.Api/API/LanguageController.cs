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
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : BaseController<Language>
    {
        private readonly ILanguageKeyRepository languageKeyRepository;
        public LanguageController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache)
        {
            this.languageKeyRepository = repositoryFactory.GetCustomDataRepositories<ILanguageKeyRepository>();
        }

        [HttpGet]
        [EnableCors("AllowAllOrigins")]
        [EnableQuery()]
        public override IActionResult Get()
        {
            try
            {
                var data = _baseRepo.GetAll<Language>(x => x.Where(y => y.Active == true));
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpGet("GenerateJsonFile/{serverType:int}")]
       [ActionAuthorize(Common.Enums.Operations.GENERATEDICTIONARY)]
        [EnableCors("AllowAllOrigins")]
        public IActionResult GenerateJsonFile(int serverType=0) 
        {
            try
            {
                var folderType = (ServerDirectoryType)Enum.ToObject(typeof(ServerDirectoryType), serverType);
                string path = folderType == ServerDirectoryType.FTP ? this._appSettings.Value.I18nFolderFtp :
                    this._appSettings.Value.I18nFolder;
                var result = languageKeyRepository.UploadI18nDictionaries(path, folderType);
                return Ok(result);
            }
            catch
            {
                return Ok(new Result<object>(-1, -1, "errorDictionary_msg"));
            }
        }


       

        

        [HttpGet("{id:long}")]
        [EnableCors("AllowAllOrigins")]
        public override IActionResult Get(long id)
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
        public override IActionResult Get(int number, int size)
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
        public override IActionResult Post([FromBody] Language model)
        {
            
                return Ok(new { status = -1 });
            

        }

        [HttpPut]
        [EnableCors("AllowAllOrigins")]
        public override IActionResult Put([FromBody] Language model)
        {
            return Ok(new { status = -1 });

        }

        [HttpDelete("{id:long}")]
        [EnableCors("AllowAllOrigins")]
        public override IActionResult Delete(long id)
        {
            return Ok(new { status = -1 });

        }
    }
}
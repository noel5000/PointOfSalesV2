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

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Invoices)]
    public class LanguageController : BaseController<Language>
    {
        private readonly ILanguageKeyRepository languageKeyRepository;
        public LanguageController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache)
        {
            this.languageKeyRepository = repositoryFactory.GetCustomDataRepositories<ILanguageKeyRepository>();
        }

        [HttpGet("GenerateJsonFile/{serverType:int}")]
        [ActionAuthorize(Common.Enums.Operations.UPDATE)]
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
    }
}
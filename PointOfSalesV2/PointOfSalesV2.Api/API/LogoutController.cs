using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using PointOfSalesV2.Repository.Helpers;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogoutController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IMemoryCache _cache;
        readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IBase<User> users;
        private readonly IDataRepositoryFactory dataRepositoryFactory;
        private readonly IUserRepository userRepository;

        public LogoutController(IMemoryCache cache, IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IHttpContextAccessor httpContextAccessor)
        {
            this._httpContextAccessor = httpContextAccessor;
            this._appSettings = appSettings;
            this._cache = cache;
            this.users = repositoryFactory.GetDataRepositories<User>();
            this.dataRepositoryFactory = repositoryFactory;
            this.userRepository = this.dataRepositoryFactory.GetCustomDataRepositories<IUserRepository>();
        }

        [HttpPost]
        [EnableCors("AllowAllOrigins")]
        public IActionResult Post()
        {
            try
            {

                string currentToken = _httpContextAccessor.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "Authorization").Value.ToString();
                if (!string.IsNullOrEmpty(currentToken) && currentToken.Contains("Bearer"))
                    
                {
                    _cache.Remove(currentToken.Split(" ").LastOrDefault());
                    return Ok(new
                    {
                        message = "OK",
                        status = 1,
                        token = currentToken
                    });
                }
                else
                    return BadRequest(new
                    {
                        message = "error_msg",
                        status = -1,
                       
                    });

            }
            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}
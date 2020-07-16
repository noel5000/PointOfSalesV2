using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Api.Security
{
    public class ControllerAuthorize : TypeFilterAttribute
    {
        public ControllerAuthorize(AppSections section) : base(typeof(ClaimRequirementFilter))
        {

            Arguments = new object[] { section };
        }




    }

    public class ClaimRequirementFilter : IAuthorizationFilter
    {
        readonly AppSections _section;
        readonly IHttpContextAccessor _httpContextAccessor;
        readonly IMemoryCache _cache;

        public ClaimRequirementFilter(AppSections section, IHttpContextAccessor httpContextAccessor, IMemoryCache cache)
        {
            _section = section;
            _httpContextAccessor = httpContextAccessor;
            _cache = cache;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool isInvalid = false;
            var currentToken = _httpContextAccessor.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "Authorization").Value.ToString();


            var currentPath = _httpContextAccessor.HttpContext.Request.Path.ToString().Split("/").ToList();
            int index = currentPath.IndexOf("api") + 1;
            index = index == 0 ? currentPath.IndexOf("odata") + 1 : index;
            string[] currentController =_section== AppSections.All? new string[1] { currentPath[index] } :Enums.SectionsControllers[_section].Split(",");
            if (string.IsNullOrEmpty(currentToken) || currentController.Length==0 || !currentToken.Contains("Bearer"))
                isInvalid = true;

            if (!isInvalid)
            {
                string token = currentToken.Split(" ").LastOrDefault();
                User user = _cache.Get<User>(token);
                if (user == null)
                    context.Result = new ForbidResult();
                else
                {
                    var actualPermission = user.Permissions.Count() == 0 ? new UserOperation() : user.Permissions.Where(x => currentController.Intersect(x.Controllers.Split(",")).Any()||
                    x.Controllers.ToLower() == "*").FirstOrDefault();

                    if (actualPermission == null && user.Permissions.Count() > 0)
                        context.Result = new ForbidResult();
                }

            }
            else
                context.Result = new ForbidResult();
        }
    }
}

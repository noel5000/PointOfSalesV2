using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PointOfSalesV2.Common.Enums;
using Microsoft.EntityFrameworkCore.Internal;

namespace PointOfSalesV2.Api.Security
{

    public class ActionAuthorize : TypeFilterAttribute
    {
        public ActionAuthorize(Operations operation) : base(typeof(ActionRequirementFilter))
        {

            Arguments = new object[] { operation, new Operations[0] };
        }

        public ActionAuthorize(Operations[] operations) : base(typeof(ActionRequirementFilter))
        {

            Arguments = new object[] {Operations.NONE, operations };
        }




    }

    public class ActionRequirementFilter : IAuthorizationFilter
    {
        readonly Operations _operation;
        readonly Operations[] _operations;
        readonly IHttpContextAccessor _httpContextAccessor;
        readonly IMemoryCache _cache;

        public ActionRequirementFilter(Operations operation, Operations[] operations, IHttpContextAccessor httpContextAccessor, IMemoryCache cache)
        {
            _operation = operation;
            _operations = operations;
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
            string currentController = currentPath[index];
            if (string.IsNullOrEmpty(currentToken) || string.IsNullOrEmpty(currentController) || !currentToken.Contains("Bearer"))
                isInvalid = true;

            if (!isInvalid)
            {
                string token = currentToken.Split(" ").LastOrDefault();
                User user = _cache.Get<User>(token);
                if (user == null)
                    context.Result = new ForbidResult();
                else
                {
                    var operations =user.Permissions.Count()==0? new List<UserOperation>() {new UserOperation() }:
                        (_operation!= Operations.NONE?
                        user.Permissions.Where(r => (r.Controllers.ToLower().Split(",").ToList().Contains(currentController.ToLower()) || r.Controllers=="*") && (r.OperationId==(int)_operation || r.OperationId == (int)Operations.ALL)):
                        user.Permissions.Where(r => (r.Controllers.ToLower().Split(",").ToList().Contains(currentController.ToLower()) || r.Controllers == "*") && (_operations.ToList().FindIndex(p=>p==(Operations)r.OperationId)>=0 || _operations.ToList().FindIndex(t=>t == Operations.ALL)>=0))
                        );

                    if (user.Permissions.Count() > 0  && (operations==null || operations.Count()==0))
                        context.Result = new ForbidResult();
                }

            }
            else
                context.Result = new ForbidResult();
        }
    }
}

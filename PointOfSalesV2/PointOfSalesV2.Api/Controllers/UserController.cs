using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
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
    [ControllerAuthorize(Common.Enums.AppSections.Users)]
    public class UserController :ControllerBase
    {
        protected readonly IDataRepositoryFactory _repositoryFactory;
        protected readonly IOptions<AppSettings> _appSettings;
        protected readonly IUserRepository _baseRepo;
        public UserController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory)
        {
            _appSettings = appSettings;
            _repositoryFactory = repositoryFactory;
            this._baseRepo = _repositoryFactory.GetCustomDataRepositories<IUserRepository>();
        }


        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery()]
        public virtual IActionResult Get()
        {
            try
            {
                var data = _baseRepo.GetAll<User>(x => x.Where(y =>y.UserId.ToString()!=new Guid().ToString()));
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpGet("{id}")]
        //[EnableQuery]
        [ActionAuthorize(Operations.READ)]
        public virtual IActionResult Get(string id)
        {
            try
            {
                var data = _baseRepo.Get(new Guid(id));
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpGet("{number:int}/{size:int}")]
        // [EnableQuery]
        [ActionAuthorize(Operations.READPAGED)]
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
        [ActionAuthorize(Operations.ADD)]
        public virtual IActionResult Post([FromBody] User model)
        {
            try
            {
                var activeEntity = model as ICommonData;
                if (activeEntity != null)
                {
                    activeEntity.Active = true;
                    model = activeEntity as User;
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
        [ActionAuthorize(Operations.UPDATE)]
        public virtual IActionResult Put([FromBody] User model)
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

        [HttpDelete("{id}")]
        [ActionAuthorize(Operations.DELETE)]
        public virtual IActionResult Delete(string id)
        {
            try
            {
                var model = _baseRepo.Get(new Guid(id)).Data.FirstOrDefault() as ICommonData;
                if (model != null)
                {
                    model.Active = false;
                    var result = _baseRepo.Update(model as User);
                    return Ok(result);
                }
                else
                {
                    return Ok(new { status = -1, message = "error_msg" });
                }

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
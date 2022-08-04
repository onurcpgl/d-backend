using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.DataTransferObject;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGroupController : ControllerBase
    {
        private IUserGroupService _userGroupService;
        

        public UserGroupController(IUserGroupService userGroupService)
        {
            _userGroupService = userGroupService;
            
        }


        [HttpGet("getAllUserGroup")]
        public IActionResult GetAll()
        {
            var result = _userGroupService.GetList();
            return Ok(result);
        }

       







      



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.DataTransferObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
            
        }
        [HttpPost("users")]
        public IActionResult save([FromBody] UserManagementDto userManagementDto)
        {
            _userService.update(userManagementDto);
            return Ok();
        }
        [HttpGet("{userId}")]
        public IActionResult getByDomain(int userId)
        {
            return Ok(_userService.getUserById(userId));
        }

        [HttpGet("users")]
        public IActionResult getAllUsers()
        {
            return Ok(_userService.getAllUsers());
        }


    }

   
}

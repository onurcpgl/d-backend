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
    public class DomainController : ControllerBase
    {

        private IDomainService _domainService;
        public DomainController(IDomainService domainService)
        {
            _domainService = domainService;
        }

        [HttpGet("allDomain")]
        public IActionResult getAllDomain()
        {   
            return Ok(_domainService.GetList());
        }


        [HttpPost("linkSave")]
        public IActionResult Save([FromBody] LinkAddDataDto linkAddDataDto)
        {
            bool status = _domainService.Add(linkAddDataDto);
            if (status)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }
    }
}

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
    public class AnnouncmentController : ControllerBase
    {
        private IAnnouncementsService _announcementsService;

        public AnnouncmentController(IAnnouncementsService announcementsService)
        {
            _announcementsService = announcementsService;

        }


        [HttpPost("save")]
        public IActionResult Save([FromBody] AnnouncementDataDto announcementData)
        {
            bool status = _announcementsService.Add(announcementData);
            if (status)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }



        [HttpGet("getAllAnnouncement")]
        public IActionResult GetAll()
        {
            var result = _announcementsService.GetList();
            return Ok(result);
        }
    }
}



  


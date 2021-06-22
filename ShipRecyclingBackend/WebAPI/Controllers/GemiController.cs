using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GemiController : ControllerBase
    {
        private IGemilerService _gemilerService;

        public GemiController(IGemilerService gemilerService)
        {
            _gemilerService = gemilerService;
        }

        [HttpGet("getall")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {
            
            var result = _gemilerService.GetList();
            
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getalldetailsofgemi")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetGemiDetailsList()
        {
            
            var result = _gemilerService.GetGemiDetails();
            
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getlistbygemitipi")]
        public IActionResult GetListByGemiTipi(int gemiTipiId)
        {
            var result = _gemilerService.GetListByGemiTipi(gemiTipiId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int gemiId)
        {
            var result = _gemilerService.GetById(gemiId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Gemiler gemi)
        {
            var result = _gemilerService.Add(gemi);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Gemiler gemi)
        {
            var result = _gemilerService.Update(gemi);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Gemiler gemi)
        {
            var result = _gemilerService.Delete(gemi);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

    }
}

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

        [HttpGet("getdetailsofgemibyid")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetGemiDetailsByGemiId(int Id)
        {

            var result = _gemilerService.GetGemiDetailsByGemiId(Id);
            
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
                return Ok(result);
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

        [HttpPut("update")]
        public IActionResult Update(Gemiler gemi)
        {
            var result = _gemilerService.Update(gemi);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {

            var deletedGemi = _gemilerService.GetById(id).Data;
            var result = _gemilerService.Delete(deletedGemi);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

    }
}

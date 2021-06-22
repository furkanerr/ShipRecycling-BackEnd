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
    public class ParaBirimiController : ControllerBase
    {
        private IParaBirimleriService _paraBirimleriService;

        public ParaBirimiController( IParaBirimleriService paraBirimleriService)
        {
            _paraBirimleriService = paraBirimleriService;
            
        }

        [HttpGet("getall")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {
            
            var result = _paraBirimleriService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            

            return BadRequest(result.Message);
        }

        

        [HttpGet("getbyid")]
        public IActionResult GetById(int paraBirimiId)
        {
            var result = _paraBirimleriService.GetById(paraBirimiId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(ParaBirimleri paraBirimleri)
        {
            var result = _paraBirimleriService.Add(paraBirimleri);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(ParaBirimleri paraBirimleri)
        {
            var result = _paraBirimleriService.Update(paraBirimleri);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(ParaBirimleri paraBirimleri)
        {
            var result = _paraBirimleriService.Delete(paraBirimleri);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

    }
    
}


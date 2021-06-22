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
    public class OlcuBirimiController : ControllerBase
    {
        private IOlcuBirimiService _olcuBirimiService;

        public OlcuBirimiController(IOlcuBirimiService olcuBirimiService)
        {
            _olcuBirimiService = olcuBirimiService;
           
        }

        [HttpGet("getall")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {
            
            var result = _olcuBirimiService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            

            return BadRequest(result.Message);
        }

        

        [HttpGet("getbyid")]
        public IActionResult GetById(int olcuBirimiId)
        {
            var result = _olcuBirimiService.GetById(olcuBirimiId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(OlcuBirimi olcuBirimi)
        {
            var result = _olcuBirimiService.Add(olcuBirimi);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(OlcuBirimi olcuBirimi)
        {
            var result = _olcuBirimiService.Update(olcuBirimi);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(OlcuBirimi olcuBirimi)
        {
            var result = _olcuBirimiService.Delete(olcuBirimi);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

    }
    
}


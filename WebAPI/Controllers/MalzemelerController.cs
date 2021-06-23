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
    public class MalzemelerController : ControllerBase
    {
        private IMalzemelerService _malzemelerService;

        public MalzemelerController(IMalzemelerService malzemelerService)
        {
            _malzemelerService = malzemelerService;
            
        }

        [HttpGet("getall")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {
            
            var result = _malzemelerService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            

            return BadRequest(result.Message);
        }

        

        [HttpGet("getbyid")]
        public IActionResult GetById(int malzemelerId)
        {
            var result = _malzemelerService.GetById(malzemelerId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Malzemeler malzeme)
        {
            var result = _malzemelerService.Add(malzeme);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Malzemeler malzeme)
        {
            var result = _malzemelerService.Update(malzeme);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Malzemeler malzeme)
        {
            var result = _malzemelerService.Delete(malzeme);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
    
}

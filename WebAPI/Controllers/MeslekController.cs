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
    public class MeslekController : ControllerBase
    {
        private IMeslekService _meslekService;

        public MeslekController(  IMeslekService meslekService)
        {
            _meslekService = meslekService;
           
        }

        [HttpGet("getall")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {
            
            var result = _meslekService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            

            return BadRequest(result.Message);
        }

        

        [HttpGet("getbyid")]
        public IActionResult GetById(int meslekId)
        {
            var result = _meslekService.GetById(meslekId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Meslekler meslek)
        {
            var result = _meslekService.Add(meslek);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Meslekler meslek)
        {
            var result = _meslekService.Update(meslek);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Meslekler meslek)
        {
            var result = _meslekService.Delete(meslek);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
    
}

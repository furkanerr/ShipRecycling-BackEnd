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
    public class ResimController : ControllerBase
    {
        private IResimlerService _resimlerService;

        public ResimController(IResimlerService resimlerService)
        {
            _resimlerService = resimlerService;
        }

        [HttpGet("getall")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {
            
            var result = _resimlerService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        

        [HttpGet("getbyid")]
        public IActionResult GetById(int resimId)
        {
            var result = _resimlerService.GetById(resimId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Resimler resim)
        {
            var result = _resimlerService.Add(resim);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Resimler resim)
        {
            var result = _resimlerService.Update(resim);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Resimler resim)
        {
            var result = _resimlerService.Delete(resim);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

    }
    }
}

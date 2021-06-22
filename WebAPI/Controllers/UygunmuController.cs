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
    public class UygunmuController : ControllerBase
    {
        private IUygunmuService _uygunmuService;

        public UygunmuController( IUygunmuService uygunmuService)
        {
            _uygunmuService = uygunmuService;
            
        }

        [HttpGet("getall")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {
            
            var result = _uygunmuService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            

            return BadRequest(result.Message);
        }

        

        [HttpGet("getbyid")]
        public IActionResult GetById(int uygunmuId)
        {
            var result = _uygunmuService.GetById(uygunmuId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Uygunmu uygunmu)
        {
            var result = _uygunmuService.Add(uygunmu);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Uygunmu uygunmu)
        {
            var result = _uygunmuService.Update(uygunmu);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Uygunmu uygunmu)
        {
            var result = _uygunmuService.Delete(uygunmu);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

    }
    
}


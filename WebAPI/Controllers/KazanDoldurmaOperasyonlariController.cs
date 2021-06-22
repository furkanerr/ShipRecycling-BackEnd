using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    namespace WebAPI.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class KazanDoldurmaOperasyonlariController : ControllerBase
        {
            private IKazanDoldurmaOPerasyonlariService _kazanDoldurmaOPerasyonlariService;

            public  KazanDoldurmaOperasyonlariController(IKazanDoldurmaOPerasyonlariService kazanDoldurmaOPerasyonlariService)
            {
                _kazanDoldurmaOPerasyonlariService = kazanDoldurmaOPerasyonlariService;

            }

            [HttpGet("getall")]
            //[Authorize(Roles = "Product.List")]
            public IActionResult GetList()
            {
            
                var result = _kazanDoldurmaOPerasyonlariService.GetList();
                if (result.Success)
                {
                    return Ok(result.Data);
                }
                
                return BadRequest(result.Message);
            }

        

            [HttpGet("getbyid")]
            public IActionResult GetById(int kazanDoldurmaOperasyonuId)
            {
                var result = _kazanDoldurmaOPerasyonlariService.GetById(kazanDoldurmaOperasyonuId);
                if (result.Success)
                {
                    return Ok(result.Data);
                }

                return BadRequest(result.Message);
            }

            [HttpPost("add")]
            public IActionResult Add(KazanDoldurmaOPerasyonlari kazanDoldurmaOPerasyonlari)
            {
                var result = _kazanDoldurmaOPerasyonlariService.Add(kazanDoldurmaOPerasyonlari);
                if (result.Success)
                {
                    return Ok(result.Message);
                }

                return BadRequest(result.Message);
            }

            [HttpPost("update")]
            public IActionResult Update(KazanDoldurmaOPerasyonlari kazanDoldurmaOPerasyonlari)
            {
                var result = _kazanDoldurmaOPerasyonlariService.Update(kazanDoldurmaOPerasyonlari);
                if (result.Success)
                {
                    return Ok(result.Message);
                }

                return BadRequest(result.Message);
            }

            [HttpPost("delete")]
            public IActionResult Delete(KazanDoldurmaOPerasyonlari kazanDoldurmaOPerasyonlari)
            {
                var result = _kazanDoldurmaOPerasyonlariService.Delete(kazanDoldurmaOPerasyonlari);
                if (result.Success)
                {
                    return Ok(result.Message);
                }

                return BadRequest(result.Message);
            }

        }
    
    }
}


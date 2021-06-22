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
        public class KaldirmaOperasyonlariPlanlariController : ControllerBase
        {
            private IKaldırmaOperasyonuPlanlariService _kaldırmaOperasyonuPlanlariService;

            public  KaldirmaOperasyonlariPlanlariController(IKaldırmaOperasyonuPlanlariService kaldırmaOperasyonuPlanlariService)
            {
                _kaldırmaOperasyonuPlanlariService = kaldırmaOperasyonuPlanlariService;
               
            }

            [HttpGet("getall")]
            //[Authorize(Roles = "Product.List")]
            public IActionResult GetList()
            {
            
                var result = _kaldırmaOperasyonuPlanlariService.GetList();
                if (result.Success)
                {
                    return Ok(result.Data);
                }
                
                return BadRequest(result.Message);
            }

        

            [HttpGet("getbyid")]
            public IActionResult GetById(int kaldirmaOperasyonuPlanId)
            {
                var result = _kaldırmaOperasyonuPlanlariService.GetById(kaldirmaOperasyonuPlanId);
                if (result.Success)
                {
                    return Ok(result.Data);
                }

                return BadRequest(result.Message);
            }

            [HttpPost("add")]
            public IActionResult Add(KaldirmaOperasyonuPlanlari kaldirmaOperasyonuPlanlari)
            {
                var result = _kaldırmaOperasyonuPlanlariService.Add(kaldirmaOperasyonuPlanlari);
                if (result.Success)
                {
                    return Ok(result.Message);
                }

                return BadRequest(result.Message);
            }

            [HttpPost("update")]
            public IActionResult Update(KaldirmaOperasyonuPlanlari kaldirmaOperasyonuPlanlari)
            {
                var result = _kaldırmaOperasyonuPlanlariService.Update(kaldirmaOperasyonuPlanlari);
                if (result.Success)
                {
                    return Ok(result.Message);
                }

                return BadRequest(result.Message);
            }

            [HttpPost("delete")]
            public IActionResult Delete(KaldirmaOperasyonuPlanlari kaldirmaOperasyonuPlanlari)
            {
                var result = _kaldırmaOperasyonuPlanlariService.Delete(kaldirmaOperasyonuPlanlari);
                if (result.Success)
                {
                    return Ok(result.Message);
                }

                return BadRequest(result.Message);
            }

        }
    
    }
}

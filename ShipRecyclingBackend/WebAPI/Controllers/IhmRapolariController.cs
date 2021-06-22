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
        public class IhmRapolariController : ControllerBase
        {
            private IIHMRapolariService _ıhmRapolariService;

            public IhmRapolariController(IIHMRapolariService ıhmRapolariService)
            {
                _ıhmRapolariService = ıhmRapolariService;
            }

            [HttpGet("getall")]
            //[Authorize(Roles = "Product.List")]
            public IActionResult GetList()
            {
            
                var result = _ıhmRapolariService.GetList();
                if (result.Success)
                {
                    return Ok(result.Data);
                }
                
                return BadRequest(result.Message);
            }

        

            [HttpGet("getbyid")]
            public IActionResult GetById(int ihmRaporId)
            {
                var result = _ıhmRapolariService.GetById(ihmRaporId);
                if (result.Success)
                {
                    return Ok(result.Data);
                }

                return BadRequest(result.Message);
            }

            [HttpPost("add")]
            public IActionResult Add(IHMRapolari ihmRapolari)
            {
                var result = _ıhmRapolariService.Add(ihmRapolari);
                if (result.Success)
                {
                    return Ok(result.Message);
                }

                return BadRequest(result.Message);
            }

            [HttpPost("update")]
            public IActionResult Update(IHMRapolari ihmRapolari)
            {
                var result = _ıhmRapolariService.Update(ihmRapolari);
                if (result.Success)
                {
                    return Ok(result.Message);
                }

                return BadRequest(result.Message);
            }

            [HttpPost("delete")]
            public IActionResult Delete(IHMRapolari ihmRapolari)
            {
                var result = _ıhmRapolariService.Delete(ihmRapolari);
                if (result.Success)
                {
                    return Ok(result.Message);
                }

                return BadRequest(result.Message);
            }

        }
    
    }
}

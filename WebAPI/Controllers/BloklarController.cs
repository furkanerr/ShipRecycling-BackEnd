using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BloklarController : ControllerBase
    {
        private IBloklarService _bloklarService;

        public BloklarController(IBloklarService bloklarService)
        {
            _bloklarService = bloklarService;
        }

        [HttpGet("getall")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {

            var result = _bloklarService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int blokId)
        {
            var result = _bloklarService.GetById(blokId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Bloklar blok)
        {
            var result = _bloklarService.Add(blok);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Bloklar blok)
        {
            var result = _bloklarService.Update(blok);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Bloklar blok)
        {
            var result = _bloklarService.Delete(blok);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

    }
}
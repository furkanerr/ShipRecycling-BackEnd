using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DengeController : ControllerBase
    {
        private IDengeService _dengeService;

        public DengeController(IDengeService dengeService)
        {
            _dengeService = dengeService;
        }

        [HttpGet("getall")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {

            var result = _dengeService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int dengeId)
        {
            var result = _dengeService.GetById(dengeId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Denge denge)
        {
            var result = _dengeService.Add(denge);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Denge denge)
        {
            var result = _dengeService.Update(denge);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Denge denge)
        {
            var result = _dengeService.Delete(denge);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

    }
}

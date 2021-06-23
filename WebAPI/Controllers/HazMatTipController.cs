using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HazMatTipController : ControllerBase
    {
        private IHazMatTipiService _hazMatTipiService;

        public HazMatTipController(IHazMatTipiService hazMatTipiService)
        {
            _hazMatTipiService = hazMatTipiService;

        }

        [HttpGet("getall")]

        public IActionResult GetList()
        {

            var result = _hazMatTipiService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int hazMatTipId)
        {
            var result = _hazMatTipiService.GetById(hazMatTipId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(HazMatTipi hazMatTip)
        {
            var result = _hazMatTipiService.Add(hazMatTip);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(HazMatTipi hazMatTip)
        {
            var result = _hazMatTipiService.Update(hazMatTip);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(HazMatTipi hazMatTip)
        {
            var result = _hazMatTipiService.Delete(hazMatTip);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

    }
}
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HazMatController : ControllerBase
    {
        private IHazMatService _hazMatService;

        public HazMatController(IHazMatService hazMatService)
        {
            _hazMatService = hazMatService;
        }

        [HttpGet("getall")]

        public IActionResult GetList()
        {

            var result = _hazMatService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyhazmattip")]
        public IActionResult GetByHazMatTipId(int hazMatTipId)
        {
            var result = _hazMatService.GetListByHazMatTipi(hazMatTipId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int hazMatId)
        {
            var result = _hazMatService.GetById(hazMatId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(HazMat hazMat)
        {
            var result = _hazMatService.Add(hazMat);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(HazMat hazMat)
        {
            var result = _hazMatService.Update(hazMat);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(HazMat hazMat)
        {
            var result = _hazMatService.Delete(hazMat);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

    }
}
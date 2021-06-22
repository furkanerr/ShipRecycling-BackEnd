using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GemiTipleriController : ControllerBase
    {
        private IGemiTipleriService _gemiTipleriService;

        public GemiTipleriController(IGemiTipleriService gemiTipleriService)
        {
            _gemiTipleriService = gemiTipleriService;
        }

        [HttpGet("getall")]

        public IActionResult GetList()
        {

            var result = _gemiTipleriService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int gemiTipiId)
        {
            var result = _gemiTipleriService.GetById(gemiTipiId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(GemiTipleri gemiTipleri)
        {
            var result = _gemiTipleriService.Add(gemiTipleri);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(GemiTipleri gemiTipleri)
        {
            var result = _gemiTipleriService.Update(gemiTipleri);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(GemiTipleri gemiTipleri)
        {
            var result = _gemiTipleriService.Delete(gemiTipleri);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

    }
}
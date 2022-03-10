using Microsoft.AspNetCore.Mvc;

namespace Swashbuckle.AspNetCore.CrashDemo.Crash
{
    [ApiController]
    [Route("[controller]")]
    public class CrashController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(CrashObject), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(new CrashObject(new Dictionary<CrashEnum, string>()));
        }
    }
}
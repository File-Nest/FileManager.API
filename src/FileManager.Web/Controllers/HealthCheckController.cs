using Microsoft.AspNetCore.Mvc;

namespace FileManager.Web.Controllers
{
    [ApiController]
    [Route("health")]
    public class HealthCheckController : ControllerBase
    {
        public HealthCheckController() { }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { status = "API Working..." });
        }
    }
}

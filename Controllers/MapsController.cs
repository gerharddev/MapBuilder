using Microsoft.AspNetCore.Mvc;

namespace MapBuilder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MapsController : ControllerBase
    {

        private readonly ILogger<MapsController> _logger;

        public MapsController(ILogger<MapsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "GPXFile";
        }
    }
}
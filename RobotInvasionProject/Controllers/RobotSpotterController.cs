using Microsoft.AspNetCore.Mvc;

namespace RobotInvasionProjectApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RobotSpotterController : ControllerBase // Maps a request to a response
    {
       

        private readonly ILogger<RobotSpotterController> _logger;

        public RobotSpotterController(ILogger<RobotSpotterController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "RobotSpotted")]
        public string Get()
        {

            return "Paramatta River";
        }

        [HttpPost(Name = "RobotSpotted")]
        public string Post(Location locationName)
        {
            _logger.Log(LogLevel.Information, new EventId(), null, "Location name sent:" + locationName.Name, null);
            return locationName.Name;
            
        }

      
    }
}
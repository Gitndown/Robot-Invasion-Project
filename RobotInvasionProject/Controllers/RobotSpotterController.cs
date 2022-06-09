using Microsoft.AspNetCore.Mvc;
using RobotInvasionProjectApi.Services;

namespace RobotInvasionProjectApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RobotSpotterController : ControllerBase // Maps a request to a response
    {
       

        private readonly ILogger<RobotSpotterController> _logger;
        private readonly LocationService _service;

        public RobotSpotterController(LocationService service, ILogger<RobotSpotterController> logger)
        {
            _logger = logger;
            _service = service; // Injected LocationService into the constructor
        }

        [HttpGet(Name = "RobotSpotted")]
        public string Get()
        {
            
            string location = "this place";
            _logger.Log(LogLevel.Information, new EventId(), null, "Location name received:" + location, null);
            return location;
        }

        [HttpPost(Name = "RobotSpotted")]
        public string Post(Location locationName)
        {
            _logger.Log(LogLevel.Information, new EventId(), null, "Location name sent:" + locationName.Name, null);
            return locationName.Name;
            
        }

      
    }
}
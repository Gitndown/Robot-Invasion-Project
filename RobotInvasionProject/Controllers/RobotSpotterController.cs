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
            _service = service; // Injected our LocationService class into the constructor
        }

        [HttpGet(Name = "WaterSourceFound")] // GET ENDPOINT- hardcoded location to practise with endpoints 
        public string Get()
        {
            
            string location = "this place";
            _logger.Log(LogLevel.Information, new EventId(), null, "Location name received:" + location, null);
            return location; // practising with the logger. 
        }

        [HttpPost(Name = "RobotSpotted")] // POST ENDPOINT- user needs to give us the location
        public string Post(Location locationName)
        {
            _logger.Log(LogLevel.Information, new EventId(), null, "Location name sent:" + locationName.Name, null);
            // practising with the logger.
            return locationName.Name;
            
        }

        // Having trouble working out how to return the water location to the user based off of the location

      
    }
}
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

        [HttpPost(Name = "RobotSpotted")]
        public string Post(Location locationName)
        {
            
            return locationName.Name;
        }

      
    }
}
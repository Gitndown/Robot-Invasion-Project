using Microsoft.AspNetCore.Mvc;
using RobotInvasionProjectApi.Services;
using System.Text.Json;

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
            
            Location thisPlace = new Location();
            _logger.Log(LogLevel.Information, new EventId(), null, "Location name received:" + thisPlace.Latitude + thisPlace.Longitude, null);
            return thisPlace.Name; // practising with the logger. 
        }



        [HttpPost(Name = "RobotSpotted")] // POST ENDPOINT- user needs to give us the location
        public async Task<string> Post(Location location)
        {
            try
            {
                _logger.Log(LogLevel.Information, new EventId(), null, "Location name sent:" + location.Name, null);
                // practising with the logger.

                var x = await _service.GetNearestWaterSource(location);
                JsonSerializer.Serialize(x);
                Class1[] xDeSerialising = JsonSerializer.Deserialize<Class1[]>(x);

                return $"The nearest Body of water to {location.Name} is {xDeSerialising[0].display_name}";
            }

            catch (Exception ex)
            {
                throw new Exception("Result not found");
            }
        }

        // Having trouble working out how to return the water location to the user based off of the location

      
    }
}
namespace RobotInvasionProjectApi.Services
{
    public class LocationService
    {
        private HttpClient _httpClient;


        public LocationService (HttpClient client)
        {
            _httpClient = client;
            client.DefaultRequestHeaders.Add("User-Agent", "C# App"); // this is a requirement to access the API
            
        }

        public async Task <string> GetNearestWaterSource( Location location)
        {
            string url = $"https://nominatim.openstreetmap.org/details.php?osmtype=R&osmid=2345365&class=natural&addressdetails=1&hierarchy=0&group_hierarchy=1&polygon_geojson=1&format=json";
            HttpResponseMessage y =  await _httpClient.GetAsync(url);

            return await y.Content.ReadAsStringAsync();
        }


    }
    
}

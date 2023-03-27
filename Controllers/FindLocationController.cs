using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using John_Høeg_opgave_4._1.Models;
using Newtonsoft.Json;

namespace John_Høeg_opgave_4._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FindLocationController : ControllerBase
    {
        [HttpGet]
        public List<string> Get(string road, string kommune)
        {
            var jsonFilePath = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class001File.json";
            var jsonString = System.IO.File.ReadAllText(jsonFilePath);
            var jsonList = JsonConvert.DeserializeObject<List<SearchAllRoadNames>>(jsonString);
            // Filter the list based on the specified type and road name filter
            var result = jsonList.Where(x => x.roadCode == road && x.kommuneCode == kommune).Select(x => x.roadName).ToList();
            return result;
        }
    }
}

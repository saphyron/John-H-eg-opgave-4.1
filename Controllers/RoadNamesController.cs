using John_Høeg_opgave_4._1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace John_Høeg_opgave_4._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoadNamesController : ControllerBase
    {
        [HttpGet]
        public List<string> Get(string value)
        {
            var jsonFilePath = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class001File.json";
            var jsonString = System.IO.File.ReadAllText(jsonFilePath);
            var jsonList = JsonConvert.DeserializeObject<List<SearchAllRoadNames>>(jsonString);
            // Filter the list based on the specified type and road name filter
            string roadNameFilter = value;
            var filteredList = jsonList.Where(x => x.roadName.StartsWith(roadNameFilter)).Select(x => x.roadName).ToList();
            return filteredList;
        }
    }
}

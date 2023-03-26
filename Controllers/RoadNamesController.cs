using John_Høeg_opgave_4._1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace John_Høeg_opgave_4._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoadNamesController : ControllerBase
    {
        [HttpGet]
        public SearchAllRoadNames Get(string value)
        {
            SearchAllRoadNames result = new(value);
            return result;
        }
    }
}

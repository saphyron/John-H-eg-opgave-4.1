using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using John_Høeg_opgave_4._1.Models;

namespace John_Høeg_opgave_4._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FindLocationController : ControllerBase
    {
        [HttpGet]
        public SearchKommuneKodeAndVejKode Get(string value)
        {
            SearchKommuneKodeAndVejKode result = new(value);
            return result;
        }
    }
}

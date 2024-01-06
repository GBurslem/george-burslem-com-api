using Microsoft.AspNetCore.Mvc;

namespace GeorgeBurslemComApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreetingController : ControllerBase{
        [HttpGet]
        public ActionResult<string> Get(){
            return Ok("Speaking to you from ASP .NET Core Web API!");
        }
    }
} 
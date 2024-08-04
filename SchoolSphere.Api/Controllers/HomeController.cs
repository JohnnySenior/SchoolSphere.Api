
using Microsoft.AspNetCore.Mvc;

namespace SchoolSphere.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get() =>
            "Hello Mario, Princess is in another castle.";
    }
}


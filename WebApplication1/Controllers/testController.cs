using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        [HttpGet("SayHello")]
        public string Get(string name)
        {
            return "111Xin chao tk lol " + name;
        }
        [HttpPost("AddName")]
        public string AddName(string name)
        {
            return "Add rồi: " + name;
        }
    }
}

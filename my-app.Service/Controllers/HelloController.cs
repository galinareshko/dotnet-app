using Microsoft.AspNetCore.Mvc;

namespace my_app.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        [Route("hello4")]
        public IActionResult GetHello()
        {
            return Ok("Hello, World!");
        }

        [HttpGet]
        [Route("hello3")]
        public IActionResult GetHello()
        {
            return Ok("Hello, Maxim!");
        }
    }
}

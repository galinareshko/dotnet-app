using Microsoft.AspNetCore.Mvc;

namespace my_app.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        [Route("hello4")]
        public IActionResult GetHello4()
        {
            return Ok("Hello, World!");
        }

        [HttpGet]
        [Route("hello3")]
        public IActionResult GetHello3()
        {
            return Ok("Hello, Maxim!");
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace my_app.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
         static HttpClient client = new HttpClient(); 
         
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

         [HttpGet]
        [Route("externalcall")]
        public async Task<IActionResult> ExternalCall()
        {
            const string url = "https://dotnet-app-user3-user3-application.apps.cluster-5shjw.dynamic.redhatworkshops.io/Hello/test";

           try{
 HttpResponseMessage response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            return Ok(response.Content.ReadAsStringAsync());

           }
           catch(Exception ex)
           {
            return Ok(ex.Message);
           }
        }
    }
}

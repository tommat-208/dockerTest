using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dockerTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringController : Controller
    {
        [HttpGet]
        public IActionResult GetString()
        {
            return Ok("ciao sono l'api");
        }

        
    }
}

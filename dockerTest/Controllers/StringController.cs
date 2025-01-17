using System.Reflection;
using System.Xml.Schema;
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

        [HttpGet("version")]
        public IActionResult GetVersion()
        {
            
            return Ok();
        }

        
    }
}

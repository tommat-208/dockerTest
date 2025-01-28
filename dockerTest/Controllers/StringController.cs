using System.Diagnostics;
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
            return Ok("Ciao sono l'api!!!");

        }

        [HttpGet("version")]
        public IActionResult GetVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.ProductVersion;

            return Ok(version);
        }

        
    }
}

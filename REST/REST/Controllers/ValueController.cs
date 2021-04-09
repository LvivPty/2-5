using Microsoft.AspNetCore.Mvc;

namespace REST.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValueController : ControllerBase
    {
        [HttpGet]
        public string Ping()
            => "localhost";

        [HttpGet]
        public string Echo(string text)
            => $"Its echo from server with text: { text }";

        [HttpPost]
        public bool Login(string name, string pass)
            => name == "rostyk" && pass == "111";
    }
}

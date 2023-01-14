
using LoggingDemo.Logging;
using Microsoft.AspNetCore.Mvc;

namespace LoggingDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly Logger logger;
        public TestController(Logger _logger)
        {
            logger = _logger;   
        }

        [HttpGet]
        [Route("login")]
        public string Login()
        {
            _ = logger.Log("login succesfull");
            return "You have logged in successfully";
        }
    }
}

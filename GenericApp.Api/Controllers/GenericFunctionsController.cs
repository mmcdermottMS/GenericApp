using GenericApp.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GenericWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericFunctionsController : Controller
    {
        private readonly ILogger<GenericFunctionsController> _logger;

        public GenericFunctionsController(ILogger<GenericFunctionsController> logger)
        {
            _logger = logger;
        }

        [Route("FunctionA")]
        [HttpGet]
        public string GetFunctionA()
        {
            _logger.LogInformation("Function A Called");

            return $"Function A Called at {DateTime.UtcNow} UTC";
        }

        [Route("FunctionB")]
        [HttpGet]
        public string GetFunctionB()
        {
            _logger.LogInformation("Function B Called");

            return $"Function B Called at {DateTime.UtcNow} UTC";
        }
    }
}

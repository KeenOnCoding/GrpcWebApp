using GrpcWebApp.Client.Services;
using Microsoft.AspNetCore.Mvc;

namespace GrpcWebApp.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly IGreeterService _greeterService;
        public HelloController(IGreeterService greeterService)
        {
            _greeterService = greeterService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _greeterService.Get(); 
            
            if (result == null) { BadRequest(); }
            return Ok(result);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> logger;

        public PingController(ILogger<WeatherForecastController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("/ping")]
        public int GetPing()
        {
            logger.LogError("Test log!");
            return 1;
        }
    }
}

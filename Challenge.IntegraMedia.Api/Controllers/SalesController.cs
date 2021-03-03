using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.IntegraMedia.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalesController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public SalesController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
    }
}

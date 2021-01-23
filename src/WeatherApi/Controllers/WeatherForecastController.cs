using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<WeatherForecast>> Get()
        {
            var rng = new Random();
            var result = new List<WeatherForecast>();

            Enumerable.Range(1, 20)
                .ToList()
                .ForEach(x =>
                {
                    _logger.LogInformation("Index: {index}", x);
                    result.Add(new WeatherForecast
                    {
                        Date = DateTime.Now.AddDays(-1 * x),
                        Summary = Summaries[rng.Next(Summaries.Length)],
                        TemperatureC = rng.Next(-20, 55)
                    });
                });

            return Ok(result);
        }
    }
}

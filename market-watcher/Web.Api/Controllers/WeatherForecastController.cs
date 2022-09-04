using Microsoft.AspNetCore.Mvc;
using DataService;
using IDataService;
using Models.Models;

namespace Web.Api.Controllers
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
        private readonly IMainService _mainService;


        public WeatherForecastController(ILogger<WeatherForecastController> logger, MainService mainService)
        {
            _logger = logger;
            this._mainService = mainService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("Test")]
        public bool Test()
        {
            return _mainService.Test();
            
        }

        [HttpGet("GetAllSiteInfo")]
        public List<TradingSite> GetAllSiteInfo()
        {
            return _mainService.SiteInfo();
        }

        [HttpPost]
        public string ApiStatus(string siteName)
        {
            return _mainService.ApiStatus(siteName);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using DataService;
using IDataService;
using Models.Models;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly ILogger<StatusController> _logger;
        private readonly IMainService _mainService;

        public StatusController(ILogger<StatusController> logger, IMainService mainService)
        {
            _logger = logger;
            _mainService = mainService;
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

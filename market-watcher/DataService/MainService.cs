using Models.Models;
using IDataService;
using IDataAccess;

namespace DataService
{
    public class MainService : IMainService
    {
        private readonly IMainDataAccess _mainDataAccess;

        public bool Test()
        {
            return true;
        }

        public List<TradingSite> SiteInfo()
        {
            return _mainDataAccess.SiteInfo();
        }
    }
}
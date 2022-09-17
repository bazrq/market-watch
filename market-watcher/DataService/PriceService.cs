using Models.Models;
using IDataService;
using IDataAccess;
using System.Linq;
using System.Net;
namespace DataService
{
    public class PriceService : IPriceService
    {
        private readonly IMainDataAccess _mainDataAccess;

        public PriceService(IMainDataAccess _mainDataAccess)
        {
            this._mainDataAccess = _mainDataAccess;
        }

    }
}

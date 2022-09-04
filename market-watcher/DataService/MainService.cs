using Models.Models;
using IDataService;
using IDataAccess;
using System.Linq;
using System.Net;

namespace DataService
{
    public class MainService : IMainService
    {
        private readonly IMainDataAccess _mainDataAccess;

        public MainService(IMainDataAccess _mainDataAccess)
        {
            this._mainDataAccess = _mainDataAccess;
        }

        public bool Test()
        {
            return true;
        }

        public List<TradingSite> SiteInfo()
        {
            return _mainDataAccess.SiteInfo();
        }

        public string ApiStatus(string siteName)
        {
            var url = "";
            foreach(var item in SiteInfo())
            {
                
                if (item.Name == siteName)
                {
                    url = item.ApiStatus;
                    break;
                }

                return "Invalid Site";
                                
            }

            HttpCallAsync(url);



            return "mkaing call to:"+url;
        }

        public async Task<HttpResponseMessage> HttpCallAsync(string url)
        {
            using var client = new HttpClient();

            var result = await client.GetAsync(url);

            return result;
        }

    }
}
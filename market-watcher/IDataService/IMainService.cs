using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataService
{
    public interface IMainService
    {
        public bool Test();

        public List<TradingSite> SiteInfo();

        public string ApiStatus(string siteName);
    }
}

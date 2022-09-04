using Models;
using Models.Models;

namespace DataAccess

{
    public class MainDataAccess
    {
        public List<TradingSite> SiteInfo()
        {
            using (var context = new aspnetdotnetApp6A130FB599AC4AF58FCD86B78C5EA630Context())
            {
                var siteInfo = context.TradingSites.ToList();
                return siteInfo;
            }
        }

    }
}
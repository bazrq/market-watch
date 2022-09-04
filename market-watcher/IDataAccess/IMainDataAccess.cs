using Models.Models;

namespace IDataAccess
{
    public interface IMainDataAccess
    {
        public List<TradingSite> SiteInfo();
    }
}
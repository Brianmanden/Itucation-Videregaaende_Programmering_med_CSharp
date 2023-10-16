using System.Web;
using System.Web.Mvc;

namespace Dag16_Bush_craft_hobby
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace L03_Bootstrap_HW1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

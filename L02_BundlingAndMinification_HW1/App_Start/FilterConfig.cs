using System.Web;
using System.Web.Mvc;

namespace L02_BundlingAndMinification_HW1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

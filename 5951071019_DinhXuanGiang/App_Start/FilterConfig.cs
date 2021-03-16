using System.Web;
using System.Web.Mvc;

namespace _5951071019_DinhXuanGiang
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace Assignment_2_ASP_MVC_Restaurant
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

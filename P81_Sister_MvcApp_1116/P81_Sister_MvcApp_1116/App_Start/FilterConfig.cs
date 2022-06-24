using System.Web;
using System.Web.Mvc;

namespace P81_Sister_MvcApp_1116
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
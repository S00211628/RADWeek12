using System.Web;
using System.Web.Mvc;

namespace Week12MVCHealthApp2223.S00211628
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

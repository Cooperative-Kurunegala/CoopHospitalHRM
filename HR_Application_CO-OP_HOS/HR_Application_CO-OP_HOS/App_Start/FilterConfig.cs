using System.Web;
using System.Web.Mvc;

namespace HR_Application_CO_OP_HOS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

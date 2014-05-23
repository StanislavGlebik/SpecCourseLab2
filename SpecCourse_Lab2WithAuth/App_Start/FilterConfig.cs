using System.Web;
using System.Web.Mvc;

namespace SpecCourse_Lab2WithAuth
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
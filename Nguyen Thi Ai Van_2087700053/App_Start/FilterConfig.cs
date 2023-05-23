using System.Web;
using System.Web.Mvc;

namespace Nguyen_Thi_Ai_Van_2087700053
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace E_BookStore.AuthorBloggerPlanel
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

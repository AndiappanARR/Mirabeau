using System.Web;
using System.Web.Mvc;

namespace Mirabeau.Filters
{
    public class JsonFeedFilter : ActionFilterAttribute, IActionFilter
    {
        /// <summary>
        /// TO set response header from-feed is coming through json
        /// </summary>
        /// <param name="filterContext"></param>
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Response.AddHeader("from-feed", "application/json"); 
        }
    }
}
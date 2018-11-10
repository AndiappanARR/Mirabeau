using Mirabeau.Filters;
using System.Web.Mvc;

namespace Mirabeau.Controllers
{

    public class CompareController : BaseController
    {
        /// <summary>
        /// Index
        /// </summary>
        /// <param name="iata"></param>
        /// <returns></returns>
        [JsonFeedFilter]
        public ActionResult Index(string iata)
        {            
            return View(IAirportBusiness.GetCompareModel(iata));
        }
    }
}
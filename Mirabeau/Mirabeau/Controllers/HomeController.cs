using Mirabeau.Business.IRepository;
using Mirabeau.Filters;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Mirabeau.Controllers
{
    /// <summary>
    /// HomeController
    /// </summary>
    public class HomeController : BaseController
    {
        /// <summary>
        /// Index
        /// </summary>
        /// <param name="ccode"></param>
        /// <param name="pno"></param>
        /// <returns></returns>
        [JsonFeedFilter]
        public async Task<ActionResult> Index(string ccode, string pno= "1")
        {
            return View(await IAirportBusiness.GetAirportGlobalModel(ccode, pno));
        }     
    }
}
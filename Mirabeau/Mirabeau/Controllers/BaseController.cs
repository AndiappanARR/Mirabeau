using Mirabeau.Business.IRepository;
using Mirabeau.Unity.Helpers;
using System.Web.Mvc;

namespace Mirabeau.Controllers
{
    /// <summary>
    /// BaseController
    /// </summary>
    public class BaseController : Controller
    {
        /// <summary>
        /// IAirportBusiness
        /// </summary>
        public IAirportBusiness IAirportBusiness = UnityManager.Resolve<IAirportBusiness>();
       
    }
}
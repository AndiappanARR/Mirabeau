using Mirabeau.Model.Models;
using System.Threading.Tasks;

namespace Mirabeau.Business.IRepository
{
    /// <summary>
    /// IAirportBusiness
    /// </summary>
    public interface IAirportBusiness
    {
        /// <summary>
        /// GetAirportGlobalModel
        /// </summary>
        /// <param name="ccode"></param>
        /// <param name="pno"></param>
        /// <returns></returns>
        Task<AirportGlobalServiceModel> GetAirportGlobalModel(string ccode, string pno);

        /// <summary>
        /// GetCompareModel
        /// </summary>
        /// <param name="iata"></param>
        /// <returns></returns>
        AirportCompareModel GetCompareModel(string iata);
     }
}

using Mirabeau.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mirabeau.Service.IServices
{
    /// <summary>
    /// IJsonServices
    /// </summary>
    public interface IJsonServices
    {
        /// <summary>
        /// BasicCallAsync
        /// </summary>
        /// <returns></returns>
        Task<List<AirportServiceModel>> BasicCallAsync();

        /// <summary>
        /// GetServiceModel
        /// </summary>
        /// <returns></returns>
        List<AirportServiceModel> GetServiceModel();
    }
}

using Mirabeau.Common.Common;
using Mirabeau.Model.Models;
using Mirabeau.Service.Helper;
using Mirabeau.Service.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mirabeau.Service.Services
{
    /// <summary>
    /// JsonServices
    /// </summary>
    public class JsonServices : IJsonServices
    {
        /// <summary>
        /// BasicCallAsync
        /// </summary>
        /// <returns></returns>
        public async Task<List<AirportServiceModel>> BasicCallAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var content = await client.GetStringAsync(Constants.JsonServiceUrl);
                    var json = JsonConvert.DeserializeObject<List<AirportServiceModel>>(content);
                    return json;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        /// <summary>
        /// GetServiceModel
        /// </summary>
        /// <returns></returns>
        public List<AirportServiceModel> GetServiceModel()
        {
            return SignleTon.AirportData;
        }
    }
}

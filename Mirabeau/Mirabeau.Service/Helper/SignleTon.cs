using Mirabeau.Model.Models;
using Mirabeau.Service.IServices;
using Mirabeau.Unity.Helpers;
using System.Collections.Generic;

namespace Mirabeau.Service.Helper
{
    /// <summary>
    /// SignleTon
    /// </summary>
    public static class SignleTon
    {
        /// <summary>
        /// AirportData
        /// </summary>
        public static List<AirportServiceModel> AirportData { get; set; }

        /// <summary>
        /// ActivateSigleTonData
        /// </summary>
        public static void ActivateSigleTonData()
        {
           
            IJsonServices jsServices = UnityManager.Resolve<IJsonServices>();
            var model = jsServices.BasicCallAsync().GetAwaiter().GetResult();

            AirportData = model;
        }

    }
}


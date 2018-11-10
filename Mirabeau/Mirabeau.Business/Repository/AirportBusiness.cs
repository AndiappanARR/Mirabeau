using Mirabeau.Business.IRepository;
using Mirabeau.Common.Common;
using Mirabeau.Common.Helper;
using Mirabeau.Model.Models;
using Mirabeau.Service.Helper;
using Mirabeau.Service.IServices;
using Mirabeau.Unity.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Mirabeau.Business.Repository
{
    /// <summary>
    /// AirportBusiness
    /// </summary>
    public class AirportBusiness : IAirportBusiness
    {
        /// <summary>
        /// jsServices
        /// </summary>
        IJsonServices jsServices = UnityManager.Resolve<IJsonServices>();

        /// <summary>
        /// GetAirportGlobalModel
        /// </summary>
        /// <param name="ccode"></param>
        /// <param name="pno"></param>
        /// <returns></returns>
        public async Task<AirportGlobalServiceModel> GetAirportGlobalModel(string ccode, string pno)
        {
            var model = jsServices.GetServiceModel();

            var modelContry = model.ToList().Select(x => x.Continent).Distinct();

            AirportGlobalServiceModel result = new AirportGlobalServiceModel()
            {
                // Get Country list
                CountryCollectionModel = model.Select(c => c.Continent).Distinct().Select(x => new CountryCollectionServiceModel()
                {
                    CountryCode = x,
                    CountryDisplayName = x
                }),
                // Get Product
            };

            //Generic details
            result.PageNumber = (string.IsNullOrEmpty(pno)) ? 1 : Convert.ToInt32(pno);
            result.RowsCount = Convert.ToInt32(Constants.TablePageRowCount);


            // Get airport based on country
            string countryCode = ccode;
            result.SelectedCountryCode = countryCode;
            if (!string.IsNullOrEmpty(countryCode))
            {
                result.AirportViewModel = model.Where(x => x.Continent.Equals(countryCode, StringComparison.InvariantCultureIgnoreCase)).ToList();
            }
            else
            {
                result.AirportViewModel = model;
            }

            //Pagination logics
            result.TotalRecords = result.AirportViewModel.ToList().Count;
            result.AirportViewModel = result.AirportViewModel.Skip(result.RowsCount * result.PageNumber).Take(result.RowsCount);
            result.TotalPaginationNumber = result.TotalRecords / result.RowsCount;
            return result;
        }

        /// <summary>
        /// GetCompareModel
        /// </summary>
        /// <param name="iata"></param>
        /// <returns></returns>
        public AirportCompareModel GetCompareModel(string iata)
        {
            var model = jsServices.GetServiceModel();

            AirportCompareModel result = new AirportCompareModel();

            result.IATAModel = SignleTon.AirportData.Select(c => c.Iata).Distinct().Select(x => new IATAModel()
            {
                IATACode = x,
                IATADisplayName = x
            });

            string iataC = iata;

            if (!string.IsNullOrEmpty(iataC))
            {
                result.SelectedIATA = iataC.Split(',').ToList();
                result.AirportViewModel = model.Where(x => result.SelectedIATA.Contains(x.Iata));

                double lat1 = Convert.ToDouble(result.AirportViewModel.ToList().First().Lat);
                double lat2 = Convert.ToDouble(result.AirportViewModel.ToList().Last().Lat);
                double lon1 = Convert.ToDouble(result.AirportViewModel.ToList().First().Lon);
                double lon2 = Convert.ToDouble(result.AirportViewModel.ToList().Last().Lon);

                result.DistanceType = "Kilometers";
                //Distance calculator
                result.Distance = GeoHelper.DistanceTo(lat1, lon1, lat2, lon2, result.DistanceType);
            }
            else
            {
                result.AirportViewModel = null;
            }



            return result;
        }
    }
}

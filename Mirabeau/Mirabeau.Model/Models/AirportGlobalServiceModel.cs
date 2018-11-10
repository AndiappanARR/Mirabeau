using System.Collections.Generic;

namespace Mirabeau.Model.Models
{
    /// <summary>
    /// AirportGlobalServiceModel
    /// </summary>
    public class AirportGlobalServiceModel
    {
        public IEnumerable<AirportServiceModel> AirportViewModel { get; set; }

        public IEnumerable<CountryCollectionServiceModel> CountryCollectionModel { get; set; }

        public string SelectedCountryCode { get; set; }

        public int PageNumber { get; set; }

        public int RowsCount { get; set; }

        public int TotalRecords { get; set; }

        public int TotalPaginationNumber { get; set; }

    }
}
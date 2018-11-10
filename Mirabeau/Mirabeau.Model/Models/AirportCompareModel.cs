using System.Collections.Generic;

namespace Mirabeau.Model.Models
{
    /// <summary>
    /// AirportCompareModel
    /// </summary>
    public class AirportCompareModel
    {
        public IEnumerable<AirportServiceModel> AirportViewModel { get; set; }

        public IEnumerable<IATAModel> IATAModel { get; set; }

        public IEnumerable<string> SelectedIATA { get; set; }

        public double Distance { get; set; }

        public string DistanceType { get; set; }

    }
}

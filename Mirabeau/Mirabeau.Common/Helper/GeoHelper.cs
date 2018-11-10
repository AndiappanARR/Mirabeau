using System;

namespace Mirabeau.Common.Helper
{
    /// <summary>
    /// GeoHelper
    /// </summary>
    public static class GeoHelper
    {
        /// <summary>
        /// Find distance by source and target latitudes and longtidudes
        /// </summary>
        /// <param name="lat1"></param>
        /// <param name="lon1"></param>
        /// <param name="lat2"></param>
        /// <param name="lon2"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        public static double DistanceTo(double lat1, double lon1, double lat2, double lon2, string unit = "Kilometers")
        {
            if (lat1 + lon1 == 0 || lat2 + lon2 == 0)
            {
                return 0;
            }

            double rlat1 = Math.PI * lat1 / 180;
            double rlat2 = Math.PI * lat2 / 180;
            double theta = lon1 - lon2;
            double rtheta = Math.PI * theta / 180;
            double dist =
                Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            switch (unit)
            {
                case "Kilometers": //Kilometers -> default
                    return dist * 1.609344;
                case "Nautical_Miles": //Nautical Miles 
                    return dist * 0.8684;
                case "Miles": //Miles
                    return dist;
            }

            return dist;
        }
    }
}

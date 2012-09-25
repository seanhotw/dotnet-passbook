using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passbook.Generator.Fields
{
    public class LocationField
    {
        public LocationField(double altitude, double latitude, double longitude, string releventText)
        {
            this.Altitude = altitude;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.ReleventText = releventText;
        }

        public LocationField(double latitude, double longitude, string releventText)
        {
          this.Latitude = latitude;
          this.Longitude = longitude;
          this.ReleventText = releventText;
        }

        public LocationField(double latitude, double longitude)
        {
          this.Latitude = latitude;
          this.Longitude = longitude;
        }

        public LocationField()
        { }

        public double? Altitude { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string ReleventText { get; set; }
    }
}

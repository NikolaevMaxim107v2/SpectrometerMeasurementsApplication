using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectrometerMeasurementsApplication.Classes
{
    public class Flight
    {
        private int _flightID;
        private int _profileID;

        public Flight(int flightID, int profileID)
        {
            _flightID = flightID;
            _profileID = profileID;
        }

        public int FlightID { get {  return _flightID; } set { _flightID = value; } }
        public int ProfileID { get { return _profileID; } set { _profileID = value; } }
    }
}

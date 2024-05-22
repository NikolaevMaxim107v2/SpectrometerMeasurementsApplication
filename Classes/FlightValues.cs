using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectrometerMeasurementsApplication.Classes
{
    public class FlightValues
    {
        private int _valuesID;
        private int _flightDistance;
        private int _flightHeight;
        private int _flightID;

        public FlightValues(int valuesID,  int flightDistance, int flightHeight, int flightID)
        {
            ValuesID = valuesID;
            FlightDistance = flightDistance;
            FlightHeight = flightHeight;
            FlightID = flightID;
        }

        public int ValuesID { get { return _valuesID; } set { _valuesID = value; } }
        public int FlightDistance { get {  return _flightDistance; } set { _flightDistance = value; } }
        public int FlightHeight {  get { return _flightHeight; } set { _flightDistance = value; } }
        public int FlightID { get { return _flightID; } set { _flightID =  value; } }
    }
}

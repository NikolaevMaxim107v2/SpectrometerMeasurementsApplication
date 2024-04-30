using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectrometerMeasurementsApplication.Classes
{
    public class Survey
    {
        private int _surveyID;
        private int _flightID;
        private int _operatorID;

        public Survey (int surveyID, int flightID, int operatorID)
        {
            _surveyID = surveyID;
            _flightID = flightID;
            _operatorID = operatorID;
        }
        
        public int SurveyID { get {  return _surveyID; } set { _surveyID = value; } }
        public int FlightID { get { return _flightID; } set { _flightID = value; } }
        public int OperatorID { get { return _operatorID; } set { _operatorID = value; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectrometerMeasurementsApplication.Classes
{
    public class SurveyValues
    {
        private int _valuesID;
        private int _surveyID;
        private int _picketID;
        private int _surveyScale;
        private int _radiationActivity;

        public SurveyValues(int valuesID, int surveyID, int picketID, int surveyScale, int radiationActivity)
        {
            ValuesID = valuesID;
            SurveyID = surveyID;
            PicketID = picketID;
            SurveyScale = surveyScale;
            RadiationActivity = radiationActivity;
        }

        public int ValuesID { get { return _valuesID; } set { _valuesID = value; } }
        public int SurveyID { get { return _surveyID; } set { _surveyID = value; } }
        public int PicketID { get { return _picketID; } set { _picketID = value; } }
        public int SurveyScale { get { return _surveyScale; } set { _surveyScale = value; } }
        public int RadiationActivity { get {  return _radiationActivity; } set { _radiationActivity = value; } }
    }
}

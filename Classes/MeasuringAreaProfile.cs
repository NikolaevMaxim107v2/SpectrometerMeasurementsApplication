using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectrometerMeasurementsApplication.Classes
{
    public class MeasuringAreaProfile
    {
        private int _profileID;
        private int _areaID;

        public MeasuringAreaProfile(int profileID, int areaID)
        {
            _profileID = profileID;
            _areaID = areaID;
        }

        public int ProfileID { get { return _profileID; } set { _profileID = value; } }
        public int AreaID { get { return _areaID; } set { _areaID = value; } }
    }
}

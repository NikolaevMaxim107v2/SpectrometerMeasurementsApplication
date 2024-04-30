using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectrometerMeasurementsApplication.Classes
{
    public class MeasuringArea
    {
        private int _areaID;
        private string _areaName;
        private int _projectID;

        public MeasuringArea(int areaID,  string areaName, int projectID)
        {
            _areaID = areaID;
            _areaName = areaName;
            _projectID = projectID;
        }

        public int AreaID { get { return _areaID; } set { _areaID = value; } }
        public string AreaName { get { return _areaName; } set { _areaName = value; } }
        public int ProjectID { get { return _projectID; } set { _projectID = value; } }
    }
}

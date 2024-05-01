using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectrometerMeasurementsApplication.Classes
{
    public class MeasuringAreaPointsCoords
    {
        private int _coordsID;
        private int _coordsX;
        private int _coordsY;
        private int _areaID;

        public MeasuringAreaPointsCoords(int coordsID,  int coordsX, int coordsY, int areaID)
        {
            _coordsID = coordsID;
            _coordsX = coordsX;
            _coordsY = coordsY;
            _areaID = areaID;
        }

        public int CoordsID { get { return _coordsID; } set { _coordsID = value; } }
        public int CoordsX { get {  return _coordsX; } set { _coordsX = value; } }
        public int CoordsY { get { return _coordsY; } set { _coordsY = value; } }
        public int AreaID { get { return _areaID; } set { _areaID = value; } }
    }
}
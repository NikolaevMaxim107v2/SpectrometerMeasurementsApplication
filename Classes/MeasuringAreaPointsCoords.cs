using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SpectrometerMeasurementsApplication.Classes
{
    public class MeasuringAreaPointsCoords
    {
        private int _coordsID;
        private decimal _coordsX;
        private decimal _coordsY;
        private int _areaID;

        public MeasuringAreaPointsCoords(int coordsID, decimal coordsX, decimal coordsY, int areaID)
        {
            CoordsID = coordsID;
            CoordsX = coordsX;
            CoordsY = coordsY;
            AreaID = areaID;
        }

        public int CoordsID { get { return _coordsID; } set { _coordsID = value; } }
        public decimal CoordsX { get {  return _coordsX; } set { _coordsX = value; } }
        public decimal CoordsY { get { return _coordsY; } set { _coordsY = value; } }
        public int AreaID { get { return _areaID; } set { _areaID = value; } }
    }
}
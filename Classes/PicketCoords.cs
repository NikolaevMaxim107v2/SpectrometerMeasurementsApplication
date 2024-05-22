using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectrometerMeasurementsApplication.Classes
{
    public class PicketCoords
    {
        private int _coordsID;
        private int _picketID;
        private decimal _coordsX;
        private decimal _coordsY;

        public PicketCoords(int coordsID, int picketID, decimal coordsX, decimal coordsY)
        {
            CoordsID = coordsID;
            PicketID = picketID;
            CoordsX = coordsX;
            CoordsY = coordsY;
        }

        public int CoordsID { get { return _coordsID; } set { _coordsID = value; } }
        public int PicketID { get { return _picketID; } set { _picketID = value; } }        
        public decimal CoordsX { get { return _coordsX; } set { _coordsX = value; } }
        public decimal CoordsY { get { return _coordsY; } set { _coordsY = value; } }
    }
}

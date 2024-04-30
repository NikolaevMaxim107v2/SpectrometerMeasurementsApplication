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
        private int _coordsX;
        private int _coordsY;

        public PicketCoords(int coordsID, int picketID, int coordsX, int coordsY)
        {
            _coordsID = coordsID;
            _picketID = picketID;
            _coordsX = coordsX;
            _coordsY = coordsY;
        }

        public int CoordsID { get { return _coordsID; } set { _coordsID = value; } }
        public int PicketID { get { return _picketID; } set { _picketID = value; } }        
        public int CoordsX { get { return _coordsX; } set { _coordsX = value; } }
        public int CoordsY { get { return _coordsY; } set { _coordsY = value; } }
    }
}

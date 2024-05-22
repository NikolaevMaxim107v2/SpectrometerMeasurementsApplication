using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectrometerMeasurementsApplication.Classes
{
    public class ProfilePointsCoords
    {
        private int _coordsID;
        private decimal _coordsX;
        private decimal _coordsY;
        private int _profileID;

        public ProfilePointsCoords(int coordsID, decimal coordsX, decimal coordsY, int profileID)
        {
            CoordsID = coordsID;
            CoordsX = coordsX;
            CoordsY = coordsY;
            ProfileID = profileID;
        }

        public int CoordsID {  get { return _coordsID; } set { _coordsID = value; } }
        public decimal CoordsX { get { return _coordsX; } set { _coordsX = value; } }
        public decimal CoordsY {  get { return _coordsY; } set { _coordsY = value; } }
        public int ProfileID { get { return _profileID; } set { _profileID = value; } }
    }
}

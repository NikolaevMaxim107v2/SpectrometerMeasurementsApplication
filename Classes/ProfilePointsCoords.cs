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
        private int _coordsX;
        private int _coordsY;
        private int _profileID;

        public ProfilePointsCoords(int coordsID, int coordsX, int coordsY, int profileID)
        {
            _coordsID = coordsID;
            _coordsX = coordsX;
            _coordsY = coordsY;
            _profileID = profileID;
        }

        public int CoordsID {  get { return _coordsID; } set { _coordsID = value; } }
        public int CoordsX { get { return _coordsX; } set { _coordsX = value; } }
        public int CoordsY {  get { return _coordsY; } set { _coordsY = value; } }
        public int ProfileID { get { return _profileID; } set { _profileID = value; } }
    }
}

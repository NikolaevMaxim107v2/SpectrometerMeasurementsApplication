using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectrometerMeasurementsApplication.Classes
{
    public class Picket
    {
        private int _picketID;
        private int _profileID;
        private int _operatorID;
    
        public Picket(int picketID, int profileID, int operatorID)
        {
            _picketID = picketID;
            _profileID = profileID;
            _operatorID = operatorID; 
        }

        public int PicketID { get {  return _picketID; } set { _picketID = value; } }
        public int ProfileID { get { return _profileID; } set { _profileID = value; } }
        public int OperatorID { get { return _operatorID; } set { _operatorID = value; } }
    }
}

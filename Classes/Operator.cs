using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectrometerMeasurementsApplication.Classes
{
    public class Operator
    {
        private int _operatorID;
        private string _operatorName;
        private string _operatorSurname;
        private string _phone;
        private string _email;

        public Operator(int operatorID, string operatorName, string operatorSurname, string phone, string email)
        {
            _operatorID = operatorID;
            _operatorName = operatorName;
            _operatorSurname = operatorSurname;
            _phone = phone;
            _email = email;
        }

        public int OperatorID { get { return _operatorID; } set { _operatorID = value; } }
        public string OperatorName { get { return _operatorName; } set { _operatorName = value; } }
        public string OperatorSurname { get { return _operatorSurname; } set { _operatorSurname = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
        public string Email { get { return _email; } set { _email = value; } }
    }
}

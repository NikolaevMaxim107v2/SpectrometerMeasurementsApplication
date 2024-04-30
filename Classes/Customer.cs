using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectrometerMeasurementsApplication.Classes
{
    public class Customer
    {
        private int _customerID;
        private string _name;
        private string _email;
        private string _phone;

        public Customer(int customerID, string name, string email, string phone)
        {
            _customerID = customerID;
            _name = name;
            _email = email;
            _phone = phone;
        }

        public int CustomerID { get => _customerID;  set { _customerID = value; } }
        public string CustomerName { get => _name; set { _name = value;} }
        public string Email { get => _email; set { _email = value; } }
        public string Phone { get => _phone; set { _phone = value; } }
    }
}

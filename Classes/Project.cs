using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectrometerMeasurementsApplication.Classes
{
    public class Project
    {
        private int _projectID;
        private string _projectName;
        private int _customerID;
        private string _projectAddress;
        private DateTime _acceptDate;
        private DateTime? _endDate;

        public Project(int projectID, string projectName, int customerID, string projectAddress, DateTime acceptDate, DateTime? endDate)
        {
            _projectID = projectID;
            _projectName = projectName;
            _customerID = customerID;
            _projectAddress = projectAddress;
            _acceptDate = acceptDate;
            _endDate = endDate;
        }

        public int ProjectID { get { return _projectID; } set { _projectID = value; } }
        public string ProjectName { get { return _projectName; } set { _projectName = value; } }
        public int CustomerID { get { return _customerID; } set { _customerID = value; } }
        public string ProjectAddress { get { return _projectAddress; } set { _projectAddress = value; } }
        public DateTime AcceptDate { get {  return _acceptDate; } set { _acceptDate = value; } }
        public DateTime? EndDate { get { return _endDate; } set { _endDate = value; } }
    }
}

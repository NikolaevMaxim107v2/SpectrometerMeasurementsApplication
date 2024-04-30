using SpectrometerMeasurementsApplication.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpectrometerMeasurementsApplication.Forms
{
    public partial class AddProjectForm : Form
    {
        List<Project> projectsList = new List<Project>();
        List<Customer> customersList = new List<Customer>();
        List<MeasuringArea> areas = new List<MeasuringArea>();
        List<string> customerslist = new List<string>();
        int lastProjectID;
        string curUser;
        public AddProjectForm(int id, string Username, List<Project> projects, List<Customer> customers)
        {
            InitializeComponent();
            projectsList = projects;
            lastProjectID = id;
            customersList = customers;
            curUser = Username;
            foreach(Customer cust in customersList) 
            {
                customerslist.Add(cust.CustomerName);
            }
            comboBox1.DataSource = customerslist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lastProjectID++;
            projectsList.Add(new Project(lastProjectID, textBoxName.Text, comboBox1.SelectedIndex, textBoxAddress.Text, DateTime.Now.Date, null));
            MainForm form3 = new MainForm(curUser, projectsList, customersList, areas);
            this.Hide();
            form3.Show();
        }

        private void AddProjectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm form3 = new MainForm(curUser, projectsList, customersList, areas);
            this.Hide();
            form3.Show();
        }
    }
}

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

namespace SpectrometerMeasurementsApplication
{
    public partial class ProjectDataForm : Form
    {
        private string curProjectName;
        private string curUser;
        private List<Project> projects = new List<Project>();
        private List<MeasuringArea> areas = new List<MeasuringArea>();
        private List<Customer> customers = new List<Customer>();
        public ProjectDataForm(Project curProject, string Username, List<Project> projectslist, List<Customer>customerslist,List<MeasuringArea>areaslist)
            //нужно изменить данные
        {
            InitializeComponent();
            curProjectName = curProject.ProjectName;
            curUser = Username;
            projects = projectslist;
            customers = customerslist;
            areas = areaslist;
            textBoxProjectID.Text = curProject.ProjectID.ToString();
            textBoxProjectName.Text = curProject.ProjectName;
            textBoxProjectCustomer.Text = curProject.CustomerID.ToString();
            textBoxProjectArea.Text = curProject.ProjectAddress;
            textBoxProjectDateAccept.Text = curProject.AcceptDate.ToString();
            textBoxProjectDateEnd.Text = curProject.EndDate.ToString();
        }

        private void ProjectDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ProjectDataForm_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Проект " + curProjectName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form3 = new MainForm(curUser, projects,customers,areas);
            this.Hide();
            form3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AreaForm form5 = new AreaForm();
            this.Hide();
            form5.Show();
        }
    }
}

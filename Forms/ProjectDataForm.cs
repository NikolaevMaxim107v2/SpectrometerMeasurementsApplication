using SpectrometerMeasurementsApplication.Classes;
using SpectrometerMeasurementsApplication.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpectrometerMeasurementsApplication
{
    public partial class ProjectDataForm : Form
    {
        private string curProjectName;
        private int currentProjectID;
        private string curUser;
        private List<Project> projects = new List<Project>();
        private List<MeasuringArea> areas = new List<MeasuringArea>();
        private List<Customer> customers = new List<Customer>();
        public List<MeasuringAreaPointsCoords> areaPointsCoords = new List<MeasuringAreaPointsCoords>();
        public List<MeasuringAreaProfile> areaProfiles = new List<MeasuringAreaProfile>();
        public List<Operator> operators = new List<Operator>();
        public List<ProfilePointsCoords> profilePoints = new List<ProfilePointsCoords>();
        public List<Picket> pickets = new List<Picket>();
        public List<PicketCoords> picketCoordsList = new List<PicketCoords>();
        private List<string> areasList = new List<string>();
        private Project currentProject;
        public ProjectDataForm(Project curProject, string Username, List<Project> projectslist, List<Customer> customerslist, List<MeasuringArea> areaslist)
        {
            InitializeComponent();
            curProjectName = curProject.ProjectName;
            currentProject = curProject;
            curUser = Username;
            projects = projectslist;
            customers = customerslist;
            areas = areaslist;
            currentProjectID = curProject.ProjectID;
            textBoxProjectID.Text = curProject.ProjectID.ToString();
            textBoxProjectName.Text = curProject.ProjectName;
            textBoxProjectCustomer.Text = customers[curProject.CustomerID - 1].CustomerName;
            textBoxProjectDateAccept.Text = curProject.AcceptDate.Date.ToString();
            textBoxProjectDateEnd.Text = curProject.EndDate.ToString();
            foreach (MeasuringArea area in areas)
            {
                if(curProject.ProjectID == area.ProjectID)
                {
                    areasList.Add(area.AreaID+" | "+area.AreaName);
                }
            }
            comboBox1.DataSource = areasList;
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
            MainForm form3 = new MainForm(curUser, projects, customers, areas);
            form3.projectsList = projects;
            form3.areaPointsCoords = areaPointsCoords;
            form3.areaProfiles = areaProfiles;
            form3.operators = operators;
            form3.profilePoints = profilePoints;
            form3.pickets = pickets;
            form3.picketCoordsList = picketCoordsList;
            this.Hide();
            form3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AreaForm form5 = new AreaForm(currentProject,curUser,projects,customers,areas);
            form5.areaPointsCoords = areaPointsCoords;
            form5.areaProfiles = areaProfiles;
            form5.operators = operators;
            form5.profilePoints = profilePoints;
            form5.pickets = pickets;
            form5.picketCoordsList = picketCoordsList;
            this.Hide();
            form5.Show();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            textBoxProjectName.ReadOnly = false;
            comboBox1.Enabled = true;
            textBoxProjectDateEnd.ReadOnly = false;
            button3.Visible = true;
            textBoxProjectDateAccept.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            textBoxProjectName.ReadOnly = true;
            comboBox1.Enabled = false;
            textBoxProjectDateEnd.ReadOnly = true;
            textBoxProjectDateAccept.ReadOnly = true;
            for (int i = 0; i < projects.Count; i++)
            {
                if (projects[i].ProjectID == currentProjectID)
                {
                    projects[i].ProjectName = textBoxProjectName.Text;
                    if (comboBox1.SelectedItem != null)
                        projects[i].ProjectAddress = comboBox1.SelectedItem.ToString();
                    DateTime dateValue1;
                    DateTime dateValue2;
                    try
                    {
                        dateValue1 = DateTime.Parse(textBoxProjectDateEnd.Text);
                        dateValue2 = DateTime.Parse(textBoxProjectDateAccept.Text);
                        projects[i].EndDate = dateValue1;
                        projects[i].AcceptDate = dateValue2;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Ошибка конвертации даты!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible=false;
            textBoxProjectName.ReadOnly = true;
            comboBox1.Enabled = false;
            textBoxProjectDateEnd.ReadOnly = true;
            comboBox1.DataSource = null;
            currentProjectID = currentProject.ProjectID;
            textBoxProjectID.Text = currentProject.ProjectID.ToString();
            textBoxProjectName.Text = currentProject.ProjectName;
            textBoxProjectCustomer.Text = customers[currentProject.CustomerID - 1].CustomerName;
            comboBox1.Text = currentProject.ProjectAddress;
            textBoxProjectDateAccept.Text = currentProject.AcceptDate.Date.ToString();
            textBoxProjectDateEnd.Text = currentProject.EndDate.ToString();
        }
    }
}

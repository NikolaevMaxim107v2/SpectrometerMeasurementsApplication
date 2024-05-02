using SpectrometerMeasurementsApplication.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SpectrometerMeasurementsApplication.Forms
{
    public partial class AddAreaForm : Form
    {
        private List<MeasuringArea> areas = new List<MeasuringArea>();
        private List<Customer> customers = new List<Customer>();
        public List<MeasuringAreaPointsCoords> areaPointsCoords = new List<MeasuringAreaPointsCoords>();
        public List<MeasuringAreaProfile> areaProfiles = new List<MeasuringAreaProfile>();
        public List<ProfilePointsCoords> profilePoints = new List<ProfilePointsCoords>();
        public List<Operator> operators = new List<Operator>();
        public List<Picket> pickets = new List<Picket>();
        public List<PicketCoords> picketCoordsList = new List<PicketCoords>();
        string curUser;
        List<Project> projectsList = new List<Project>();
        List<string> projectsNames = new List<string>();
        int rel_project_id;
        int last_id;
        public AddAreaForm(int id, string Username, List<Project> projects, List<Customer> customerslist, List<MeasuringArea> areaslist)
        {
            InitializeComponent();
            curUser = Username;
            projectsList = projects;
            customers = customerslist;
            areas = areaslist;
            last_id = id;
            foreach (Project project in projectsList)
                projectsNames.Add(project.ProjectID + " | " + project.ProjectName);
            comboBox1.DataSource = projectsNames;
        }

        private void AddAreaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm form3 = new MainForm(curUser, projectsList, customers, areas);
            form3.areaPointsCoords = areaPointsCoords;
            form3.areaProfiles = areaProfiles;
            form3.operators = operators;
            form3.profilePoints = profilePoints;
            form3.pickets = pickets;
            form3.picketCoordsList = picketCoordsList;
            this.Hide();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Project project in projectsList)
                if (comboBox1.SelectedItem.ToString().Split(" | ")[0] == project.ProjectID.ToString())
                    rel_project_id = project.ProjectID;
            last_id++;
            areas.Add(new MeasuringArea(last_id, textBoxName.Text, rel_project_id));
            MainForm form3 = new MainForm(curUser, projectsList, customers, areas);
            form3.areaList = areas;
            form3.projectsList = projectsList;
            form3.areaPointsCoords = areaPointsCoords;
            form3.areaProfiles = areaProfiles;
            form3.operators = operators;
            form3.profilePoints = profilePoints;
            form3.pickets = pickets;
            form3.picketCoordsList = picketCoordsList;
            this.Hide();
            form3.Show();
        }
    }
}

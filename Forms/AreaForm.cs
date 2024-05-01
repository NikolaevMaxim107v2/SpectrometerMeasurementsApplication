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

namespace SpectrometerMeasurementsApplication
{
    public partial class AreaForm : Form
    {
        private int currentProjectID;
        private string curUser;
        private List<Project> projects = new List<Project>();
        private List<MeasuringArea> areas = new List<MeasuringArea>();
        private List<Customer> customers = new List<Customer>();
        public List<MeasuringAreaPointsCoords> areaPointsCoords = new List<MeasuringAreaPointsCoords>();
        public List<MeasuringAreaProfile> areaProfiles = new List<MeasuringAreaProfile>();
        private List<string> areasList = new List<string>();
        private List<string> pointsList = new List<string>();
        private Project currentProject;
        private int ind;
        public AreaForm(Project curProject, string Username, List<Project> projectslist, List<Customer> customerslist, List<MeasuringArea> areaslist)
        {
            InitializeComponent();
            currentProject = curProject;
            curUser = Username;
            projects = projectslist;
            customers = customerslist;
            areas = areaslist;
            currentProjectID = curProject.ProjectID;
            foreach (MeasuringArea area in areas)
            {
                if (curProject.ProjectID == area.ProjectID)
                {
                    areasList.Add(area.AreaID + " | " + area.AreaName);
                }
            }
            if(comboBox1.SelectedItem != null)
                ind = Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(" | ")[0]);
            else ind = 0;
            foreach (MeasuringAreaPointsCoords point in areaPointsCoords)
            {
                if (point.AreaID == ind)
                {
                    pointsList.Add(point.CoordsID + " | " + "X: " + point.CoordsX + " | " + "Y: " + point.CoordsY + " | " + "areaID: " + point.AreaID);
                }
            }
            comboBox1.DataSource = areasList;
            comboBox2.DataSource = pointsList;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProfileForm form6 = new ProfileForm();
            //form6.areaPointsCoords = areaPointsCoords;
            //form6.areaProfiles = areaProfiles;
            this.Hide();
            form6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProjectDataForm form4 = new ProjectDataForm(currentProject, curUser, projects, customers, areas);
            form4.areaPointsCoords = areaPointsCoords;
            form4.areaProfiles = areaProfiles;
            this.Hide();
            form4.Show();
        }

        private void AreaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddAreaPointsForm addAreaPointsForm = new AddAreaPointsForm(currentProject, curUser, projects, customers, areas);
            addAreaPointsForm.areaPointsCoords = areaPointsCoords;
            addAreaPointsForm.areaProfiles = areaProfiles;
            this.Hide();
            addAreaPointsForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = null;
            pointsList.Clear();
            ind = Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(" | ")[0]);
            foreach (MeasuringAreaPointsCoords point in areaPointsCoords)
            {
                if (point.AreaID == ind)
                {
                    pointsList.Add(point.CoordsID + " | " + "X: " + point.CoordsX + " | " + "Y: " + point.CoordsY + " | " + "areaID: " + point.AreaID);
                }
            }
            comboBox2.DataSource = pointsList;
        }
    }
}

using SpectrometerMeasurementsApplication.Classes;
using SpectrometerMeasurementsApplication.Forms;
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
using static System.Windows.Forms.DataFormats;

namespace SpectrometerMeasurementsApplication
{
    public partial class AreaForm : Form
    {
        private string curUser;
        private List<Project> projects = new List<Project>();
        private List<MeasuringArea> areas = new List<MeasuringArea>();
        private List<Customer> customers = new List<Customer>();
        public List<MeasuringAreaPointsCoords> areaPointsCoords = new List<MeasuringAreaPointsCoords>();
        public List<MeasuringAreaProfile> areaProfiles = new List<MeasuringAreaProfile>();
        private List<string> areasList = new List<string>();
        private List<string> pointsList = new List<string>();
        private List<string> profilesList = new List<string>();
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
            foreach (MeasuringArea area in areas)
            {
                if (curProject.ProjectID == area.ProjectID)
                {
                    areasList.Add(area.AreaID + " | " + area.AreaName);
                }
            }
            ind = 0;
            foreach (MeasuringAreaPointsCoords point in areaPointsCoords)
            {
                if (point.AreaID == ind)
                {
                    pointsList.Add(point.CoordsID + " | " + "X: " + point.CoordsX + " | " + "Y: " + point.CoordsY + " | " + "areaID: " + point.AreaID);
                }
            }
            foreach (MeasuringAreaProfile profile in areaProfiles)
            {
                if (profile.AreaID == ind)
                {
                    profilesList.Add(ind + " | " + "areaID: " + Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(" | ")[0]));
                }
            }
            comboBox1.DataSource = areasList;
            comboBox1.SelectedIndex = -1;
            comboBox2.DataSource = pointsList;
            comboBox3.DataSource = profilesList;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProfileForm form6 = new ProfileForm(currentProject,curUser,projects,customers,areas);
            form6.areaPointsCoords = areaPointsCoords;
            form6.areaProfiles = areaProfiles;
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
            if (areaProfiles.Count == 0)
            {
                ind = 0;
            }
            else
                ind = areaProfiles[areaProfiles.Count - 1].ProfileID;
            comboBox3.DataSource = null;
            if (comboBox1.SelectedIndex >= 0)
            {
                ind++;
                areaProfiles.Add(new MeasuringAreaProfile(ind, Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(" | ")[0])));
                profilesList.Add(ind + " | " + "areaID: " + Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(" | ")[0]));
                comboBox3.DataSource = profilesList;
                comboBox3.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = null;
            comboBox3.DataSource = null;
            pointsList.Clear();
            if (comboBox1.SelectedIndex < 0)
                ind = -1;
            else
                ind = Convert.ToInt32(comboBox1.SelectedValue.ToString().Split(" | ")[0]);
            foreach (MeasuringAreaPointsCoords point in areaPointsCoords)
            {
                if (point.AreaID == ind)
                {
                    pointsList.Add(point.CoordsID + " | " + "X: " + point.CoordsX + " | " + "Y: " + point.CoordsY + " | " + "areaID: " + point.AreaID);
                }
            }
            foreach (MeasuringAreaProfile profile in areaProfiles)
            {
                if (profile.AreaID == ind)
                {
                    profilesList.Add(profile.ProfileID + " | " + "areaID: " + profile.AreaID);
                }
            }
            comboBox2.DataSource = pointsList;
            if (pointsList.Count <= 0)
                comboBox2.SelectedIndex = -1;
            else
                comboBox2.SelectedIndex = 0;
            comboBox3.DataSource = profilesList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < areaPointsCoords.Count; j++)
                if (Convert.ToInt32(comboBox2.SelectedItem.ToString().Split(" | ")[0]) == areaPointsCoords[j].CoordsID)
                {
                    areaPointsCoords.Remove(areaPointsCoords[j]);
                }
            for (int j = 0; j < pointsList.Count; j++)
                if (pointsList[j] == comboBox2.SelectedItem.ToString())
                {
                    pointsList.Remove(pointsList[j]);
                }
            comboBox2.DataSource = null;
            comboBox2.Items.Remove(comboBox2.SelectedItem);
            comboBox2.DataSource = pointsList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < areaProfiles.Count; j++)
                if (Convert.ToInt32(comboBox3.SelectedItem.ToString().Split(" | ")[0]) == areaProfiles[j].ProfileID)
                {
                    areaProfiles.Remove(areaProfiles[j]);
                }
            for (int j = 0; j < profilesList.Count; j++)
                if (profilesList[j] == comboBox3.SelectedItem.ToString())
                {
                    profilesList.Remove(profilesList[j]);
                }
            comboBox3.DataSource = null;
            comboBox3.Items.Remove(comboBox2.SelectedItem);
            comboBox3.DataSource = profilesList;
        }
    }
}

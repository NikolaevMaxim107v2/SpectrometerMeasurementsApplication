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
using static System.Windows.Forms.DataFormats;

namespace SpectrometerMeasurementsApplication
{
    public partial class ProfileForm : Form
    {
        private string curUser;
        private string curProfile;
        private List<Project> projects = new List<Project>();
        private List<MeasuringArea> areas = new List<MeasuringArea>();
        private List<Customer> customers = new List<Customer>();
        public List<MeasuringAreaPointsCoords> areaPointsCoords = new List<MeasuringAreaPointsCoords>();
        public List<MeasuringAreaProfile> areaProfiles = new List<MeasuringAreaProfile>();
        public List<Operator> operators = new List<Operator>();
        public List<ProfilePointsCoords> profilePoints = new List<ProfilePointsCoords>();
        public List<Picket> pickets = new List<Picket>();
        public List<PicketCoords> picketCoordsList = new List<PicketCoords>();
        private List<string> operatorsList = new List<string>();
        private List<string> pointsList = new List<string>();
        private List<string> picketsList = new List<string>();
        private Project currentProject;
        private int ind;
        public ProfileForm(string curprofile, Project curProject, string Username, List<Project> projectslist, List<Customer> customerslist, List<MeasuringArea> areaslist)
        {
            InitializeComponent();
            currentProject = curProject;
            curUser = Username;
            projects = projectslist;
            curProfile = curprofile;
            customers = customerslist;
            areas = areaslist;
            textBox1.Text = curprofile;
        }

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AreaForm form5 = new AreaForm(currentProject, curUser, projects, customers, areas);
            form5.areaPointsCoords = areaPointsCoords;
            form5.areaProfiles = areaProfiles;
            form5.operators = operators;
            form5.profilePoints = profilePoints;
            form5.pickets = pickets;
            form5.picketCoordsList = picketCoordsList;
            this.Hide();
            form5.Show();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            foreach (Operator op in operators)
            {
                operatorsList.Add(op.OperatorID + " | " + op.OperatorName + " | " + op.OperatorSurname + " | " + op.Phone + " | " + op.Email);
            }
            if (profilePoints.Count == 0)
            {
                ind = 0;
            }
            else
                ind = profilePoints[profilePoints.Count - 1].CoordsID;
            foreach (ProfilePointsCoords point in profilePoints)
            {
                if (point.CoordsID == ind)
                {
                    pointsList.Add(point.CoordsID + " | " + "X: " + point.CoordsX + " | " + "Y: " + point.CoordsY + " | " + "profileID: " + point.ProfileID);
                }
            }
            if (pickets.Count == 0)
            {
                ind = 0;
            }
            else
                ind = pickets[pickets.Count - 1].PicketID;
            for (int j = 0; j < pickets.Count; j++)
            {
                if (pickets[j].PicketID == ind)
                {
                    picketsList.Add(pickets[j].PicketID + pickets[j].ProfileID + " | " + "X: " + picketCoordsList[j].CoordsX + " | " + "Y: " + picketCoordsList[j].CoordsY);
                }
            }
            comboBox1.DataSource = operatorsList;
            comboBox2.DataSource = pointsList;
            comboBox3.DataSource = picketsList;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddOperatorForm addOperatorForm = new AddOperatorForm(curProfile, currentProject, curUser, projects, customers, areas);
            addOperatorForm.areaPointsCoords = areaPointsCoords;
            addOperatorForm.areaProfiles = areaProfiles;
            addOperatorForm.operators = operators;
            addOperatorForm.profilePoints = profilePoints;
            addOperatorForm.pickets = pickets;
            addOperatorForm.picketCoordsList = picketCoordsList;
            this.Hide();
            addOperatorForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < operators.Count; j++)
                if (Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(" | ")[0]) == operators[j].OperatorID)
                {
                    operators.Remove(operators[j]);
                }
            for (int j = 0; j < operatorsList.Count; j++)
                if (operatorsList[j] == comboBox1.SelectedItem.ToString())
                {
                    operatorsList.Remove(operatorsList[j]);
                }
            comboBox1.DataSource = null;
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            comboBox1.DataSource = operatorsList;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddProfilePointForm addProfilePointForm = new AddProfilePointForm(curProfile, currentProject, curUser, projects, customers, areas);
            addProfilePointForm.areaPointsCoords = areaPointsCoords;
            addProfilePointForm.areaProfiles = areaProfiles;
            addProfilePointForm.operators = operators;
            addProfilePointForm.profilePoints = profilePoints;
            addProfilePointForm.pickets = pickets;
            addProfilePointForm.picketCoordsList = picketCoordsList;
            this.Hide();
            addProfilePointForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < profilePoints.Count; j++)
                if (Convert.ToInt32(comboBox2.SelectedItem.ToString().Split(" | ")[0]) == profilePoints[j].CoordsID)
                {
                    profilePoints.Remove(profilePoints[j]);
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
            for (int j = 0; j < pickets.Count; j++)
                if (Convert.ToInt32(comboBox3.SelectedItem.ToString().Split(" | ")[0]) == pickets[j].ProfileID)
                {
                    pickets.Remove(pickets[j]);
                    picketCoordsList.Remove(picketCoordsList[j]);
                }
            for (int j = 0; j < picketsList.Count; j++)
                if (picketsList[j] == comboBox3.SelectedItem.ToString())
                {
                    picketsList.Remove(picketsList[j]);
                }
            comboBox3.DataSource = null;
            comboBox3.Items.Remove(comboBox3.SelectedItem);
            comboBox3.DataSource = picketsList;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPicketForm addPicketForm = new AddPicketForm(curProfile, currentProject, curUser, projects, customers, areas);
            addPicketForm.areaPointsCoords = areaPointsCoords;
            addPicketForm.areaProfiles = areaProfiles;
            addPicketForm.operators = operators;
            addPicketForm.profilePoints = profilePoints;
            addPicketForm.pickets = pickets;
            addPicketForm.picketCoordsList = picketCoordsList;
            this.Hide();
            addPicketForm.ShowDialog();
        }
    }
}

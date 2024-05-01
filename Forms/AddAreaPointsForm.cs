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

namespace SpectrometerMeasurementsApplication.Forms
{
    public partial class AddAreaPointsForm : Form
    {
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
        private int last_point_ind;
        private int rel_area_id;
        public AddAreaPointsForm(Project curProject, string Username, List<Project> projectslist, List<Customer> customerslist, List<MeasuringArea> areaslist)
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
            comboBox1.DataSource = areasList;
            if (areaPointsCoords.Count == 0)
            {
                last_point_ind = 0;
            }
            else
                last_point_ind = areaPointsCoords[areaPointsCoords.Count - 1].CoordsID;
        }

        private void AddAreaPointsForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (MeasuringArea area in areas)
                if (comboBox1.SelectedItem.ToString().Split(" | ")[0] == area.AreaID.ToString())
                    rel_area_id = area.AreaID;
            last_point_ind++;
            areaPointsCoords.Add(new MeasuringAreaPointsCoords(last_point_ind, Convert.ToInt32(textBoxX.Text),
                Convert.ToInt32(textBoxY.Text), rel_area_id));
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
    }
}

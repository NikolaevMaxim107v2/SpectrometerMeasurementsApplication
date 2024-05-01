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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpectrometerMeasurementsApplication.Forms
{
    public partial class AddProfilePointForm : Form
    {
        private int currentProjectID;
        private string curProfile;
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
        private Project currentProject;
        private int last_point_ind;
        private int rel_profile_id;
        public AddProfilePointForm(string curprofile,Project curProject, string Username, List<Project> projectslist, List<Customer> customerslist, List<MeasuringArea> areaslist)
        {
            InitializeComponent();
            currentProject = curProject;
            curUser = Username;
            projects = projectslist;
            customers = customerslist;
            areas = areaslist;
            curProfile = curprofile;
            currentProjectID = curProject.ProjectID;
        }

        private void AddProfilePointsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProfileForm form6 = new ProfileForm(curProfile, currentProject, curUser, projects, customers, areas);
            form6.areaPointsCoords = areaPointsCoords;
            form6.areaProfiles = areaProfiles;
            form6.operators = operators;
            form6.profilePoints = profilePoints;
            form6.pickets = pickets;
            this.Hide();
            form6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rel_profile_id = Convert.ToInt32(curProfile.Split(" | ")[0]);
            if (profilePoints.Count == 0)
            {
                last_point_ind = 0;
            }
            else
                last_point_ind = profilePoints[profilePoints.Count - 1].CoordsID;
            last_point_ind++;
            profilePoints.Add(new ProfilePointsCoords(last_point_ind, Convert.ToInt32(textBoxX.Text),
                Convert.ToInt32(textBoxY.Text), rel_profile_id));
            ProfileForm form6 = new ProfileForm(curProfile,currentProject, curUser, projects, customers, areas);
            form6.areaPointsCoords = areaPointsCoords;
            form6.areaProfiles = areaProfiles;
            form6.operators = operators;
            form6.profilePoints = profilePoints;
            form6.pickets = pickets;
            form6.picketCoordsList = picketCoordsList;
            this.Hide();
            form6.Show();
        }
    }
}

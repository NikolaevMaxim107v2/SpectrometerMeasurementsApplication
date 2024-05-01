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
    public partial class AddPicketForm : Form
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
        private List<string> profilesList = new List<string>();
        private Project currentProject;
        private int ind;
        private int rel_operator_id;
        private int rel_profile_id;
        public AddPicketForm(string curprofile, Project curProject, string Username, List<Project> projectslist, List<Customer> customerslist, List<MeasuringArea> areaslist)
        {
            InitializeComponent();
            currentProject = curProject;
            curUser = Username;
            projects = projectslist;
            curProfile = curprofile;
            customers = customerslist;
            areas = areaslist;
        }

        private void AddPicketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProfileForm form6 = new ProfileForm(curProfile, currentProject, curUser, projects, customers, areas);
            form6.areaPointsCoords = areaPointsCoords;
            form6.areaProfiles = areaProfiles;
            form6.operators = operators;
            form6.profilePoints = profilePoints;
            form6.pickets = pickets;
            form6.picketCoordsList = picketCoordsList;
            this.Hide();
            form6.Show();
        }

        private void AddPicketForm_Load(object sender, EventArgs e)
        {
            foreach (Operator op in operators)
            {
                operatorsList.Add(op.OperatorID + " | " + op.OperatorName + " | " + op.OperatorSurname + " | " + op.Phone + " | " + op.Email);
            }
            comboBox1.DataSource = operatorsList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Picket pick in pickets)
                if (comboBox1.SelectedItem.ToString().Split(" | ")[0] == pick.OperatorID.ToString())
                    rel_operator_id = pick.OperatorID;
            if (pickets.Count == 0)
            {
               ind = 0;
            }
            else
                ind = pickets[pickets.Count - 1].PicketID;
            rel_profile_id = Convert.ToInt32(curProfile.Split(" | ")[0]);
            pickets.Add(new Picket(ind, rel_profile_id, rel_operator_id));
            picketCoordsList.Add(new PicketCoords(ind, ind, Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text)));
            ProfileForm form6 = new ProfileForm(curProfile, currentProject, curUser, projects, customers, areas);
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

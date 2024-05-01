using SpectrometerMeasurementsApplication.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpectrometerMeasurementsApplication.Forms
{
    public partial class AddOperatorForm : Form
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
        private Project currentProject;
        private int ind;
        public AddOperatorForm(string curprofile, Project curProject, string Username, List<Project> projectslist, List<Customer> customerslist, List<MeasuringArea> areaslist)
        {
            InitializeComponent();
            currentProject = curProject;
            curUser = Username;
            projects = projectslist;
            customers = customerslist;
            areas = areaslist;
            curProfile = curprofile;
        }

        private void AddOperatorForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsPhoneNumber(textBoxPhone.Text))
            {
                if (IsEmail(textBoxAddress.Text))
                {
                    if (operators.Count <= 0)
                    {
                        ind = 0;
                    }
                    else
                        ind = operators[operators.Count - 1].OperatorID;
                    ind++;
                    operators.Add(new Operator(ind, textBoxName.Text, textBox1.Text, textBoxPhone.Text, textBoxAddress.Text));
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
                else
                {
                    MessageBox.Show("Введённый email имеет неверный формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введённый номер телефона имеет неверный формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool IsPhoneNumber(string input)
        {
            Match match = Regex.Match(input, @"^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$", RegexOptions.IgnoreCase);
            return match.Success;
        }
        bool IsEmail(string input)
        {
            if (!string.IsNullOrEmpty(input?.Trim()))
            {
                const string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
                var email = input.Trim().ToLowerInvariant();

                if (Regex.Match(email, pattern).Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

using Microsoft.Data.SqlClient;
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
        private static string conn = "Data Source=localhost\\SQLEXPRESS;" +
            "Initial Catalog=NikolaevMD107v2_IndTask2;Integrated Security=True;trustServerCertificate=true";
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
            try
            {
                rel_profile_id = Convert.ToInt32(curProfile.Split(" | ")[0]);
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();

                    MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    string projectComStr = $"INSERT INTO Picket(ProfileID, OperatorID)" +
                        $" VALUES ({rel_profile_id},{comboBox1.SelectedItem.ToString().ToCharArray()[0]})";
                    SqlCommand projectCMD = new SqlCommand(projectComStr, con);
                    projectCMD.ExecuteNonQuery();


                    projectComStr = $"SELECT * FROM Picket ORDER BY PicketID DESC";
                    projectCMD = new SqlCommand(projectComStr, con);
                    SqlDataReader projectReader = projectCMD.ExecuteReader();
                    if (projectReader.HasRows)
                        while (projectReader.Read())
                        {
                            ind = projectReader.GetInt32(0);
                            MessageBox.Show($"ind="+ind, "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;
                        }
                    projectReader.Close();


                    projectComStr = $"INSERT INTO PicketCoords(PicketID, CoordsX, CoordsY)" +
                        $" VALUES ({ind} , {textBoxX.Text} , {textBoxY.Text})";
                    projectCMD = new SqlCommand(projectComStr, con);
                    projectCMD.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Соединение закрыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                ProfileForm form6 = new ProfileForm(curProfile, currentProject, curUser, projects, customers, areas);
                form6.areaPointsCoords = areaPointsCoords;
                form6.areaProfiles = areaProfiles;
                form6.operators = operators;
                form6.profilePoints = profilePoints;
                form6.pickets = pickets;
                form6.picketCoordsList = picketCoordsList;
                MessageBox.Show("Успешное добавление!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
                form6.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления! {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

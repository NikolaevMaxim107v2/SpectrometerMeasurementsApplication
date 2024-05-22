using Microsoft.Data.SqlClient;
using SpectrometerMeasurementsApplication.Classes;

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
        private static string conn = "Data Source=localhost\\SQLEXPRESS;" +
    "Initial Catalog=NikolaevMD107v2_IndTask2;Integrated Security=True;trustServerCertificate=true";
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
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].CustomerID == projects[i].CustomerID)
                {
                    textBoxProjectCustomer.Text = customers[i].CustomerName;
                    break;
                }
            }
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
            textBoxProjectDateEnd.ReadOnly = true;
            textBoxProjectDateAccept.ReadOnly = true;
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;" +
                "Initial Catalog=NikolaevMD107v2_IndTask2;Integrated Security=True;trustServerCertificate=true"))
                {
                    con.Open();
                    MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    string projectComStr;
                    if (textBoxProjectDateEnd.Text != null && textBoxProjectDateEnd.Text != "")
                    {
                        projectComStr = $"UPDATE Project SET ProjectName = N'{textBoxProjectName.Text}'," +
                        $"AcceptDate = '{textBoxProjectDateAccept.Text}'," +
                        $"EndDate = '{textBoxProjectDateEnd.Text}' WHERE ProjectID = {textBoxProjectID.Text}";
                    }
                    else
                    {
                        projectComStr = $"UPDATE Project SET ProjectName = N'{textBoxProjectName.Text}'," +
                        $"AcceptDate = '{textBoxProjectDateAccept.Text}'," +
                        $"EndDate = null WHERE ProjectID = {textBoxProjectID.Text}";
                    }
                    SqlCommand projectCMD = new SqlCommand(projectComStr, con);
                    projectCMD.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Соединение закрыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    MessageBox.Show("Успешное обновление данных!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления данных! {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible=false;
            textBoxProjectName.ReadOnly = true;
            textBoxProjectDateAccept.ReadOnly = true;
            textBoxProjectDateEnd.ReadOnly = true;
            textBoxProjectID.Text = currentProject.ProjectID.ToString();
            textBoxProjectName.Text = currentProject.ProjectName;
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].CustomerID == projects[i].CustomerID)
                {
                    textBoxProjectCustomer.Text = customers[i].CustomerName;
                    break;
                }
            }
            textBoxProjectDateAccept.Text = currentProject.AcceptDate.Date.ToString();
            textBoxProjectDateEnd.Text = currentProject.EndDate.ToString();
        }
    }
}

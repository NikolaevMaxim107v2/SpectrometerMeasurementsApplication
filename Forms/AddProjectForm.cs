using Microsoft.Data.SqlClient;
using SpectrometerMeasurementsApplication.Classes;

namespace SpectrometerMeasurementsApplication.Forms
{
    public partial class AddProjectForm : Form
    {
        List<Project> projectsList = new List<Project>();
        List<Customer> customersList = new List<Customer>();
        List<MeasuringArea> areas = new List<MeasuringArea>();
        public List<MeasuringAreaPointsCoords> areaPointsCoords = new List<MeasuringAreaPointsCoords>();
        public List<MeasuringAreaProfile> areaProfiles = new List<MeasuringAreaProfile>();
        public List<Operator> operators = new List<Operator>();
        public List<ProfilePointsCoords> profilePoints = new List<ProfilePointsCoords>();
        public List<Picket> pickets = new List<Picket>();
        public List<PicketCoords> picketCoordsList = new List<PicketCoords>();
        List<string> customerslist = new List<string>();
        string curUser;
        private static string conn = "Data Source=localhost\\SQLEXPRESS;" +
            "Initial Catalog=NikolaevMD107v2_IndTask2;Integrated Security=True;trustServerCertificate=true";
        public AddProjectForm(string Username, List<Project> projects, List<Customer> customers, List<MeasuringArea> areaslist)
        {
            InitializeComponent();
            projectsList = projects;
            customersList = customers;
            areas = areaslist;
            curUser = Username;
            foreach (Customer cust in customersList)
            {
                customerslist.Add(cust.CustomerID.ToString() + " | " + cust.CustomerName + " | " + cust.Phone + " | " + cust.Email);
            }
            comboBox1.DataSource = customerslist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();
                    MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    string projectComStr = $"INSERT INTO [Project](ProjectName, CustomerID,ProjectAddress,AcceptDate,EndDate) " +
                        $"VALUES (N'{textBoxName.Text}', N'{comboBox1.SelectedItem.ToString().ToCharArray()[0]}', N'Не указан', '{DateTime.Now.Date}', null)";
                    SqlCommand projectCMD = new SqlCommand(projectComStr, con);
                    projectCMD.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Соединение закрыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                MainForm form3 = new MainForm(curUser, projectsList, customersList, areas);
                form3.areaPointsCoords = areaPointsCoords;
                form3.areaProfiles = areaProfiles;
                form3.profilePoints = profilePoints;
                form3.pickets = pickets;
                form3.picketCoordsList = picketCoordsList;
                MessageBox.Show("Успешное добавление!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
                form3.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления! {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProjectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm form3 = new MainForm(curUser, projectsList, customersList, areas);
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

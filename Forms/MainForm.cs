using SpectrometerMeasurementsApplication.Classes;
using SpectrometerMeasurementsApplication.Forms;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.CompilerServices;
using System.DirectoryServices.ActiveDirectory;
using System.Diagnostics.Eventing.Reader;

namespace SpectrometerMeasurementsApplication
{
    public partial class MainForm : Form
    {
        public string curUser;
        public List<Project> projectsList = new List<Project>();
        public List<MeasuringAreaPointsCoords> areaPointsCoords = new List<MeasuringAreaPointsCoords>();
        public List<MeasuringAreaProfile> areaProfiles = new List<MeasuringAreaProfile>();
        private DataTable projectsTable = new DataTable("projectsTable");
        public List<Customer> customersList = new List<Customer>();
        public List<MeasuringArea> areaList = new List<MeasuringArea>();
        public List<Operator> operators = new List<Operator>();
        public List<ProfilePointsCoords> profilePoints = new List<ProfilePointsCoords>();
        public List<Picket> pickets = new List<Picket>();
        public List<PicketCoords> picketCoordsList = new List<PicketCoords>();
        private List<string> customers = new List<string>();
        private List<string> areas = new List<string>();
        private Project curProject;
        private int ind;
        private int last_customer_ind;
        private int last_area_ind;
        private static string conn = "Data Source=localhost\\SQLEXPRESS;" +
        "Initial Catalog=NikolaevMD107v2_IndTask2;Integrated Security=True;trustServerCertificate=true";

        public MainForm(string curuser, List<Project> projects, List<Customer> customerslist, List<MeasuringArea> areaslist)
        {
            InitializeComponent();
            projectsList = projects;
            curUser = curuser;
            textBoxUser.Text = "Пользователь: " + curUser;
            customersList = customerslist;
            areaList = areaslist;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WelcomeForm form1 = new WelcomeForm();
            this.Hide();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ind = dataGridView1.CurrentCell.RowIndex;
            string curProjectID = dataGridView1.Rows[ind].Cells[0].Value.ToString();
            for (int j = 0; j < projectsList.Count; j++)
            {
                if (curProjectID == projectsList[j].ProjectID.ToString())
                    curProject = projectsList[j];
            }
            ProjectDataForm form4 = new ProjectDataForm(curProject, curUser, projectsList, customersList, areaList);//нужно изменить входные данные
            form4.areaPointsCoords = areaPointsCoords;
            form4.areaProfiles = areaProfiles;
            form4.operators = operators;
            form4.profilePoints = profilePoints;
            form4.pickets = pickets;
            form4.picketCoordsList = picketCoordsList;
            this.Hide();
            form4.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            projectsList = new List<Project>();
            customersList = new List<Customer>();
            areaList = new List<MeasuringArea>();
            try
            {
                Project project = null;
                Customer customer = null;
                MeasuringArea area = null;
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();
                    //MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    string customerComStr = $"SELECT CustomerID, CustomerName, Email, Phone from Customer";
                    SqlCommand customerCMD = new SqlCommand(customerComStr, con);
                    SqlDataReader customerReader = customerCMD.ExecuteReader();
                    if (customerReader.HasRows)
                        while (customerReader.Read())
                        {
                            customer = new Customer(customerReader.GetInt32(0), customerReader.GetString(1), customerReader.GetString(2), customerReader.GetString(3));
                            //MessageBox.Show("Заказчик считан", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            customersList.Add(customer);
                        }
                    customerReader.Close();

                    string areaComStr = "SELECT AreaID, AreaName, ProjectID from MeasuringArea";
                    SqlCommand areaCMD = new SqlCommand(areaComStr, con);
                    SqlDataReader areaReader = areaCMD.ExecuteReader();
                    if (areaReader.HasRows)
                        while (areaReader.Read())
                        {
                            area = new MeasuringArea(areaReader.GetInt32(0), areaReader.GetString(1), areaReader.GetInt32(2));
                            //MessageBox.Show("Площадь считана", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            areaList.Add(area);
                        }
                    areaReader.Close();

                    string projectComStr = "SELECT ProjectID, ProjectName, CustomerID, ProjectAddress, AcceptDate, EndDate from Project";
                    SqlCommand projectCMD = new SqlCommand(projectComStr, con);
                    SqlDataReader? projectReader = projectCMD.ExecuteReader();
                    DateTime? projectEndDate;
                    if (projectReader.HasRows)
                        while (projectReader.Read())
                        {
                            if (projectReader.IsDBNull(5))
                                projectEndDate = null;
                            else
                                projectEndDate = projectReader.GetDateTime(5);
                            project = new Project(projectReader.GetInt32(0), projectReader.GetString(1), projectReader.GetInt32(2), projectReader.GetString(3), projectReader.GetDateTime(4), projectEndDate);
                            //MessageBox.Show("Проект считан", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            projectsList.Add(project);
                        }
                    projectReader.Close();

                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось считать все данные из БД, часть данных не будет отображена!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (Customer cust in customersList)
            {
                customers.Add(cust.CustomerID.ToString() + " | " + cust.CustomerName + " | " + cust.Phone + " | " + cust.Email);
            }
            foreach (MeasuringArea area in areaList)
            {
                areas.Add(area.AreaID + " | " + area.AreaName + " | " + "projectID=" + area.ProjectID);
            }
            projectsTable.Columns.Add("ID", Type.GetType("System.Int32"));
            projectsTable.Columns.Add("Name", Type.GetType("System.String"));
            projectsTable.Columns.Add("Customer ID", Type.GetType("System.Int32"));
            projectsTable.Columns.Add("Accept Date", Type.GetType("System.DateTime"));
            projectsTable.Columns.Add("End Date", Type.GetType("System.DateTime"));
            if (projectsList != null)
            {
                foreach (Project project in projectsList)
                {
                    projectsTable.Rows.Add(project.ProjectID, project.ProjectName,
                        project.CustomerID, project.AcceptDate.Date, project.EndDate);
                }
            }
            if (customersList.Count == 0)
            {
                last_customer_ind = 0;
            }
            else
                last_customer_ind = customersList[customersList.Count - 1].CustomerID;
            if (areaList.Count == 0)
            {
                last_area_ind = 0;
            }
            else
                last_area_ind = areaList[areaList.Count - 1].AreaID;
            dataGridView1.DataSource = projectsTable;
            comboBox1.DataSource = customers;
            comboBox2.DataSource = areas;
        }



        private void button8_Click(object sender, EventArgs e)
        {
            if(customersList.Count != 0)
            {
                AddProjectForm addProjectForm = new AddProjectForm(curUser, projectsList, customersList, areaList);
                addProjectForm.areaPointsCoords = areaPointsCoords;
                addProjectForm.areaProfiles = areaProfiles;
                addProjectForm.operators = operators;
                addProjectForm.profilePoints = profilePoints;
                addProjectForm.pickets = pickets;
                addProjectForm.picketCoordsList = picketCoordsList;
                this.Hide();
                addProjectForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ошибка!\nДобавьте хотя бы одного клиента!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (projectsList.Count >= 0)
            {
                try
                {
                    ind = dataGridView1.CurrentCell.RowIndex;
                    string deleteID = dataGridView1.Rows[ind].Cells[0].Value.ToString();
                    using (SqlConnection con = new SqlConnection(conn))
                    {
                        con.Open();
                        MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        string projectComStr = $"DELETE Project WHERE ProjectID = {deleteID}";
                        SqlCommand projectCMD = new SqlCommand(projectComStr, con);
                        projectCMD.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Соединение закрыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        MessageBox.Show("Успешное удаление!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    dataGridView1.Rows.RemoveAt(ind);
                    for (int j = 0; j < projectsList.Count; j++)
                    {
                        if (deleteID == projectsList[j].ProjectID.ToString())
                        {
                            projectsList.Remove(projectsList[j]);
                            break;
                        }
                    }
                    dataGridView1.DataSource = projectsTable;
                }
                catch
                {
                    MessageBox.Show("Ошибка удаления!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();
                    MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    string projectComStr = $"DELETE Customer WHERE CustomerID = {comboBox1.SelectedItem.ToString().Split(" | ")[0]}";
                    SqlCommand projectCMD = new SqlCommand(projectComStr, con);
                    projectCMD.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Соединение закрыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    MessageBox.Show("Успешное удаление!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                for (int j = 0; j < customersList.Count; j++)
                    if (comboBox1.SelectedItem.ToString() == customersList[j].CustomerName)
                    {
                        customersList.Remove(customersList[j]);
                    }
                for (int j = 0; j < customers.Count; j++)
                    if (customers[j] == comboBox1.SelectedItem.ToString())
                    {
                        customers.Remove(customers[j]);
                    }
                comboBox1.DataSource = null;
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                comboBox1.DataSource = customers;
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();
                    MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    string projectComStr = $"DELETE MeasuringArea WHERE AreaID = {comboBox2.SelectedItem.ToString().Split(" | ")[0]}";
                    SqlCommand projectCMD = new SqlCommand(projectComStr, con);
                    projectCMD.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Соединение закрыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    MessageBox.Show("Успешное удаление!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                for (int j = 0; j < areaList.Count; j++)
                    if (comboBox2.SelectedItem.ToString() == areaList[j].AreaName)
                    {
                        areaList.Remove(areaList[j]);
                    }
                for (int j = 0; j < areas.Count; j++)
                    if (areas[j] == comboBox2.SelectedItem.ToString())
                    {
                        areas.Remove(areas[j]);
                    }
                comboBox2.DataSource = null;
                comboBox2.Items.Remove(comboBox2.SelectedItem);
                comboBox2.DataSource = areas;
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm(last_customer_ind, curUser, projectsList, customersList, areaList);
            addCustomerForm.areaPointsCoords = areaPointsCoords;
            addCustomerForm.areaProfiles = areaProfiles;
            addCustomerForm.operators = operators;
            addCustomerForm.profilePoints = profilePoints;
            addCustomerForm.pickets = pickets;
            addCustomerForm.picketCoordsList = picketCoordsList;
            this.Hide();
            addCustomerForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(projectsList.Count!=0)
            {
                AddAreaForm addAreaForm = new AddAreaForm(last_area_ind, curUser, projectsList, customersList, areaList);
                addAreaForm.areaPointsCoords = areaPointsCoords;
                addAreaForm.areaProfiles = areaProfiles;
                addAreaForm.operators = operators;
                addAreaForm.profilePoints = profilePoints;
                addAreaForm.pickets = pickets;
                addAreaForm.picketCoordsList = picketCoordsList;
                this.Hide();
                addAreaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ошибка!\nДобавьте хотя бы один проект!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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

namespace SpectrometerMeasurementsApplication
{
    public partial class MainForm : Form
    {
        public string curUser;
        public List<Project> projectsList = new List<Project>();
        private DataTable projectsTable = new DataTable("projectsTable");
        public List<Customer> customersList = new List<Customer>();
        public List<MeasuringArea> areaList = new List<MeasuringArea>();
        private List<string> customers = new List<string>();
        private List<string> areas = new List<string>();
        private Project curProject;
        private int ind;
        private int last_project_ind;
        private int last_customer_ind;
        private int last_area_ind;

        public MainForm(string Username, List<Project> projects, List<Customer> customerslist, List<MeasuringArea> areaslist)
        {
            InitializeComponent();
            curUser = Username;
            projectsList = projects;
            textBoxUser.Text = "Пользователь: " + curUser;
            customersList = customerslist;
            areaList = areaslist;
            foreach (Customer customer in customersList)
            {
                customers.Add(customer.CustomerName);
            }
            foreach (MeasuringArea area in areaList)
            {
                areas.Add(area.AreaName);
            }
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
            this.Hide();
            form4.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            projectsTable.Columns.Add("ID", Type.GetType("System.Int32"));
            projectsTable.Columns.Add("Name", Type.GetType("System.String"));
            projectsTable.Columns.Add("Customer ID", Type.GetType("System.Int32"));
            projectsTable.Columns.Add("Address", Type.GetType("System.String"));
            projectsTable.Columns.Add("Accept Date", Type.GetType("System.DateTime"));
            projectsTable.Columns.Add("End Date", Type.GetType("System.DateTime"));
            if (projectsList != null)
            {
                foreach (Project project in projectsList)
                {
                    projectsTable.Rows.Add(project.ProjectID, project.ProjectName,
                        project.CustomerID, project.ProjectAddress, project.AcceptDate.Date, project.EndDate);
                    last_project_ind = project.ProjectID;
                }
            }
            if (projectsList.Count == 0)
            {
                last_project_ind = 0;
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
                AddProjectForm addProjectForm = new AddProjectForm(last_project_ind, curUser, projectsList, customersList);
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
                ind = dataGridView1.CurrentCell.RowIndex;
                string deleteID = dataGridView1.Rows[ind].Cells[0].Value.ToString();
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ind = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[ind];
        }

        private void button3_Click(object sender, EventArgs e)
        {
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

        private void button4_Click(object sender, EventArgs e)
        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm(last_customer_ind, curUser, projectsList, customersList, areaList);
            this.Hide();
            addCustomerForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(projectsList.Count!=0)
            {
                AddAreaForm addAreaForm = new AddAreaForm(last_area_ind, curUser, projectsList, customersList, areaList);
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

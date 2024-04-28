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
    public partial class ProjectDataForm : Form
    {
        public string curProjectName;
        public string curUser;
        public ProjectDataForm(string curProject, string Username) //нужно изменить данные
        {
            InitializeComponent();
            curProjectName = curProject;
            curUser = Username;
            string ProjectID = "1";
            string ProjectName = "Empty";
            string ProjectCustomer = "Empty";
            string ProjectArea = "Empty";
            string ProjectDateAccept = "Empty";
            string ProjectDateEnd = "Empty";
            textBoxProjectID.Text = ProjectID;
            textBoxProjectName.Text = ProjectName;
            textBoxProjectCustomer.Text = ProjectCustomer;
            textBoxProjectArea.Text = ProjectArea;
            textBoxProjectDateAccept.Text = ProjectDateAccept;
            textBoxProjectDateEnd.Text = ProjectDateEnd;
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
            MainForm form3 = new MainForm(curUser);
            this.Hide();
            form3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AreaForm form5 = new AreaForm();
            this.Hide();
            form5.Show();
        }
    }
}

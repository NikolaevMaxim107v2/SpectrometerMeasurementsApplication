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
using static System.Windows.Forms.DataFormats;

namespace SpectrometerMeasurementsApplication.Forms
{
    public partial class AdminPasswordForm : Form
    {
        private List<Project> projects = new List<Project>();
        private List<MeasuringArea> areas = new List<MeasuringArea>();
        private List<Customer> customers = new List<Customer>();
        public AdminPasswordForm()
        {
            InitializeComponent();
        }

        private void AdminPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm form2 = new LoginForm();
            this.Hide();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "admin")
            {
                string curUser = textBoxUsername.Text;
                MainForm form3 = new MainForm(curUser, projects, customers,areas);
                this.Hide();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации!\nНеверный логин!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

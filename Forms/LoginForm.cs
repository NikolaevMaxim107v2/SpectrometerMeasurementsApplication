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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpectrometerMeasurementsApplication
{
    public partial class LoginForm : Form
    {
        private List<string> users = new List<string>();
        private List<Project> projects = new List<Project>();
        private List<MeasuringArea> areas = new List<MeasuringArea>();
        private List<Customer> customers = new List<Customer>();

        private bool userFound;

        public LoginForm()
        {
            InitializeComponent();
            users.Add("User1");
            users.Add("Nora");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text.ToLower() == "admin")
                {
                    string curUser = textBoxUsername.Text;
                    AdminPasswordForm passform = new AdminPasswordForm();
                    this.Hide();
                    passform.Show();
                }
                else
                {
                    userFound = false;
                    for (int i = 0; i < users.Count; i++)
                    {
                        if (textBoxUsername.Text == users[i])
                        {
                            string curUser = textBoxUsername.Text;
                            MainForm form3 = new MainForm(curUser, projects, customers, areas);
                            this.Hide();
                            form3.Show();
                            userFound = true;
                        }
                    }
                    if (userFound == false)
                    {
                        MessageBox.Show("Ошибка авторизации!\nНеверный логин!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                return;
            }
        }
    }
}

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
        public MainForm(string Username)
        {
            InitializeComponent();
            string curCustomer = null;
            string curArea = null;
            curUser = Username;
            textBoxCustomer.Text = "Выбранный заказчик: " + curCustomer;
            textBoxArea.Text = "Выбранная площадь: " + curArea;
            textBoxUser.Text = "Пользователь: " + curUser;
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
            ProjectDataForm form4 = new ProjectDataForm("пусто", curUser);//нужно изменить входные данные
            this.Hide();
            form4.Show();
        }
    }
}

﻿using System;
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
        public LoginForm()
        {
            InitializeComponent();
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
                if ((textBoxUsername.Text == "admin")&&(textBoxPassword.Text == "admin"))
                {
                    string curUser = textBoxUsername.Text;
                    MainForm form3 = new MainForm(curUser);
                    this.Hide();
                    form3.Show();
                }
                else 
                {
                    MessageBox.Show("Ошибка авторизации!\nНеверный логин или пароль!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                return;
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {

        }
    }
}

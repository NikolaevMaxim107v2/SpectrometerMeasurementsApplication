﻿using SpectrometerMeasurementsApplication.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpectrometerMeasurementsApplication.Forms
{
    public partial class AddCustomerForm : Form
    {
        private List<MeasuringArea> areas = new List<MeasuringArea>();
        private List<Customer> customers = new List<Customer>();
        string curUser;
        List<Project> projectsList = new List<Project>();
        int last_id;
        public AddCustomerForm(int id,string Username, List<Project> projects, List<Customer> customerslist, List<MeasuringArea> areaslist)
        {
            InitializeComponent();
            curUser = Username;
            projectsList = projects;
            customers = customerslist;
            areas = areaslist;
            last_id = id;
        }

        private void AddCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm form3 = new MainForm(curUser, projectsList, customers, areas);
            this.Hide();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customers.Add(new Customer (last_id, textBoxName.Text, textBox1.Text, textBoxAddress.Text));
            MainForm form3 = new MainForm(curUser, projectsList, customers, areas);
            form3.customersList = customers;
            this.Hide();
            form3.Show();
        }
    }
}
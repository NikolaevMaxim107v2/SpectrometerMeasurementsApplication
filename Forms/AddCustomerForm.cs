﻿using Microsoft.Data.SqlClient;
using SpectrometerMeasurementsApplication.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpectrometerMeasurementsApplication.Forms
{
    public partial class AddCustomerForm : Form
    {
        private List<MeasuringArea> areas = new List<MeasuringArea>();
        private List<Customer> customers = new List<Customer>();
        public List<MeasuringAreaPointsCoords> areaPointsCoords = new List<MeasuringAreaPointsCoords>();
        public List<MeasuringAreaProfile> areaProfiles = new List<MeasuringAreaProfile>();
        public List<Operator> operators = new List<Operator>();
        public List<ProfilePointsCoords> profilePoints = new List<ProfilePointsCoords>();
        public List<Picket> pickets = new List<Picket>();
        public List<PicketCoords> picketCoordsList = new List<PicketCoords>();
        string curUser;
        List<Project> projectsList = new List<Project>();
        int last_id;
        private static string conn = "Data Source=localhost\\SQLEXPRESS;" +
            "Initial Catalog=NikolaevMD107v2_IndTask2;Integrated Security=True;trustServerCertificate=true";
        public AddCustomerForm(int id, string Username, List<Project> projects, List<Customer> customerslist, List<MeasuringArea> areaslist)
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
            form3.areaList = areas;
            form3.areaPointsCoords = areaPointsCoords;
            form3.areaProfiles = areaProfiles;
            form3.operators = operators;
            form3.profilePoints = profilePoints;
            form3.pickets = pickets;
            form3.picketCoordsList = picketCoordsList;
            this.Hide();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsPhoneNumber(textBox1.Text))
            {
                if (IsEmail(textBoxAddress.Text))
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(conn))
                        {
                            con.Open();
                            MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            string projectComStr = $"INSERT INTO Customer(CustomerName, Email, Phone)" +
                                $" VALUES ('{textBoxName.Text}', '{textBoxAddress.Text}', '{textBox1.Text}')";
                            SqlCommand projectCMD = new SqlCommand(projectComStr, con);
                            projectCMD.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Соединение закрыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        MainForm form3 = new MainForm(curUser, projectsList, customers, areas);
                        form3.customersList = customers;
                        form3.areaPointsCoords = areaPointsCoords;
                        form3.areaProfiles = areaProfiles;
                        form3.operators = operators;
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
                else
                {
                    MessageBox.Show("Введённый email имеет неверный формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введённый номер телефона имеет неверный формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool IsPhoneNumber(string input)
        {
            Match match = Regex.Match(input, @"^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$", RegexOptions.IgnoreCase);
            return match.Success;
        }
        bool IsEmail(string input)
        {
            if (!string.IsNullOrEmpty(input?.Trim()))
            {
                const string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
                var email = input.Trim().ToLowerInvariant();

                if (Regex.Match(email, pattern).Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

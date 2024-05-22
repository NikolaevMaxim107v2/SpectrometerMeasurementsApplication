using Microsoft.Data.SqlClient;
using SpectrometerMeasurementsApplication.Classes;
using SpectrometerMeasurementsApplication.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SpectrometerMeasurementsApplication
{
    public partial class AreaForm : Form
    {
        private string curUser;
        private List<Project> projects = new List<Project>();
        private List<MeasuringArea> areas = new List<MeasuringArea>();
        private List<Customer> customers = new List<Customer>();
        public List<MeasuringAreaPointsCoords> areaPointsCoords = new List<MeasuringAreaPointsCoords>();
        public List<MeasuringAreaProfile> areaProfiles = new List<MeasuringAreaProfile>();
        public List<Operator> operators = new List<Operator>();
        public List<ProfilePointsCoords> profilePoints = new List<ProfilePointsCoords>();
        public List<Picket> pickets = new List<Picket>();
        public List<PicketCoords> picketCoordsList = new List<PicketCoords>();
        private List<string> areasList = new List<string>();
        private List<string> pointsList = new List<string>();
        private List<string> profilesList = new List<string>();
        private Project currentProject;
        private int ind;
        private static string conn = "Data Source=localhost\\SQLEXPRESS;" +
                    "Initial Catalog=NikolaevMD107v2_IndTask2;Integrated Security=True;trustServerCertificate=true";
        public AreaForm(Project curProject, string Username, List<Project> projectslist, List<Customer> customerslist, List<MeasuringArea> areaslist)
        {
            InitializeComponent();
            currentProject = curProject;
            curUser = Username;
            projects = projectslist;
            customers = customerslist;
            areas = areaslist;
            foreach (MeasuringArea area in areas)
            {
                if (curProject.ProjectID == area.ProjectID)
                {
                    areasList.Add(area.AreaID + " | " + area.AreaName);
                }
            }
            ind = 0;
            foreach (MeasuringAreaProfile profile in areaProfiles)
            {
                if (profile.AreaID == ind)
                {
                    profilesList.Add(ind + " | " + "areaID: " + Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(" | ")[0]));
                }
            }
            comboBox1.DataSource = areasList;
            comboBox1.SelectedIndex = -1;
            comboBox2.DataSource = pointsList;
            comboBox3.DataSource = profilesList;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (profilesList.Count > 0)
            {
                ProfileForm form6 = new ProfileForm(comboBox3.SelectedItem.ToString(), currentProject, curUser, projects, customers, areas);
                form6.areaPointsCoords = areaPointsCoords;
                form6.areaProfiles = areaProfiles;
                form6.operators = operators;
                form6.profilePoints = profilePoints;
                form6.pickets = pickets;
                form6.picketCoordsList = picketCoordsList;
                this.Hide();
                form6.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProjectDataForm form4 = new ProjectDataForm(currentProject, curUser, projects, customers, areas);
            form4.areaPointsCoords = areaPointsCoords;
            form4.areaProfiles = areaProfiles;
            form4.operators = operators;
            form4.profilePoints = profilePoints;
            form4.pickets = pickets;
            form4.picketCoordsList = picketCoordsList;
            this.Hide();
            form4.Show();
        }

        private void AreaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddAreaPointsForm addAreaPointsForm = new AddAreaPointsForm(currentProject, curUser, projects, customers, areas);
            addAreaPointsForm.areaPointsCoords = areaPointsCoords;
            addAreaPointsForm.areaProfiles = areaProfiles;
            addAreaPointsForm.operators = operators;
            addAreaPointsForm.profilePoints = profilePoints;
            addAreaPointsForm.pickets = pickets;
            addAreaPointsForm.picketCoordsList = picketCoordsList;
            this.Hide();
            addAreaPointsForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            areaProfiles = new List<MeasuringAreaProfile>();
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();
                    MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    string projectComStr = $"INSERT INTO MeasuringAreaProfile(AreaID) VALUES ({Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(" | ")[0])})";
                    SqlCommand projectCMD = new SqlCommand(projectComStr, con);
                    projectCMD.ExecuteNonQuery();
                    string profilesComStr = $"SELECT ProfileID, AreaID from MeasuringAreaProfile";
                    SqlCommand profilesCMD = new SqlCommand(profilesComStr, con);
                    SqlDataReader profilesReader = profilesCMD.ExecuteReader();
                    if (profilesReader.HasRows)
                        while (profilesReader.Read())
                        {
                            areaProfiles.Add(new MeasuringAreaProfile(profilesReader.GetInt32(0), profilesReader.GetInt32(1)));
                            profilesList.Add(profilesReader.GetInt32(0) + " | " + "areaID: " + profilesReader.GetInt32(1));
                        }
                    profilesReader.Close();
                    con.Close();
                    MessageBox.Show("Соединение закрыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    comboBox3.DataSource = null;
                    comboBox3.DataSource = profilesList;
                    comboBox3.SelectedIndex = 0;
                    MessageBox.Show("Успешное добавление!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления! {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = null;
            comboBox3.DataSource = null;
            pointsList.Clear();
            profilesList.Clear();
            if (comboBox1.SelectedIndex < 0)
                ind = -1;
            else
                ind = Convert.ToInt32(comboBox1.SelectedValue.ToString().Split(" | ")[0]);
            foreach (MeasuringAreaPointsCoords point in areaPointsCoords)
            {
                if (point.AreaID == ind)
                {
                    pointsList.Add(point.CoordsID + " | " + "X: " + point.CoordsX + " | " + "Y: " + point.CoordsY + " | " + "areaID: " + point.AreaID);
                }
            }
            foreach (MeasuringAreaProfile profile in areaProfiles)
            {
                if (profile.AreaID == ind)
                {
                    profilesList.Add(profile.ProfileID + " | " + "areaID: " + profile.AreaID);
                }
            }
            comboBox2.DataSource = pointsList;
            if (pointsList.Count <= 0)
                comboBox2.SelectedIndex = -1;
            else
                comboBox2.SelectedIndex = 0;
            comboBox3.DataSource = profilesList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    if (comboBox2.SelectedItem != null)
                    {
                        con.Open();
                        MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        string projectComStr = $"DELETE MeasuringAreaPointsCoords WHERE CoordsID = {comboBox2.SelectedItem.ToString().Split(" | ")[0]}";
                        SqlCommand projectCMD = new SqlCommand(projectComStr, con);
                        projectCMD.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Соединение закрыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        MessageBox.Show("Успешное удаление!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    for (int j = 0; j < areaPointsCoords.Count; j++)
                        if (Convert.ToInt32(comboBox2.SelectedItem.ToString().Split(" | ")[0]) == areaPointsCoords[j].CoordsID)
                        {
                            areaPointsCoords.Remove(areaPointsCoords[j]);
                        }
                    for (int j = 0; j < pointsList.Count; j++)
                        if (pointsList[j] == comboBox2.SelectedItem.ToString())
                        {
                            pointsList.Remove(pointsList[j]);
                        }
                    comboBox2.DataSource = null;
                    comboBox2.Items.Remove(comboBox2.SelectedItem);
                    comboBox2.DataSource = pointsList;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    if (comboBox3.SelectedItem != null)
                    {
                        con.Open();
                        MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        string projectComStr = $"DELETE MeasuringAreaProfile WHERE ProfileID = {comboBox3.SelectedItem.ToString().Split(" | ")[0]}";
                        SqlCommand projectCMD = new SqlCommand(projectComStr, con);
                        projectCMD.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Соединение закрыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        MessageBox.Show("Успешное удаление!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    for (int j = 0; j < areaProfiles.Count; j++)
                        if (Convert.ToInt32(comboBox3.SelectedItem.ToString().Split(" | ")[0]) == areaProfiles[j].ProfileID)
                        {
                            areaProfiles.Remove(areaProfiles[j]);
                        }
                    for (int j = 0; j < profilesList.Count; j++)
                        if (profilesList[j] == comboBox3.SelectedItem.ToString())
                        {
                            profilesList.Remove(profilesList[j]);
                        }
                    comboBox3.DataSource = null;
                    comboBox3.Items.Remove(comboBox3.SelectedItem);
                    comboBox3.DataSource = profilesList;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AreaForm_Load(object sender, EventArgs e)
        {
            areaPointsCoords = new List<MeasuringAreaPointsCoords>();
            areaProfiles = new List<MeasuringAreaProfile>();
            try
            {
                MeasuringAreaPointsCoords point = null;
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();
                    //MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    string pointsComStr = $"SELECT CoordsID, CoordsX, CoordsY, AreaID from MeasuringAreaPointsCoords";
                    SqlCommand pointCMD = new SqlCommand(pointsComStr, con);
                    SqlDataReader pointsReader = pointCMD.ExecuteReader();
                    if (pointsReader.HasRows)
                        while (pointsReader.Read())
                        {
                            point = new MeasuringAreaPointsCoords(pointsReader.GetInt32(0), pointsReader.GetDecimal(1),
                                pointsReader.GetDecimal(2), pointsReader.GetInt32(3));
                            //MessageBox.Show("Заказчик считан", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            areaPointsCoords.Add(point);
                        }
                    pointsReader.Close();
                    string profilesComStr = $"SELECT ProfileID, AreaID from MeasuringAreaProfile";
                    SqlCommand profilesCMD = new SqlCommand(profilesComStr, con);
                    SqlDataReader profilesReader = profilesCMD.ExecuteReader();
                    if (profilesReader.HasRows)
                        while (profilesReader.Read())
                        {
                            areaProfiles.Add(new MeasuringAreaProfile(profilesReader.GetInt32(0), profilesReader.GetInt32(1)));
                        }
                    profilesReader.Close();
                    comboBox3.DataSource = profilesList;
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось считать все данные из БД, часть данных не будет отображена!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

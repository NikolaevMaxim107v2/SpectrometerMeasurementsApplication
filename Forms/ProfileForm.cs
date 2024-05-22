using Microsoft.Data.SqlClient;
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
using static System.Windows.Forms.DataFormats;

namespace SpectrometerMeasurementsApplication
{
    public partial class ProfileForm : Form
    {
        private string curUser;
        private string curProfile;
        private List<Project> projects = new List<Project>();
        private List<MeasuringArea> areas = new List<MeasuringArea>();
        private List<Customer> customers = new List<Customer>();
        public List<MeasuringAreaPointsCoords> areaPointsCoords = new List<MeasuringAreaPointsCoords>();
        public List<MeasuringAreaProfile> areaProfiles = new List<MeasuringAreaProfile>();
        public List<Operator> operators = new List<Operator>();
        public List<ProfilePointsCoords> profilePoints = new List<ProfilePointsCoords>();
        public List<Picket> pickets = new List<Picket>();
        public List<PicketCoords> picketCoordsList = new List<PicketCoords>();
        private List<string> operatorsList = new List<string>();
        private List<string> pointsList = new List<string>();
        private List<string> picketsList = new List<string>();
        private Project currentProject;
        private int ind;
        private static string conn = "Data Source=localhost\\SQLEXPRESS;" +
        "Initial Catalog=NikolaevMD107v2_IndTask2;Integrated Security=True;trustServerCertificate=true";
        public ProfileForm(string curprofile, Project curProject, string Username, List<Project> projectslist, List<Customer> customerslist, List<MeasuringArea> areaslist)
        {
            InitializeComponent();
            currentProject = curProject;
            curUser = Username;
            projects = projectslist;
            curProfile = curprofile;
            customers = customerslist;
            areas = areaslist;
            textBox1.Text = curprofile;
        }

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AreaForm form5 = new AreaForm(currentProject, curUser, projects, customers, areas);
            form5.areaPointsCoords = areaPointsCoords;
            form5.areaProfiles = areaProfiles;
            form5.operators = operators;
            form5.profilePoints = profilePoints;
            form5.pickets = pickets;
            form5.picketCoordsList = picketCoordsList;
            this.Hide();
            form5.Show();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            operators = new List<Operator>();
            profilePoints = new List<ProfilePointsCoords>();
            pickets = new List<Picket>();
            try
            {
                Operator _operator = null;
                ProfilePointsCoords point = null;
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();
                    //MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    string operatorsComStr = $"SELECT OperatorID, OperatorName, OperatorSurname, Phone, Email from Operator";
                    SqlCommand operatorsCMD = new SqlCommand(operatorsComStr, con);
                    SqlDataReader operatorsReader = operatorsCMD.ExecuteReader();
                    if (operatorsReader.HasRows)
                        while (operatorsReader.Read())
                        {
                            _operator = new Operator(operatorsReader.GetInt32(0), operatorsReader.GetString(1),
                                operatorsReader.GetString(2), operatorsReader.GetString(3), operatorsReader.GetString(4));
                            //MessageBox.Show("Заказчик считан", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            operators.Add(_operator);
                        }
                    operatorsReader.Close();

                    string pointsComStr = $"SELECT CoordsID, CoordsX, CoordsY, ProfileID from ProfilePointsCoords";
                    SqlCommand pointCMD = new SqlCommand(pointsComStr, con);
                    SqlDataReader pointsReader = pointCMD.ExecuteReader();
                    if (pointsReader.HasRows)
                        while (pointsReader.Read())
                        {
                            point = new ProfilePointsCoords(pointsReader.GetInt32(0), pointsReader.GetDecimal(1),
                                pointsReader.GetDecimal(2), pointsReader.GetInt32(3));
                            //MessageBox.Show("Заказчик считан", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            profilePoints.Add(point);
                        }
                    pointsReader.Close();

                    string picketsComStr = $"SELECT PicketID, ProfileID, OperatorID from Picket";
                    SqlCommand picketsCMD = new SqlCommand(picketsComStr, con);
                    SqlDataReader picketsReader = picketsCMD.ExecuteReader();
                    if (picketsReader.HasRows)
                        while (picketsReader.Read())
                        {
                            //MessageBox.Show("Заказчик считан", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            pickets.Add(new Picket(picketsReader.GetInt32(0), picketsReader.GetInt32(1),
                                picketsReader.GetInt32(2)));
                        }
                    picketsReader.Close();

                    string picketsCoordsComStr = $"SELECT CoordsID, PicketID, CoordsX, CoordsY from PicketCoords";
                    SqlCommand picketsCoordsCMD = new SqlCommand(picketsCoordsComStr, con);
                    SqlDataReader picketsCoordsReader = picketsCoordsCMD.ExecuteReader();
                    if (picketsCoordsReader.HasRows)
                        while (picketsCoordsReader.Read())
                        {
                            //MessageBox.Show("Заказчик считан", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            picketCoordsList.Add(new PicketCoords(picketsCoordsReader.GetInt32(0), picketsCoordsReader.GetInt32(1),
                                picketsCoordsReader.GetDecimal(2), picketsCoordsReader.GetDecimal(3)));
                        }
                    picketsCoordsReader.Close();

                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось считать все данные из БД, часть данных не будет отображена!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ind = Convert.ToInt32(curProfile.ToString().Split(" | ")[0]);
            foreach (Operator op in operators)
            {
                operatorsList.Add(op.OperatorID + " | " + op.OperatorName + " | " + op.OperatorSurname + " | " + op.Phone + " | " + op.Email);
            }
            foreach (ProfilePointsCoords point in profilePoints)
            {
                if (point.ProfileID == ind)
                {
                    pointsList.Add(point.CoordsID + " | " + "X: " + point.CoordsX + " | " + "Y: " + point.CoordsY + " | " + "profileID: " + point.ProfileID);
                }
            }
            for (int j = 0; j < pickets.Count; j++)
            {
                if (pickets[j].ProfileID == ind)
                {
                    picketsList.Add(pickets[j].ProfileID + " | " + pickets[j].PicketID + " | " + "X: " + picketCoordsList[j].CoordsX + " | " + "Y: " + picketCoordsList[j].CoordsY);
                }
            }
            comboBox1.DataSource = operatorsList;
            comboBox2.DataSource = pointsList;
            comboBox3.DataSource = picketsList;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddOperatorForm addOperatorForm = new AddOperatorForm(curProfile, currentProject, curUser, projects, customers, areas);
            addOperatorForm.areaPointsCoords = areaPointsCoords;
            addOperatorForm.areaProfiles = areaProfiles;
            addOperatorForm.operators = operators;
            addOperatorForm.profilePoints = profilePoints;
            addOperatorForm.pickets = pickets;
            addOperatorForm.picketCoordsList = picketCoordsList;
            this.Hide();
            addOperatorForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    if (comboBox1.SelectedItem != null)
                    {
                        con.Open();
                        MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        string projectComStr = $"DELETE Operator WHERE OperatorID = {comboBox1.SelectedItem.ToString().Split(" | ")[0]}";
                        SqlCommand projectCMD = new SqlCommand(projectComStr, con);
                        projectCMD.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Соединение закрыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        MessageBox.Show("Успешное удаление!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    for (int j = 0; j < operators.Count; j++)
                        if (Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(" | ")[0]) == operators[j].OperatorID)
                        {
                            operators.Remove(operators[j]);
                        }
                    for (int j = 0; j < operatorsList.Count; j++)
                        if (operatorsList[j] == comboBox1.SelectedItem.ToString())
                        {
                            operatorsList.Remove(operatorsList[j]);
                        }
                    comboBox1.DataSource = null;
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                    comboBox1.DataSource = operatorsList;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddProfilePointForm addProfilePointForm = new AddProfilePointForm(curProfile, currentProject, curUser, projects, customers, areas);
            addProfilePointForm.areaPointsCoords = areaPointsCoords;
            addProfilePointForm.areaProfiles = areaProfiles;
            addProfilePointForm.operators = operators;
            addProfilePointForm.profilePoints = profilePoints;
            addProfilePointForm.pickets = pickets;
            addProfilePointForm.picketCoordsList = picketCoordsList;
            this.Hide();
            addProfilePointForm.ShowDialog();
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
                        string projectComStr = $"DELETE ProfilePointsCoords WHERE CoordsID = {comboBox2.SelectedItem.ToString().Split(" | ")[0]}";
                        SqlCommand projectCMD = new SqlCommand(projectComStr, con);
                        projectCMD.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Соединение закрыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        MessageBox.Show("Успешное удаление!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    for (int j = 0; j < profilePoints.Count; j++)
                        if (Convert.ToInt32(comboBox2.SelectedItem.ToString().Split(" | ")[0]) == profilePoints[j].CoordsID)
                        {
                            profilePoints.Remove(profilePoints[j]);
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
                        string projectComStr = $"DELETE PicketCoords WHERE PicketID = {comboBox3.SelectedItem.ToString().Split(" | ")[1]}";
                        SqlCommand projectCMD = new SqlCommand(projectComStr, con);
                        projectCMD.ExecuteNonQuery();
                        projectComStr = $"DELETE Picket WHERE PicketID = {comboBox3.SelectedItem.ToString().Split(" | ")[1]}";
                        projectCMD = new SqlCommand(projectComStr, con);
                        projectCMD.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Соединение закрыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        MessageBox.Show("Успешное удаление!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    for (int j = 0; j < pickets.Count; j++)
                        if (Convert.ToInt32(comboBox3.SelectedItem.ToString().Split(" | ")[0]) == pickets[j].ProfileID)
                        {
                            pickets.Remove(pickets[j]);
                            picketCoordsList.Remove(picketCoordsList[j]);
                        }
                    for (int j = 0; j < picketsList.Count; j++)
                        if (picketsList[j] == comboBox3.SelectedItem.ToString())
                        {
                            picketsList.Remove(picketsList[j]);
                        }
                    comboBox3.DataSource = null;
                    comboBox3.Items.Remove(comboBox3.SelectedItem);
                    comboBox3.DataSource = picketsList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления! {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPicketForm addPicketForm = new AddPicketForm(curProfile, currentProject, curUser, projects, customers, areas);
            addPicketForm.areaPointsCoords = areaPointsCoords;
            addPicketForm.areaProfiles = areaProfiles;
            addPicketForm.operators = operators;
            addPicketForm.profilePoints = profilePoints;
            addPicketForm.pickets = pickets;
            addPicketForm.picketCoordsList = picketCoordsList;
            this.Hide();
            addPicketForm.ShowDialog();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox3.DataSource = null;
            picketsList.Clear();
            ind = Convert.ToInt32(curProfile.ToString().Split(" | ")[0]);
            for (int j = 0; j < pickets.Count; j++)
            {
                if (pickets[j].ProfileID == ind)
                {
                    picketsList.Add(pickets[j].ProfileID + " | " + pickets[j].PicketID + " | " + "X: " + picketCoordsList[j].CoordsX + " | " + "Y: " + picketCoordsList[j].CoordsY);
                }
            }
            comboBox3.DataSource = picketsList;
        }
    }
}

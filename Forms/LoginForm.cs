using SpectrometerMeasurementsApplication.Classes;
using SpectrometerMeasurementsApplication.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;

namespace SpectrometerMeasurementsApplication
{
    public partial class LoginForm : Form
    {
        public static List<Project> projects = new List<Project>();
        public static List<MeasuringArea> areas = new List<MeasuringArea>();
        public static Customer curCustomer;
        public static Operator curOperator;
        public static List<Customer> customers = new List<Customer>();
        private static string conn = "Data Source=localhost\\SQLEXPRESS;" +
            "Initial Catalog=NikolaevMD107v2_IndTask2;Integrated Security=True;trustServerCertificate=true";
        public LoginForm()
        {
            InitializeComponent();
            //users.Add("User1");
            //users.Add("Nora");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxUsername.Text = null;
            curCustomer = null;
            curOperator = null;
            projects = new List<Project>();
            areas = new List<MeasuringArea>();
            customers = new List<Customer>();
        }

        public static void GetInfo(string email)
        {
            if (email != null && email != "")
            {
                Customer customer = null;
                Operator _operator = null;
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();
                    MessageBox.Show("Соединение открыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    string customerComStr = $"SELECT CustomerID, CustomerName, Email, Phone from Customer WHERE Email = '{email}'";
                    SqlCommand customerCMD = new SqlCommand(customerComStr, con);
                    SqlDataReader customerReader = customerCMD.ExecuteReader();
                    if (customerReader.HasRows)
                        while (customerReader.Read())
                        {
                            customer = new Customer(customerReader.GetInt32(0), customerReader.GetString(1), customerReader.GetString(2), customerReader.GetString(3));
                            //MessageBox.Show("Заказчик считан", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;
                        }
                    customerReader.Close();
                    curCustomer = customer;

                    string operatorComStr = $"SELECT OperatorID, OperatorName, OperatorSurname, Phone, Email from Operator WHERE Email = '{email}'";
                    SqlCommand operatorCMD = new SqlCommand(operatorComStr, con);
                    SqlDataReader operatorReader = operatorCMD.ExecuteReader();
                    if (operatorReader.HasRows)
                        while (operatorReader.Read())
                        {
                            _operator = new Operator(operatorReader.GetInt32(0), operatorReader.GetString(1), operatorReader.GetString(2), operatorReader.GetString(3), operatorReader.GetString(4));
                            //MessageBox.Show("Оператор считан", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;
                        }
                    operatorReader.Close();
                    curOperator = _operator;
                    con.Close();
                    MessageBox.Show("Соединение закрыто", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (curCustomer != null)
                        MessageBox.Show("Заказчик: " + curCustomer.Email, "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (curOperator != null)
                        MessageBox.Show("Оператор: " + curOperator.Email, "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Введён неверный электронный адрес!\nНеверный логин!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GetInfo(textBoxUsername.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка инициализации БД!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxUsername.Text.ToLower() == "admin")
            {
                string curUser = textBoxUsername.Text;
                AdminPasswordForm passform = new AdminPasswordForm();
                this.Hide();
                passform.Show();
            }
            else
            {
                if ((curCustomer != null) && (curOperator == null))
                {
                    string curUser = curCustomer.CustomerName;
                    MainForm form3 = new MainForm(curUser, projects, customers, areas);
                    this.Hide();
                    form3.Show();
                }
                if (((curCustomer == null) && (curOperator != null)) || ((curCustomer != null) && (curOperator != null)))
                {
                    string curUser = curOperator.OperatorName + " " + curOperator.OperatorSurname;
                    MainForm form3 = new MainForm(curUser, projects, customers, areas);
                    this.Hide();
                    form3.Show();
                }
                if ((curCustomer == null) && (curOperator == null))
                    MessageBox.Show("Ошибка авторизации!\nНеверный логин!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

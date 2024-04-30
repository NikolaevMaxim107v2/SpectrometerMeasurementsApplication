namespace SpectrometerMeasurementsApplication
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            launchText.Text = "Здравствуйте!\nПожалуйста, войдите в профиль.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm form2 = new LoginForm();
            this.Hide();
            form2.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

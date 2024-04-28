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
    public partial class AreaForm : Form
    {
        public AreaForm()
        {
            InitializeComponent();
            textBoxAreaName.Text = "Empty";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProfileForm form6 = new ProfileForm();
            this.Hide();
            form6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProjectDataForm form4 = new ProjectDataForm("пусто", "admin");
            this.Hide();
            form4.Show();
        }

        private void AreaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

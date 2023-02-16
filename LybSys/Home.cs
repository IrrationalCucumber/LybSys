using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LybSys
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void si_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn registration = new SignIn();
            registration.ShowDialog();
        }

        private void su_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp registration = new SignUp();
            registration.ShowDialog();
        }
    }
}

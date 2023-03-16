using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LybSys
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //lblUser.Text = SignIn.userName();
        }

        private void booksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Book books = new Book();
            books.Show();
        }
    }
}

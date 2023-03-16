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
            Books books = new Books();
            books.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports report = new Reports();
            report.Show();
        }

        private void returnedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrowed borrow = new Borrowed();
            borrow.Show();
        }

        private void returnedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Returned returned = new Returned();
            returned.Show();
        }
    }
}

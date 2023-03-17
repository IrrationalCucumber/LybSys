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
    public partial class Borrower : Form
    {
        public Borrower()
        {
            InitializeComponent();
        }

        private void Borrower_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1Accounts.ACCOUNTS' table. You can move, or remove it, as needed.
            this.aCCOUNTSTableAdapter.Fill(this.database1Accounts.ACCOUNTS);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Show();
            this.Hide();
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.Show();
            this.Hide();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return rn = new Return();
            rn.Show();
            this.Hide();
        }
    }
}

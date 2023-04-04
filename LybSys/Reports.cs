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
    public partial class Reports : Form
    {
        SqlCommand cmd;
        SqlDataReader rd;
        SqlConnection cn;
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dDTransactions.TRANSACTIONS' table. You can move, or remove it, as needed.
            this.tRANSACTIONSTableAdapter1.Fill(this.dDTransactions.TRANSACTIONS);
            
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Class\DYBSYS32\LybSys\LybSys\Database1.mdf;Integrated Security=True");
            cn.Open();
            
            try
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [dbo].[TRANSACTIONS]", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
            catch (InvalidOperationException ex)
            {
                lbMessage.Text = "";
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [dbo].[TRANSACTIONS]", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
            catch(InvalidOperationException ex)
            {
                lbMessage.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrower borrow = new Borrower();
            borrow.Show();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btSort_Click(object sender, EventArgs e)
        {

            string date = dtp.Value.ToString();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [dbo].[TRANSACTIONS] where TransactionDate = '"+ dtp.Value +"'", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
           // }
           // catch (InvalidOperationException ex)
            //{
                lbMessage.Text = "";
            //}
        }
    }
}

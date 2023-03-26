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
    public partial class Borrower : Form
    {
        SqlCommand cmd;
        //SqlDataReader dr;
        SqlConnection cn;

        public Borrower()
        {
            InitializeComponent();
        }

        private void Borrower_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1Accounts.ACCOUNTS' table. You can move, or remove it, as needed.
            this.aCCOUNTSTableAdapter.Fill(this.database1Accounts.ACCOUNTS);
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Class\DYBSYS32\LybSys\LybSys\Database1.mdf;Integrated Security=True");
            cn.Open();
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
            string username = SignIn.AccountName;
            string type = "Add User";
            //string date = DateTime.Now.ToString();
            cmd = new SqlCommand("insert into TRANSACTIONS values(@username, @TransactionType, @TransactionDate)", cn);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("TransactionType", type);
            cmd.Parameters.AddWithValue("TransactionDate", DateTime.Now);
            cmd.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAccount update = new UpdateAccount();
            update.Show();
            this.Hide();
            string username = SignIn.AccountName;
            string type = "Update User";
            string date = DateTime.Now.ToString();
            cmd = new SqlCommand("insert into TRANSACTIONS values(@username, @TransactionType, @TransactionDate)", cn);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("TransactionType", type);
            cmd.Parameters.AddWithValue("TransactionDate", DateTime.Now);
            cmd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != string.Empty)
            {
                //cn.Open();
                cmd = new SqlCommand("delete from ACCOUNTS where bookID ='" + tbUsername.Text + "'", cn);
                string username = SignIn.AccountName;
                string type = "Add User";
                string date = DateTime.Now.ToString();
                cmd = new SqlCommand("insert into TRANSACTIONS values(@username, @TransactionType, @TransactionDate)", cn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("TransactionType", type);
                cmd.Parameters.AddWithValue("TransactionData", DateTime.Now);
                cmd.ExecuteNonQuery();
                //cn.Close();
                MessageBox.Show("The Account has been removed from the Library", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbMessage.Text = "Book not found in the Library";
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ACCOUNTS", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ACCOUNTS WHERE username = '" + tbUsername.Text + "'", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }
    }
}

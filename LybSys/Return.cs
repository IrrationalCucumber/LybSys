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
    public partial class Return : Form
    {
        SqlCommand cmd;
        SqlDataReader rd;
        SqlConnection cn;
        public Return()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == string.Empty)
            {
                tbSearch.Text = "....";
            }
            else
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from BOOKS WHERE bookTitle = '" + tbSearch.Text + "' OR" +
                    "bookId = '" + tbSearch.Text + "' OR" +
                    "bookAuthor '" + tbSearch.Text + "' OR" +
                    "bookGenre '" + tbSearch.Text + "' OR " +
                    "bookStatus '" + tbSearch.Text + "'", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookReturnDatabase.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.bookReturnDatabase.BOOKS);
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Class\DYBSYS32\LybSys\LybSys\Database1.mdf;Integrated Security=True");
            cn.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [dbo].[BOOKS] WHERE bookStatus='Available'", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
                {
                    cell = selectedCell;
                    break;
                }

                DataGridViewRow row = cell.OwningRow;
                tbBookId.Text = row.Cells[0].Value.ToString();
                tbBookTitle.Text = row.Cells[1].Value.ToString();
                tbBookAuthor.Text = row.Cells[2].Value.ToString();
                tbBookGenre.Text = row.Cells[3].Value.ToString();


            }

            catch (Exception ex)
            {
                lbMessage.Text = ex.Message;
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [dbo].[BOOKS] WHERE bookStatus ='Borrowed'", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
            lbMessage.Text = "";
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            if (tbBookId.Text != string.Empty || tbBookTitle.Text != string.Empty)
            {
                int bookID = Int32.Parse(tbBookId.Text);
                string bookTitle = tbBookTitle.Text;
                string username = SignIn.AccountName;
                string dateReturn = DateTime.Now.ToString();
                string bookStatus = "Available";
                string type = "Book Return";
                cn.Close();
                cn.Open();
                cmd = new SqlCommand("insert into RETURN values(@username,@bookId,@bookTitle,@dateReturn)", cn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("bookId", bookID);
                cmd.Parameters.AddWithValue("bookTitle", bookTitle);
                cmd.Parameters.AddWithValue("dateReturn", DateTime.Now);
                //update BOOKS database status
                cmd = new SqlCommand("update BOOKS " +
                    "set bookStatus='" + bookStatus + "'" +
                    "WHERE bookId='" + bookID + "'", cn);
                //add transaction aas borrow
                cmd = new SqlCommand("insert into TRANSACTIONS values(@username, @TransactionType, @TransactionDate)", cn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("TransactionType", type);
                cmd.Parameters.AddWithValue("TransactionDate", DateTime.Now);

                cmd.ExecuteNonQuery();
                //cn.Close();
                MessageBox.Show("Book has been Borrowed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbMessage.Text = "Please enter value in all field.";
            }
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrower borrower = new Borrower();
            borrower.Show();
            this.Hide();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.Show();
            this.Hide();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}

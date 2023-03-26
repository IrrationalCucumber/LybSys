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
    public partial class Borrow : Form
    {
        SqlDataReader dr;
        SqlConnection cn;
        SqlCommand cmd;
        public Borrow()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [dbo].[BOOKS] WHERE bookStatus='Available'", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Class\DYBSYS32\LybSys\LybSys\Database1.mdf;Integrated Security=True");
            cn.Open();
            // TODO: This line of code loads data into the 'bookBorrowDataset.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.bookBorrowDataset.BOOKS);
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
                tbBooKId.Text = row.Cells[0].Value.ToString();
                tbBookTitle.Text = row.Cells[1].Value.ToString();
                tbBookAuthor.Text = row.Cells[2].Value.ToString();
                tbBookGenre.Text = row.Cells[3].Value.ToString();


            }

            catch (Exception ex)
            {
                lbMessage.Text = ex.Message;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBorrow_Click(object sender, EventArgs e)
        {
            if (tbBooKId.Text != string.Empty || tbBookTitle.Text != string.Empty)          
                {
                    int bookID = Int32.Parse(tbBooKId.Text);
                    string bookTitle = tbBookTitle.Text;
                    string username = SignIn.AccountName;
                    //string dateBorrow= DateTime.Now.ToString();
                    string bookStatus = "Borrowed";
                    string type = "Borrow";
                    cn.Close();
                    cn.Open();
                    cmd = new SqlCommand("insert into BORROW values(@username,@bookId,@bookTitle,@dateBorrow)", cn);
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("bookId", bookID);
                    cmd.Parameters.AddWithValue("bookTitle", bookTitle);
                    cmd.Parameters.AddWithValue("dateBorrow", DateTime.Now);
                    //update BOOKS database status
                    cmd = new SqlCommand("update BOOKS " +
                        "set bookStatus='" + bookStatus + "'" +
                        "WHERE bookId='" + bookID + "'", cn);
                //add transaction aas borrow
                    cmd = new SqlCommand("insert into TRANSACTIONS values(@username, @TransactionType, @TransactionDate)", cn);
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("TransactionType", type);
                    cmd.Parameters.AddWithValue("TransactionDAte", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    //cn.Close();
                    MessageBox.Show("Book has been Borrowed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbMessage.Text = "Please enter value in all field.";
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
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
                    "bookGenre '"+tbSearch.Text +"' OR " +
                    "bookStatus '"+tbSearch.Text +"'", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
            
        }

        private void booksToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return rn = new Return();
            rn.Show();
            this.Hide();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();

        }
    }
}

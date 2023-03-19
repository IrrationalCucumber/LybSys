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
    public partial class Books : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection cn;
        public Books()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookDataset.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter1.Fill(this.bookDataset.BOOKS);
            // TODO: This line of code loads data into the 'database1DataSet.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.database1DataSet.BOOKS);
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Class\DYBSYS32\LybSys\LybSys\Database1.mdf;Integrated Security=True");
            cn.Open();
        }

        //ADD method for Books
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbBookID.Text != string.Empty || tbBookTItle.Text != string.Empty || tbBookAuthor.Text != string.Empty || tbBookGenre.Text != string.Empty)
            {
              cmd = new SqlCommand("select * from BOOKS where bookID='" + tbBookID.Text + "'", cn);
              dr = cmd.ExecuteReader();
                //if method for invalid input
              
                  if (dr.Read())
                  {
                    dr.Close();
                    lbMessage.Text = "Book already exist please try another ";
                  }
                  else
                  {
                        dr.Close();
                        int bookID = Int32.Parse(tbBookID.Text);
                        string bookTitle = tbBookTItle.Text;
                        string bookAuthor = tbBookAuthor.Text;
                        string bookGenre = tbBookGenre.Text;
                        string bookStatus = "Avalable";
                        cn.Close();
                        cn.Open();
                        cmd = new SqlCommand("insert into BOOKS values(@bookId,@bookTitle,@bookAuthor,@bookGenre,@bookStatus)", cn);
                        cmd.Parameters.AddWithValue("bookId", bookID);
                        cmd.Parameters.AddWithValue("bookTitle", bookTitle);
                        cmd.Parameters.AddWithValue("bookAuthor", bookAuthor);
                        cmd.Parameters.AddWithValue("bookGenre", bookGenre);
                        cmd.Parameters.AddWithValue("bookStatus", bookStatus);
                        //cmd = new SqlCommand("insert into TRANSACTIONS values(@bookId,@bookTitle,@dateAdded)", cn);
                        //cmd.Parameters.AddWithValue("bookId", bookID);
                        //cmd.Parameters.AddWithValue("bookTitle", bookTitle);
                        //cmd.Parameters.AddWithValue("dateAdded", DateTime.Now.ToString());

                        cmd.ExecuteNonQuery();
                    //cn.Close();
                    MessageBox.Show("Book has been added to the Library", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
                }
            else
            {
                lbMessage.Text = "Please enter value in all field.";
            }
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                tbBookID.Text = row.Cells[0].Value.ToString();
                tbBookTItle.Text = row.Cells[1].Value.ToString();
                tbBookAuthor.Text = row.Cells[2].Value.ToString();
                tbBookGenre.Text = row.Cells[3].Value.ToString();
                
            }
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrower borrow = new Borrower();
            borrow.Show();
            this.Hide();
        }

        private void borrowedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow borrowed = new Borrow();
            borrowed.Show();
            this.Hide();
        }

        private void returnedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return rtn = new Return();
            rtn.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        //UPDATE method for BOOKS
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbBookID.Text != string.Empty || tbBookTItle.Text != string.Empty || tbBookAuthor.Text != string.Empty || tbBookGenre.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from BOOKS where bookID='" + tbBookID.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    lbMessage.Text = "Username Already exist please try another ";
                }
                else
                {
                    dr.Close();
                    int bookID = Int32.Parse(tbBookID.Text);
                    string bookTitle = tbBookTItle.Text;
                    string bookAuthor = tbBookAuthor.Text;
                    string bookGenre = tbBookGenre.Text;
                    string bookStatus = "Avalable";
                    string date = DateTime.Now.ToString();
                    //cn.Close();
                    //cn.Open();
                    cmd = new SqlCommand("insert into BOOKS values(@bookId,@bookTitle,@bookAuthor,@bookgenre,@bookStatus)", cn);
                    cmd.Parameters.AddWithValue("bookId", bookID);
                    cmd.Parameters.AddWithValue("bookTitle", bookTitle);
                    cmd.Parameters.AddWithValue("bookAuthor", bookAuthor);
                    cmd.Parameters.AddWithValue("bookgenre", bookGenre);
                    cmd.Parameters.AddWithValue("bookStatus", bookStatus);
                    cmd = new SqlCommand("insert into TRANSACTION values(@bookId,@bookTitle,@dateAdded)", cn);
                    cmd.Parameters.AddWithValue("bookId", bookID);
                    cmd.Parameters.AddWithValue("bookTitle", bookTitle);
                    cmd.Parameters.AddWithValue("dateAdded", date);

                    cmd.ExecuteNonQuery();
                    //cn.Close();
                    MessageBox.Show("Book information has been updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                lbMessage.Text = "Please enter value in all field.";
            }
        }
        
        //DELETE method for books
        private void btDelete_Click(object sender, EventArgs e)
        {
            //if book ID user knows
            if (tbBookID.Text != string.Empty)
            {
                //cn.Open();
                cmd = new SqlCommand("delete from BOOKS where bookID ='" + tbBookID.Text + "'", cn);
                cmd.ExecuteNonQuery();
                //cn.Close();
                MessageBox.Show("The Book has been removed from the Library", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbMessage.Text = "Book not found in the Library";
            }

            //if book title user only knows
            if (tbBookTItle.Text != string.Empty)
            {
                String bookTitle = tbBookTItle.Text;
                String date = DateTime.Now.ToString();
                cmd = new SqlCommand("delete from BOOKS where bookTitle ='" + tbBookTItle.Text + "'", cn);
                cmd = new SqlCommand("insert into TRANSACTIONS values(@bookTitle,@dateRemoved)", cn);
                //cmd.Parameters.AddWithValue("bookId", bookID);
                cmd.Parameters.AddWithValue("bookTitle", bookTitle);
                cmd.Parameters.AddWithValue("dateRemoved", date);
                cmd.ExecuteNonQuery();
                //cn.Close();
                MessageBox.Show("The Book has been removed from the Library", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbMessage.Text = "Book not found in the Library";
            }
        }

        private void tbBookID_TextChanged(object sender, EventArgs e)
        {
            //int bookID = Int32.Parse(tbBookID.Text);
            cmd = new SqlCommand("select * from BOOKS where bookID='" + tbBookID.Text + "'", cn);
            //dr = cmd.ExecuteReader();
            
        }
    }



}//namespace


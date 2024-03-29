﻿using System;
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
            // TODO: This line of code loads data into the 'dDBooks.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.dDBooks.BOOKS);
            
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Class\DYBSYS32\LybSys\LybSys\Database1.mdf;Integrated Security=True");
            cn.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [dbo].[BOOKS]", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dgView.DataSource = dtbl;
        }

        //ADD method for Books
        private void btAdd_Click(object sender, EventArgs e)
        {
            //tbBookID.Text != string.Empty ||
            if ( tbBookTitle.Text != string.Empty || tbBookAuthor.Text != string.Empty || tbBookGenre.Text != string.Empty)
            {
                cn.Close();
                cn.Open();
              cmd = new SqlCommand("select * from BOOKS where bookTitle='" + tbBookTitle.Text + "'", cn);
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
                        //int bookID = Int32.Parse(tbBookID.Text);
                        string bookTitle = tbBookTitle.Text;
                        string bookAuthor = tbBookAuthor.Text;
                        string bookGenre = tbBookGenre.Text;
                        string bookStatus = "Available";
                    string username = SignIn.AccountName;
                    //string date = DateTime.Now.ToString();
                    string type = "Add Book";
                        cn.Close();
                        cn.Open();
                    //@@bookId,
                    cmd = new SqlCommand("insert into BOOKS values( @bookTitle,@bookAuthor,@bookGenre,@bookStatus)", cn);
                        //cmd.Parameters.AddWithValue("bookId", bookID);
                        cmd.Parameters.AddWithValue("bookTitle", bookTitle);
                        cmd.Parameters.AddWithValue("bookAuthor", bookAuthor);
                        cmd.Parameters.AddWithValue("bookGenre", bookGenre);
                        cmd.Parameters.AddWithValue("bookStatus", bookStatus);
                    cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into TRANSACTIONS values(@user, @TransactionType, @bookTitle, @TransactionDate)", cn);
                        cmd.Parameters.AddWithValue("user", username);
                        cmd.Parameters.AddWithValue("TransactionType", type);
                    cmd.Parameters.AddWithValue("bookTitle", bookTitle);
                    cmd.Parameters.AddWithValue("TransactionDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    cn.Close();
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
            
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
            if ( tbBookTitle.Text != string.Empty || tbBookAuthor.Text != string.Empty || tbBookGenre.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from BOOKS where bookTitle='" + tbBookTitle.Text + "' AND bookId ='"+ lbBookId.Text+"'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    int bookID = Int32.Parse(lbBookId.Text);
                    string bookTitle = tbBookTitle.Text;
                    string bookAuthor = tbBookAuthor.Text;
                    string bookGenre = tbBookGenre.Text;
                    string bookStatus = "";
                    string username = SignIn.AccountName;
                    string date = DateTime.Now.ToString();
                    string type = "Update Book";
                    if (rStatusB.Checked)
                    {
                        bookStatus = "Borrowed";
                    }
                    else if(rStatusA.Checked)
                    {
                        bookStatus = "Available";
                    }
                    //string date = DateTime.Now.ToString();
                    //cn.Close();
                    //cn.Open();
                    cmd = new SqlCommand("update BOOKS " +
                        "set bookTitle = '"+ bookTitle +"', "+
                        "bookAuthor='"+bookAuthor +"'," +
                        "bookgenre='" + bookGenre + "'," +
                        "bookStatus='" + bookStatus + "'" +
                        "WHERE bookId='" + bookID + "'", cn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into TRANSACTIONS values(@user, @TransactionType, @bookTitle, @TransactionDate)", cn);
                    cmd.Parameters.AddWithValue("user", username);
                    cmd.Parameters.AddWithValue("TransactionType", type);
                    cmd.Parameters.AddWithValue("bookTitle", bookTitle);
                    cmd.Parameters.AddWithValue("TransactionDate", DateTime.Now);

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
            if (lbBookId.Text != string.Empty)
            {
                //cn.Open();
                cmd = new SqlCommand("delete from BOOKS where bookID ='" + lbBookId.Text + "' AND bookTitle ='"+ tbBookTitle.Text +"'", cn);
                cmd.ExecuteNonQuery();
                //cn.Close();
                MessageBox.Show("The Book has been removed from the Library", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbMessage.Text = "Book not found in the Library";
            }

            //if book title user only knows
            if (tbBookTitle.Text != string.Empty)
            {
                //int bookID = Int32.Parse(tbBookID.Text);
                string bookTitle = tbBookTitle.Text;
                string username = SignIn.AccountName;
                string type = "Delete Book";
                //string date = DateTime.Now.ToString();
                cmd = new SqlCommand("delete from BOOKS where bookId ='" + lbBookId.Text + "' OR bookTitle = '"+ tbBookTitle.Text +"'", cn);
                cmd.ExecuteNonQuery();
                //@bookId
                cmd = new SqlCommand("insert into TRANSACTIONS values(@user, @TransactionType, @bookTitle, @TransactionDate)", cn);
                cmd.Parameters.AddWithValue("user", username);
                cmd.Parameters.AddWithValue("TransactionType", type);
                cmd.Parameters.AddWithValue("bookTitle", bookTitle);
                cmd.Parameters.AddWithValue("TransactionDate", DateTime.Now);
                cmd.ExecuteNonQuery();
                //cn.Close();
                MessageBox.Show("The Book has been removed from the Library", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbMessage.Text = "Book not found in the Library";
            }
        }

        //Search with book ID only
        private void tbBookID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [dbo].[BOOKS]", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dgView.DataSource = dtbl;
            lbMessage.Text = "";
            lbBookId.Text = "";
        }
        
        //search if book status is Available or Borrowed
        //need modification
        //wont list based on condition
 
        //search with TItle only
        private void tbBookTItle_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from BOOKS WHERE bookTitle = '" + tbBookTitle.Text + "'", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dgView.DataSource = dtbl;
        }

        private void tbBookAuthor_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from BOOKS WHERE bookAuthor = '" + tbBookAuthor.Text + "'", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dgView.DataSource = dtbl;
        }

        private void tbBookGenre_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from BOOKS WHERE bookGenre = '" + tbBookGenre.Text + "'", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dgView.DataSource = dtbl;
        }

        private void rStatusA_CheckedChanged(object sender, EventArgs e)
        {
            if (rStatusA.Checked)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from BOOKS WHERE bookStatus = 'Available'", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dgView.DataSource = dtbl;
            }
            
        }

        private void rStatusB_CheckedChanged(object sender, EventArgs e)
        {
            if (rStatusB.Checked)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from BOOKS WHERE NOT bookStatus = 'Available'", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dgView.DataSource = dtbl;
            }
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports rp = new Reports();
            rp.Show();
            this.Hide();
        }

        private void dgView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedCell in dgView.SelectedCells)
                {
                    cell = selectedCell;
                    break;
                }

                DataGridViewRow row = cell.OwningRow;
                lbBookId.Text = row.Cells[0].Value.ToString();
                tbBookTitle.Text = row.Cells[1].Value.ToString();
                tbBookAuthor.Text = row.Cells[2].Value.ToString();
                tbBookGenre.Text = row.Cells[3].Value.ToString();


            }

            catch (Exception ex)
            {
                lbMessage.Text = "";
            }
        
            //catch (NullReferenceException ex)
            //{
                //lbMessage.Text = ex.Message;
            //}
            
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrower br = new Borrower();
            br.Show();
            this.Hide();
        }
    }



}//namespace


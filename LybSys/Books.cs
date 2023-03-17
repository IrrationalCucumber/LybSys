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
            // TODO: This line of code loads data into the 'database1DataSet.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.database1DataSet.BOOKS);
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Class\DYBSYS32\LybSys\LybSys\Database1.mdf;Integrated Security=True");
            cn.Open();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbBookID.Text != string.Empty || tbBookTItle.Text != string.Empty || tbBookAuthor.Text != string.Empty || tbBookGenre.Text != string.Empty)
            {
              cmd = new SqlCommand("select * from BOOKS where bookID='" + tbBookID.Text + "'", cn);
              dr = cmd.ExecuteReader();
              if (dr.Read())
              {
                dr.Close();
                MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Borrower 
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
    }
}

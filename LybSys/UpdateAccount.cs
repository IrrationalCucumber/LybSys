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
    public partial class UpdateAccount : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection cn;
        public UpdateAccount()
        {
            InitializeComponent();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UpdateAccount_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Class\DYBSYS32\LybSys\LybSys\Database1.mdf;Integrated Security=True");
            cn.Open();
            tbUsername.Text = Borrower.Username;
            
        }

        private void tbNewPassword2_TextChanged(object sender, EventArgs e)
        {
            if (tbNewPassword2.Text != tbNewPassword1.Text)
            {
                lbUsernameMessage.Text = "Passowrds does not match";
            }
            else {
                lbUsernameMessage.Text = "";
            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (tbNewPassword1.Text != string.Empty || tbNewPassword2.Text != string.Empty || tbUsername.Text != string.Empty || tbOldPassword.Text != string.Empty)
            {
                if (tbNewPassword1.Text != tbOldPassword.Text)
                {
                    /*
                    cmd = new SqlCommand("select * from ACCOUNTS where username='" + tbUsername.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        lbUsernameMessage.Text = "Username Already exist please try another";
                    }
                    else
                    */
                    
                        //dr.Close();
                        string UserName = tbUsername.Text;
                        string Password = Cryptomining.Encrypt(tbNewPassword1.Text.ToString());
                        cn.Close();
                        cn.Open();
                        cmd = new SqlCommand("update ACCOUNTS" +
                            "set password = '"+ tbNewPassword1 +"'" +
                            "WHERE username = '"+ tbUsername +"'", cn);
                        //cmd.Parameters.AddWithValue("username", UserName);
                        //cmd.Parameters.AddWithValue("password", Password);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Your Account has been updated .\n Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Menu menu = new Menu();
                        menu.Show();
                    
                }
                else
                {
                    lbUsernameMessage.Text = "New password and old password must not be the same";
                }
            }
            else
            {
                lbUsernameMessage.Text = "Please enter value in all field.";
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Borrower borrower = new Borrower();
            borrower.Show();
            this.Hide();
        }

        private void lbUsernameMessage_Click(object sender, EventArgs e)
        {

        }
    }
}

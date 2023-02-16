using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LybSys
{
    public partial class SignUp : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public SignUp()
        {
            InitializeComponent();
        }
        private void SignUp_Load(object sender, EventArgs e)
                {
                    cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Class\DYBSYS32\LybSys\LybSys\Database1.mdf;Integrated Security=True");
                    cn.Open();
                }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbPassword1.Text != string.Empty || tbPassword2.Text != string.Empty || tbUsername.Text != string.Empty)
            {
                if (tbPassword2.Text == tbPassword1.Text)
                {
                    cmd = new SqlCommand("select * from ACCOUNTS where username='" + tbUsername.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        string UserName = tbUsername.Text;
                        string Password = Cryptomining.Encrypt(tbPassword1.Text.ToString());
                        cn.Close();
                        cn.Open();
                        cmd = new SqlCommand("insert into ACCOUNTS values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", UserName);
                        cmd.Parameters.AddWithValue("password", Password);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkSI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignIn registration = new SignIn();
            registration.ShowDialog();
        }
    }
}

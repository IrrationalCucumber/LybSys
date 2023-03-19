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
    public partial class SignIn : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        //string userName;
        public SignIn()
        {
            InitializeComponent();
        }
        private void SignIn_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Class\DYBSYS32\LybSys\LybSys\Database1.mdf;Integrated Security=True");
            cn.Open();
        }
        private void lnkSU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp registration = new SignUp();
            registration.ShowDialog();
        }
        //public static void userName() { } // for diplaying username
        private void btnSumbit_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text != string.Empty || tbUsername.Text != string.Empty)
            {
                string Password = "";
                bool IsExist = false;
                cn.Close();
                cn.Open();  
                cmd = new SqlCommand("select * from ACCOUNTS where username='" + tbUsername.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Password = dr.GetString(1);  //get the user password from db if the user name is exist in that.  
                    IsExist = true;
                    dr.Close();
                    //this.Hide();
                    //Home home = new Home();
                    //home.ShowDialog();
                }
                cn.Close();
                if (IsExist)  //if record exis in db , it will return true, otherwise it will return false  
                {
                        if (Cryptomining.Decrypt(Password).Equals(tbPassword.Text))
                        {
                            MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            //userName() = tbUsername.Text;
                            Menu menu = new Menu();
                            menu.ShowDialog();
                        }
                 }
                else
                {
                    dr.Close();
                    lbMessage.Text = "No Account avilable with this username and password ";
                }

            }
            else
            {
                lbMessage.Text = "Please enter value in all field.";
            }
        }

       
    }
}

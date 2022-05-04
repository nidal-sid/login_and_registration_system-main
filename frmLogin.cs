using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Login_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();



        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username = '" + txtUsername.Text + "' AND password = '" + textPassword.Text + "'";
            cmd = new OleDbCommand(login,con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                applycation app = new applycation();
                app.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please Try Again",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                textPassword.Text = "";
                textPassword.Focus();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Checkbx_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbx_show_password.Checked)
            {
                textPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '⌔';
            }

        }

        private void Clearlogin_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            textPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }


    }
}

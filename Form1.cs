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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }


        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || textPassword.Text == "" || txtConPassword.Text == "")
            {
                MessageBox.Show("Registration Failed. Please Enter Your Information",
                    "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textPassword.Text == txtConPassword.Text)
                {
                    con.Open();
                    string register = "INSERT INTO tbl_users VALUES('" + txtUsername.Text + "','" + textPassword.Text + "')";
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Your Account has been Successfully Creted", "Registration Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                { 
                    MessageBox.Show("Password dont Match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textPassword.Text = "";
                    txtConPassword.Text = "";
                    textPassword.Focus();
                }
            }        
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Checkbx_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbx_show_password.Checked)
            {
                textPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '⌔';
                txtConPassword.PasswordChar = '⌔';
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            textPassword.Text = "";
            txtConPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }
    }
}

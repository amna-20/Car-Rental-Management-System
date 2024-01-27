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

namespace carRental
{
    public partial class UserLoginPage : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CTUCD50\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True");

        public UserLoginPage()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your email was sent to admin. Wait for password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            passwordresetBox.Visible = false;
            signInBox.Visible = true;

        }

        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {
            signInBox.Visible = false;
            passwordresetBox.Visible = true;
        }

        private void signInLabel_Click(object sender, EventArgs e)
        {
            passwordresetBox.Visible = false;
            signInBox.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LoginOptions op = new LoginOptions();
            op.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String email, password;

            email = emailTextbox.Text;
            password = passwordTextbox.Text;

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM usersInfo WHERE Email=@Email AND Password=@Password", conn);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                UserDashBoardPage ub = new UserDashBoardPage();
                ub.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTextbox.Clear();
                passwordTextbox.Clear();
                emailTextbox.Focus();
            }

            dr.Close();
            conn.Close();
        }

        private void showPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            bool check = showPasswordCheck.Checked;
            switch (check)
            {
                case true:
                    {
                        passwordTextbox.UseSystemPasswordChar = true;
                    }
                    break;
                default:
                    {
                        passwordTextbox.UseSystemPasswordChar = false;
                    }
                    break;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace carRental
{
    public partial class AdminLoginPage : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CTUCD50\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True");
        public AdminLoginPage()
        {
            InitializeComponent();
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM adminInfo WHERE email=@email AND password=@password", conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                AdminDashBoardPage df = new AdminDashBoardPage();
                df.Show();
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

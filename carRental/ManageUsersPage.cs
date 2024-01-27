using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace carRental
{
    public partial class ManageUsersPage : Form
    {
        int selectedIndex = -1;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CTUCD50\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True");

        public ManageUsersPage()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminDashBoardPage dp = new AdminDashBoardPage();
            dp.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string queryCheck = "SELECT COUNT(*) FROM usersInfo WHERE Email = @Email";
            string queryInsert = "INSERT INTO usersInfo (UserID, Email, FullName, Password) VALUES (@UserID, @Email, @FullName, @Password)";

            using (SqlCommand commandCheck = new SqlCommand(queryCheck, conn))
            {
                commandCheck.Parameters.AddWithValue("@Email", emailTextBox.Text);

                conn.Open();
                int userCount = (int)commandCheck.ExecuteScalar();
                conn.Close();

                if (userCount > 0)
                {
                    MessageBox.Show("A user with this email already exists.");
                    return;
                }
            }

            using (SqlCommand commandInsert = new SqlCommand(queryInsert, conn))
            {
                commandInsert.Parameters.AddWithValue("@UserID", userIDTextBox.Text);
                commandInsert.Parameters.AddWithValue("@Email", emailTextBox.Text);
                commandInsert.Parameters.AddWithValue("@FullName", fullNameTextBox.Text);
                commandInsert.Parameters.AddWithValue("@Password", passwordTextBox.Text);

                conn.Open();
                commandInsert.ExecuteNonQuery();
                conn.Close();
            }


        }

        private void showButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM usersInfo", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            userInfoGridview.DataSource = dt;
            conn.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string queryUpdate = "UPDATE usersInfo SET Email = @Email, FullName = @FullName, Password = @Password, WHERE UserID = @UserID";
            using (SqlCommand commandUpdate = new SqlCommand(queryUpdate, conn))
            {
                commandUpdate.Parameters.AddWithValue("@UserID", userIDTextBox.Text);
                commandUpdate.Parameters.AddWithValue("@Email", emailTextBox.Text);
                commandUpdate.Parameters.AddWithValue("@FullName", fullNameTextBox.Text);
                commandUpdate.Parameters.AddWithValue("@Password", passwordTextBox.Text);

                conn.Open();
                commandUpdate.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM usersInfo WHERE UserID = @UserID";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@UserID", userIDTextBox.Text);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void userInfoGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedIndex = e.RowIndex;

                userIDTextBox.Text = userInfoGridview.Rows[selectedIndex].Cells["UserID"].Value.ToString();
                emailTextBox.Text = userInfoGridview.Rows[selectedIndex].Cells["Email"].Value.ToString();
                fullNameTextBox.Text = userInfoGridview.Rows[selectedIndex].Cells["FullName"].Value.ToString();
                passwordTextBox.Text = userInfoGridview.Rows[selectedIndex].Cells["Password"].Value.ToString();
            }

        }
    }
}

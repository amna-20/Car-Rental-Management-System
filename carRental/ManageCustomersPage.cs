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
    public partial class ManageCustomersPage : Form
    {
        int selectedIndex = -1;

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CTUCD50\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True");
        public ManageCustomersPage()
        {
            InitializeComponent();
        }

        public void HideCustomersData()
        {
            customersviewPanel.Hide();
            backButtonadmin.Hide();
            panel4.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminDashBoardPage dp = new AdminDashBoardPage();
            dp.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM customersInfo WHERE CustomerID = @CustomerID OR CNIC = @CNIC OR DrivingLicense = @DrivingLicense";

            using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn))
            {
                checkCommand.Parameters.AddWithValue("@CustomerID", customerIDTextBox.Text);
                checkCommand.Parameters.AddWithValue("@CNIC", cnicTextBox.Text);
                checkCommand.Parameters.AddWithValue("@DrivingLicense", drivLicenseTextBox.Text);

                conn.Open();
                int existingCount = (int)checkCommand.ExecuteScalar();
                conn.Close();

                if (existingCount > 0)
                {
                    MessageBox.Show("A customer with this ID, CNIC, or driving license already exists in the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string query = "INSERT INTO customersInfo (CustomerID, FullName, Address, MobileNum, CNIC, DrivingLicense) " +
                "VALUES (@CustomerID, @FullName, @Address, @MobileNum, @CNIC, @DrivingLicense)";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@CustomerID", customerIDTextBox.Text);
                command.Parameters.AddWithValue("@FullName", fullNameTextBox.Text);
                command.Parameters.AddWithValue("@Address", addressTextBox.Text);
                command.Parameters.AddWithValue("@MobileNum", mobNumTextBox.Text);
                command.Parameters.AddWithValue("@CNIC", cnicTextBox.Text);
                command.Parameters.AddWithValue("@DrivingLicense", drivLicenseTextBox.Text);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM customersInfo", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM customersInfo WHERE CustomerID = @CustomerID";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@CustomerID", customerIDTextBox.Text);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE customersInfo SET FullName = @FullName, Address = @Address, MobileNum = @MobileNum, CNIC = @CNIC, DrivingLicense = @DrivingLicense WHERE CustomerID = @CustomerID";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@CustomerID", customerIDTextBox.Text);
                command.Parameters.AddWithValue("@FullName", fullNameTextBox.Text);
                command.Parameters.AddWithValue("@Address", addressTextBox.Text);
                command.Parameters.AddWithValue("@MobileNum", mobNumTextBox.Text);
                command.Parameters.AddWithValue("@CNIC", cnicTextBox.Text);
                command.Parameters.AddWithValue("@DrivingLicense", drivLicenseTextBox.Text);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedIndex = e.RowIndex;

                customerIDTextBox.Text = dataGridView1.Rows[selectedIndex].Cells["CustomerID"].Value.ToString();
                fullNameTextBox.Text = dataGridView1.Rows[selectedIndex].Cells["FullName"].Value.ToString();
                addressTextBox.Text = dataGridView1.Rows[selectedIndex].Cells["Address"].Value.ToString();
                mobNumTextBox.Text = dataGridView1.Rows[selectedIndex].Cells["MobileNum"].Value.ToString();
                cnicTextBox.Text = dataGridView1.Rows[selectedIndex].Cells["CNIC"].Value.ToString();
                drivLicenseTextBox.Text = dataGridView1.Rows[selectedIndex].Cells["DrivingLicense"].Value.ToString();
            }
        }

        private void nextPageLabel_Click(object sender, EventArgs e)
        {
            ManageRentalCarsPage mrcp = new ManageRentalCarsPage();
            mrcp.Show();
            this.Hide();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM customersInfo", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void backButtonuser_Click(object sender, EventArgs e)
        {
            UserDashBoardPage udp = new UserDashBoardPage();
            udp.Show();
            this.Hide();
        }
    }
}

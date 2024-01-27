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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace carRental
{
    public partial class ManageCarsPage : Form
    {
        int selectedIndex = -1;

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CTUCD50\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True");
        public ManageCarsPage()
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
            string checkQuery = "SELECT COUNT(*) FROM carsInfo WHERE CarID = @CarID OR RegistrationNum = @RegistrationNum";

            using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn))
            {
                checkCommand.Parameters.AddWithValue("@CarID", carIDTextBox.Text);
                checkCommand.Parameters.AddWithValue("@RegistrationNum", regNumTextBox.Text);

                conn.Open();
                int existingCount = (int)checkCommand.ExecuteScalar();
                conn.Close();

                if (existingCount > 0)
                {
                    MessageBox.Show("A car with this ID or registration number already exists in the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string query = "INSERT INTO carsInfo (CarID, RegistrationNum, Brand, Model, PricePerDay, CarType, FuelType, Availability) " +
                "VALUES (@CarID, @RegistrationNum, @Brand, @Model, @PricePerDay, @CarType, @FuelType, @Availability)";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@CarID", carIDTextBox.Text);
                command.Parameters.AddWithValue("@RegistrationNum", regNumTextBox.Text);
                command.Parameters.AddWithValue("@Brand", brandTextBox.Text);
                command.Parameters.AddWithValue("@Model", modelTextBox.Text);
                command.Parameters.AddWithValue("@PricePerDay", pricePerDayTextBox.Text);
                command.Parameters.AddWithValue("@CarType", carTypeTextBox.Text);
                command.Parameters.AddWithValue("@FuelType", fuelTypeTextBox.Text);
                command.Parameters.AddWithValue("@Availability", availableTextBox.Text);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            ClearFields();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM carsInfo", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE carsInfo SET RegistrationNum = @RegistrationNum, Brand = @Brand, Model = @Model, " +
                "PricePerDay = @PricePerDay, CarType = @CarType, FuelType = @FuelType, Availability = @Availability WHERE CarID = @CarID";



            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@CarID", carIDTextBox.Text);
                command.Parameters.AddWithValue("@RegistrationNum", regNumTextBox.Text);
                command.Parameters.AddWithValue("@Brand", brandTextBox.Text);
                command.Parameters.AddWithValue("@Model", modelTextBox.Text);
                command.Parameters.AddWithValue("@PricePerDay", pricePerDayTextBox.Text);
                command.Parameters.AddWithValue("@CarType", carTypeTextBox.Text);
                command.Parameters.AddWithValue("@FuelType", fuelTypeTextBox.Text);
                command.Parameters.AddWithValue("@Availability", availableTextBox.Text);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(carIDTextBox.Text))
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this car record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM carsInfo WHERE CarID = @CarID";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@CarID", carIDTextBox.Text);

                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Car record deleted successfully.");
            }
            RefreshData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedIndex = e.RowIndex;

                carIDTextBox.Text = dataGridView1.Rows[selectedIndex].Cells["CarID"].Value.ToString();
                regNumTextBox.Text = dataGridView1.Rows[selectedIndex].Cells["RegistrationNum"].Value.ToString();
                brandTextBox.Text = dataGridView1.Rows[selectedIndex].Cells["Brand"].Value.ToString();
                modelTextBox.Text = dataGridView1.Rows[selectedIndex].Cells["Model"].Value.ToString();
                pricePerDayTextBox.Text = dataGridView1.Rows[selectedIndex].Cells["PricePerDay"].Value.ToString();
                carTypeTextBox.Text = dataGridView1.Rows[selectedIndex].Cells["CarType"].Value.ToString();
                fuelTypeTextBox.Text = dataGridView1.Rows[selectedIndex].Cells["FuelType"].Value.ToString();
                availableTextBox.Text = dataGridView1.Rows[selectedIndex].Cells["Availability"].Value.ToString();
            }
        }
        private void ClearFields()
        {
            carIDTextBox.Text = string.Empty;
            regNumTextBox.Text = string.Empty;
            carIDTextBox.Text = string.Empty;
            brandTextBox.Text = string.Empty;
            modelTextBox.Text = string.Empty;
            pricePerDayTextBox.Text = string.Empty;
            carTypeTextBox.Text = string.Empty;
            fuelTypeTextBox.Text = string.Empty;
            availableTextBox.Text = string.Empty;
        }
        private void RefreshData()
        {
            string query = "SELECT * FROM carsInfo";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}

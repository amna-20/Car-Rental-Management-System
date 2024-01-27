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
    public partial class ManageRentalCarsPage : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CTUCD50\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True");
        public ManageRentalCarsPage()
        {
            InitializeComponent();
        }

        public void HideRentalData()
        {
            rentalviewPanel.Hide();
            backButtonadmin.Hide();
            panel4.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminDashBoardPage dp = new AdminDashBoardPage();
            dp.Show();
            this.Hide();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string carType = carTypeComboBox.Text;
            string fuelType = fuelTypeComboBox.Text;

            string query = "SELECT * FROM carsInfo WHERE CarType = @CarType AND FuelType = @FuelType";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@CarType", carType);
                command.Parameters.AddWithValue("@FuelType", fuelType);

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                carsInfoGrid.DataSource = dt;
                conn.Close();
            }
            RefreshData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string carID = carIDTextBox.Text;
            string carType = carTypeComboBox.Text;
            string fuelType = fuelTypeComboBox.Text;

            string checkQuery = "SELECT COUNT(*) FROM rentCarsInfo WHERE CarID = @CarID";

            using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn))
            {
                checkCommand.Parameters.AddWithValue("@CarID", carID);

                conn.Open();
                int count = (int)checkCommand.ExecuteScalar();
                conn.Close();

                if (count > 0)
                {
                    MessageBox.Show("The desired car is already rented.");
                    return;
                }
            }

            string priceQuery = "SELECT PricePerDay FROM carsInfo WHERE CarID = @CarID";
            decimal pricePerDay;

            using (SqlCommand priceCommand = new SqlCommand(priceQuery, conn))
            {
                priceCommand.Parameters.AddWithValue("@CarID", carID);

                conn.Open();
                pricePerDay = (decimal)priceCommand.ExecuteScalar();
                conn.Close();
            }

            TimeSpan rentalPeriod = endDatePicker.Value - startDatePicker.Value;
            decimal totalPrice = rentalPeriod.Days * pricePerDay;

            switch (carType)
            {
                case "Family":
                    totalPrice += 50;
                    break;
                case "Sports":
                    totalPrice += 75;
                    break;
            }

            switch (fuelType)
            {
                case "Hybrid":
                    totalPrice += 30;
                    break;
                case "Electric":
                    totalPrice += 50;
                    break;
            }

            string query = "INSERT INTO rentCarsInfo (RentID, CustomerID, CarID, StartDate, EndDate, TotalPrice) " +
                "VALUES (@RentID, @CustomerID, @CarID, @StartDate, @EndDate, @TotalPrice)";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@RentID", rentIDTextBox.Text);
                command.Parameters.AddWithValue("@CustomerID", customerIDTextBox.Text);
                command.Parameters.AddWithValue("@CarID", carID);
                command.Parameters.AddWithValue("@StartDate", startDatePicker.Value);
                command.Parameters.AddWithValue("@EndDate", endDatePicker.Value);
                command.Parameters.AddWithValue("@TotalPrice", totalPrice);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            ClearFields();
            RefreshData();
        }
        private void RefreshData()
        {
            string query = "SELECT * FROM rentCarsInfo";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            rentCarsGrid.DataSource = dataTable;
        }

        private void carsInfoGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                carIDTextBox.Text = carsInfoGrid.Rows[e.RowIndex].Cells["CarID"].Value.ToString();
            }
        }

        private void generateBill_Click(object sender, EventArgs e)
        {
            RentBillPage rp = new RentBillPage();
            rp.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rentIDTextBox.Text))
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this car record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM rentCarsInfo WHERE RentId = @RentID";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@RentID", carIDTextBox.Text);

                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Car record deleted successfully.");
            }
            RefreshData();
        }

        private void ClearFields()
        {
            rentIDTextBox.Text = string.Empty;
            customerIDTextBox.Text = string.Empty;
            carIDTextBox.Text = string.Empty;
            startDatePicker.Value = DateTime.Today;
            endDatePicker.Value = DateTime.Today;
            carTypeComboBox.SelectedIndex = -1;
            fuelTypeComboBox.SelectedIndex = -1;
        }

        private void rentCarsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rentIDTextBox.Text = rentCarsGrid.Rows[e.RowIndex].Cells["RentID"].Value.ToString();
                customerIDTextBox.Text = rentCarsGrid.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
                carIDTextBox.Text = rentCarsGrid.Rows[e.RowIndex].Cells["CarID"].Value.ToString();
                startDatePicker.Text = rentCarsGrid.Rows[e.RowIndex].Cells["StartDate"].Value.ToString();
                endDatePicker.Text = rentCarsGrid.Rows[e.RowIndex].Cells["EndDate"].Value.ToString();
            }
        }

        private void backPageLabel_Click(object sender, EventArgs e)
        {
            ManageCustomersPage mcsp = new ManageCustomersPage();
            mcsp.Show();
            this.Hide();
        }

        private void nextPageLabel_Click(object sender, EventArgs e)
        {
            ManageReturnCarsPage mrtcp = new ManageReturnCarsPage();
            mrtcp.Show();
            this.Hide();
        }

        private void backButtonuser_Click(object sender, EventArgs e)
        {
            UserDashBoardPage udp = new UserDashBoardPage();
            udp.Show();
            this.Hide();
        }

        private void rentshow_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM rentCarsInfo";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }
    }
}

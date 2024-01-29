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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace carRental
{
    public partial class ManageReturnCarsPage : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CTUCD50\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True");

        public ManageReturnCarsPage()
        {
            InitializeComponent();
        }

        public void HideReturnData()
        {
            returnviewPanel.Hide();
            backButtonadmin.Hide();
            panel4.Hide();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            RefreshrentInfoGrid();
            RefreshreturnCarsGrid();
        }

        private void RefreshrentInfoGrid()
        {
            string query1 = "SELECT * FROM rentCarsInfo";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query1, conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            rentInfoGrid.DataSource = dataTable;
        }


        private void RefreshreturnCarsGrid()
        {
            string query2 = "SELECT * FROM returnCarsInfo";
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(query2, conn);
            DataTable dataTable1 = new DataTable();
            dataAdapter1.Fill(dataTable1);
            returnCarsGrid.DataSource = dataTable1;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string returnID = returnIDTextBox.Text;
            string rentID = rentIDTextBox.Text;
            string carID = carIDTextBox.Text;
            DateTime carReturnDate = returnDatePicker.Value;

            string delayFineQuery = "SELECT DelayFine FROM carsInfo WHERE CarID = @CarID";
            decimal delayFine;

            using (SqlCommand delayFineCommand = new SqlCommand(delayFineQuery, conn))
            {
                delayFineCommand.Parameters.AddWithValue("@CarID", carID);

                conn.Open();
                delayFine = (decimal)delayFineCommand.ExecuteScalar();
                conn.Close();
            }

            decimal remainPay = 0;
            decimal fine = 0;

            string rentInfoQuery = "SELECT EndDate, TotalPrice FROM rentCarsInfo WHERE RentID = @RentID AND CarID = @CarID";
            using (SqlCommand rentInfoCommand = new SqlCommand(rentInfoQuery, conn))
            {
                rentInfoCommand.Parameters.AddWithValue("@RentID", rentID);
                rentInfoCommand.Parameters.AddWithValue("@CarID", carID);

                conn.Open();
                SqlDataReader reader = rentInfoCommand.ExecuteReader();

                if (reader.Read())
                {
                    DateTime endDate = (DateTime)reader["EndDate"];
                    decimal totalPrice = (decimal)reader["TotalPrice"];

                    decimal halfPayment = totalPrice / 2;

                    if (endDate < carReturnDate)
                    {
                        TimeSpan delayPeriod = carReturnDate - endDate;
                        decimal delayFineTotal = delayFine * (decimal)delayPeriod.Days;

                        remainPay = halfPayment + delayFineTotal;

                        fine = delayFineTotal;
                    }
                    else
                    {
                        fine = 0;
                        remainPay = halfPayment;
                    }
                }

                conn.Close();  // Close the connection here
            }

            string insertQuery = "INSERT INTO returnCarsInfo (ReturnID, RentID, CarID, CarReturnDate, RemainPay, Fine) " +
                "VALUES (@ReturnID, @RentID, @CarID, @CarReturnDate, @RemainPay, @Fine)";

            using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
            {

                insertCommand.Parameters.AddWithValue("@RentID", rentID);
                insertCommand.Parameters.AddWithValue("@ReturnID", returnID);
                insertCommand.Parameters.AddWithValue("@CarID", carID);
                insertCommand.Parameters.AddWithValue("@CarReturnDate", carReturnDate);
                insertCommand.Parameters.AddWithValue("@RemainPay", remainPay);
                insertCommand.Parameters.AddWithValue("@Fine", fine);

                conn.Open();
                insertCommand.ExecuteNonQuery();
                conn.Close();
            }

            ClearFields();
            RefreshreturnCarsGrid();
        }
        private void ClearFields()
        {
            carIDTextBox.Text = string.Empty;
            rentIDTextBox.Text = string.Empty;
            returnIDTextBox.Text = string.Empty;
            returnDatePicker.Value = DateTime.Now;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rentIDTextBox.Text))
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string rentID = rentIDTextBox.Text;

                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CTUCD50\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True"))
                {
                    connection.Open();

                    string query = "DELETE FROM rentCarsInfo WHERE RentID = @RentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RentID", rentID);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record deleted successfully.");
                RefreshrentInfoGrid();
            }
        }

        private void generateBill_Click(object sender, EventArgs e)
        {
            ReturnBillPage rbp = new ReturnBillPage();
            rbp.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminDashBoardPage dp = new AdminDashBoardPage();
            dp.Show();
            this.Hide();
        }

        private void backPageLabel_Click(object sender, EventArgs e)
        {
            ManageRentalCarsPage mrcp = new ManageRentalCarsPage();
            mrcp.Show();
            this.Hide();
        }

        private void returnShow_Click(object sender, EventArgs e)
        {
            string query2 = "SELECT * FROM returnCarsInfo";
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(query2, conn);
            DataTable dataTable1 = new DataTable();
            dataAdapter1.Fill(dataTable1);
            dataGridView2.DataSource = dataTable1;
        }
    }
}

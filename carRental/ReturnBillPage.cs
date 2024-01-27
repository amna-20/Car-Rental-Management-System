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
    public partial class ReturnBillPage : Form
    {
        public ReturnBillPage()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void saveBillButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CTUCD50\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True"))
            {
                connection.Open();

                // Create a command to insert the data
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"
                        INSERT INTO rentalRecordInfo 
                        (CarReturnDate, RemainPay, Fine)
                        (@carReturnDate, @remainPay, @fine)";

                    command.Parameters.AddWithValue("@carReturnDate", carReturnedDateLabel.Text);
                    command.Parameters.AddWithValue("@remainPay", remainPayLabel.Text);
                    command.Parameters.AddWithValue("@fine", fineLabel.Text);

                    // Execute the command
                    command.ExecuteNonQuery();
                    MessageBox.Show("Record successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void viewBillButton_Click(object sender, EventArgs e)
        {
            string rentID = rentIDTextBox.Text;

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CTUCD50\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True"))
            {
                connection.Open();

                // Create a command to retrieve the data
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"
                    SELECT 
                        c.FullName, c.Address, c.MobileNum, c.CNIC, c.DrivingLicense,
                        car.RegistrationNum, car.Brand, car.Model, car.PricePerDay, car.CarType, car.FuelType,
                        r.StartDate, r.EndDate, r.TotalPrice,
                        ret.RemainPay, ret.Fine
                    FROM 
                        rentCarsInfo r
                    INNER JOIN 
                        customersInfo c ON r.CustomerID = c.CustomerID
                    INNER JOIN 
                        carsInfo car ON r.CarID = car.CarID
                    INNER JOIN
                        returnCarsInfo ret ON r.RentID = ret.RentID
                    WHERE 
                        r.RentID = @rentID";


                    command.Parameters.AddWithValue("@rentID", rentID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal totalPrice = Convert.ToDecimal(reader["TotalPrice"]);
                            decimal advancePayment = totalPrice / 2;

                            fullNameLabel.Text = reader["FullName"].ToString();
                            addressLabel.Text = reader["Address"].ToString();
                            mobNumLabel.Text = reader["MobileNum"].ToString();
                            cnicLabel.Text = reader["CNIC"].ToString();
                            driveLicenseLabel.Text = reader["DrivingLicense"].ToString();
                            regNumLabel.Text = reader["RegistrationNum"].ToString();
                            brandLabel.Text = reader["Brand"].ToString();
                            modelLabel.Text = reader["Model"].ToString();
                            pricePerDayLabel.Text = reader["PricePerDay"].ToString();
                            carTypeLabel.Text = reader["CarType"].ToString();
                            fuelTypeLabel.Text = reader["FuelType"].ToString();
                            rentDateLabel.Text = reader["Startdate"].ToString();
                            returnDateLabel.Text = reader["EndDate"].ToString();
                            remainPayLabel.Text = reader["RemainPay"].ToString();
                            fineLabel.Text = reader["Fine"].ToString();
                            advancePaymentLabel.Text = advancePayment.ToString();
                        }
                    }
                }
            }
        }
    }
}

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
    public partial class AdminDashBoardPage : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CTUCD50\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True");
        public bool isDrawerOpen = false;
        public AdminDashBoardPage()
        {
            InitializeComponent();

        }
        private void ToggleDrawer()
        {
            if (isDrawerOpen)
            {
                panelDrawer.Width = 0;
            }
            else
            {
                panelDrawer.Width = 360;
            }
        }

        private void btnToggleDrawerClose_Click(object sender, EventArgs e)
        {
            ToggleBack();
            btnToggleDrawerOpen.Visible = true;
        }
        private void ToggleBack()
        {
            if (isDrawerOpen)
            {
                panelDrawer.Width = 360;
            }
            else
            {
                panelDrawer.Width = 0;
            }
        }

        private void carsManageLabel_Click(object sender, EventArgs e)
        {
            ManageCarsPage mcp = new ManageCarsPage();
            mcp.Show();
            this.Hide();
        }

        private void manageCustomersLabel_Click(object sender, EventArgs e)
        {
            ManageCustomersPage mcsp = new ManageCustomersPage();
            mcsp.Show();
            this.Hide();
        }

        private void manageRentalLabel_Click(object sender, EventArgs e)
        {
            ManageRentalCarsPage mrcp = new ManageRentalCarsPage();
            mrcp.Show();
            this.Hide();
        }

        private void returnCarsLabel_Click(object sender, EventArgs e)
        {
            ManageReturnCarsPage mrtcp = new ManageReturnCarsPage();
            mrtcp.Show();
            this.Hide();
        }

        private void manageUsersLabel_Click(object sender, EventArgs e)
        {
            ManageUsersPage mup = new ManageUsersPage();
            mup.Show();
            this.Hide();
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            AdminLoginPage ln = new AdminLoginPage();
            ln.Show();
            this.Hide();
        }

        private void AdminDashBoardPage_Load(object sender, EventArgs e)
        {
            string rentCarsQuery = "Select Count(*) FROM rentCarsInfo";
            SqlDataAdapter rentCarsSda = new SqlDataAdapter(rentCarsQuery, conn);
            DataTable rentCarsDt = new DataTable();
            rentCarsSda.Fill(rentCarsDt);
            totalRentCarsLabel.Text = rentCarsDt.Rows[0][0].ToString();

            string returnedCarsQuery = "Select Count(*) FROM returnCarsInfo";
            SqlDataAdapter returnedCarsSda = new SqlDataAdapter(returnedCarsQuery, conn);
            DataTable returnedCarsDt = new DataTable();
            returnedCarsSda.Fill(returnedCarsDt);
            totalReturnCarsLabel.Text = returnedCarsDt.Rows[0][0].ToString();

            string totalCarsQuery = "Select Count(*) FROM carsInfo";
            SqlDataAdapter totalCarsSda = new SqlDataAdapter(totalCarsQuery, conn);
            DataTable totalCarsDt = new DataTable();
            totalCarsSda.Fill(totalCarsDt);
            totalCarsLabel.Text = totalCarsDt.Rows[0][0].ToString();

            string customersQuery = "Select Count(*) FROM customersInfo";
            SqlDataAdapter customersSda = new SqlDataAdapter(customersQuery, conn);
            DataTable customersDt = new DataTable();
            customersSda.Fill(customersDt);
            totalCustomersLabel.Text = customersDt.Rows[0][0].ToString();

            string usersQuery = "Select Count(*) FROM usersInfo";
            SqlDataAdapter usersSda = new SqlDataAdapter(usersQuery, conn);
            DataTable usersDt = new DataTable();
            usersSda.Fill(usersDt);
            totalUsersLabel.Text = usersDt.Rows[0][0].ToString();
        }

        private void btnToggleDrawerOpen_Click(object sender, EventArgs e)
        {
            ToggleDrawer();
            btnToggleDrawerOpen.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

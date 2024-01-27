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
    public partial class UserDashBoardPage : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CTUCD50\SQLEXPRESS;Initial Catalog=CarRentalDB;Integrated Security=True");
        public bool isDrawerOpen = false;

        public UserDashBoardPage()
        {
            InitializeComponent();
        }

        private void manageCustomersLabel_Click(object sender, EventArgs e)
        {
            ManageCustomersPage mcsp = new ManageCustomersPage();
            mcsp.Show();
            this.Hide();
            mcsp.HideCustomersData();
        }

        private void manageRentalLabel_Click(object sender, EventArgs e)
        {
            ManageRentalCarsPage mrcp = new ManageRentalCarsPage();
            mrcp.Show();
            this.Hide();
            mrcp.HideRentalData();
        }

        private void returnCarsLabel_Click(object sender, EventArgs e)
        {
            ManageReturnCarsPage mrtcp = new ManageReturnCarsPage();
            mrtcp.Show();
            this.Hide();
            mrtcp.HideReturnData();
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            UserLoginPage up = new UserLoginPage();
            up.Show();
            this.Hide();
        }

        private void btnToggleDrawerClose_Click(object sender, EventArgs e)
        {
            ToggleBack();
            btnToggleDrawerOpen.Visible = true;
        }

        private void btnToggleDrawerOpen_Click(object sender, EventArgs e)
        {
            ToggleDrawer();
            btnToggleDrawerOpen.Visible = false;
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

        private void UserDashBoardPage_Load(object sender, EventArgs e)
        {
            string rentCarsQuery = "Select Count(*) FROM rentCarsInfo";
            SqlDataAdapter rentCarsSda = new SqlDataAdapter(rentCarsQuery, conn);
            DataTable rentCarsDt = new DataTable();
            rentCarsSda.Fill(rentCarsDt);
            totalRentCarsLabel.Text = rentCarsDt.Rows[0][0].ToString();

            string returnedCarsQuery = "Select Count(*) FROM rentCarsInfo";
            SqlDataAdapter returnedCarsSda = new SqlDataAdapter(returnedCarsQuery, conn);
            DataTable returnedCarsDt = new DataTable();
            returnedCarsSda.Fill(returnedCarsDt);
            totalReturnCarsLabel.Text = returnedCarsDt.Rows[0][0].ToString();

            string customersQuery = "Select Count(*) FROM customersInfo";
            SqlDataAdapter customersSda = new SqlDataAdapter(customersQuery, conn);
            DataTable customersDt = new DataTable();
            customersSda.Fill(customersDt);
            totalCustomersLabel.Text = customersDt.Rows[0][0].ToString();
        }
    }
}

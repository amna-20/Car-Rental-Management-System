using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRental
{
    public partial class LoginOptions : Form
    {
        public LoginOptions()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void userImage_Click(object sender, EventArgs e)
        {
            UserLoginPage ul = new UserLoginPage();
            ul.Show();
            this.Hide();
        }

        private void LoginOptions_Load(object sender, EventArgs e)
        {

        }

        private void adminImage_Click(object sender, EventArgs e)
        {
            AdminLoginPage lf = new AdminLoginPage();
            lf.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblLoginToContinue_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtBoxEmail_PhoneNumber.Text == "admin" && txtBoxPass.Text == "admin")
            {
                frmDashboard dashboard = new frmDashboard();
                dashboard.Show();
                this.Close();
                //if admin is logged in, i think the system should open to dashboard and has access to all data of all user. i think.
            }
            //in this else if statement should be if it exist in the database, then open the dashboard of that user. if not, then show messagebox of invalid email/phone number or password.
            else if (txtBoxEmail_PhoneNumber.Text == null || txtBoxPass.Text == null)
            {
                MessageBox.Show("Please enter your email/phone number and password.");
            }
            else
            {
                MessageBox.Show("Invalid email/phone number or password. Please try again.");
            }

        }
    }
}

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
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (checkBoxAgree.Checked)
            {
                
                frmDashboard dashboard = new frmDashboard();
                dashboard.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Please agree to the terms and conditions.");
                return;
            }
            
        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
    }
}

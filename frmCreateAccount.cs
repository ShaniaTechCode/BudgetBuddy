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
            lblLogIn.Cursor = Cursors.Hand;
            guna2HtmlLabel4.Cursor = Cursors.Hand;
            guna2HtmlLabel10.Cursor = Cursors.Hand;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxFullName.Text) || string.IsNullOrEmpty(txtBoxEmail_PhoneNumber.Text) || string.IsNullOrEmpty(txtBoxUsername.Text) || string.IsNullOrEmpty(txtBoxPass.Text) || string.IsNullOrEmpty(txtBoxConfirmPass.Text))
            {
                MessageBox.Show("Please fill in all the required fields.","Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBoxPass.Text != txtBoxConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!checkBoxAgree.Checked)
            {
                MessageBox.Show("Please agree to the terms and conditions.", "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Account created successfully! You can now proceed to the system.", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
            this.Close();
        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
    }
}

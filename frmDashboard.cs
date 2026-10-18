using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
           // Display the Dashboard UserControl in the main content panel
           ucDashboard ctrl = new ucDashboard();
            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(ctrl);

          // Set the active button
            SetActive_Button(btnDashboard);
        }

        // Store the currently active button
        private Guna.UI2.WinForms.Guna2Button activeButton = null;

        // Highlight the selected button
        private void SetActive_Button(Guna.UI2.WinForms.Guna2Button selectedButton)
        {
            // List of navigation buttons
            Guna.UI2.WinForms.Guna2Button[] buttons =
            {
               btnDashboard,
               btnBudget,
               btnIncome,
               btnExpenses,
               btnAnalytics,
               btnSettings,
            };

            // Reset all buttons to default style
            foreach (var btn in buttons)
            {
                btn.FillColor = Color.Transparent;
                btn.BorderRadius = 15;
            }
            // Set the selected button as active
            activeButton = selectedButton;

            // Apply the active button style
            activeButton.FillColor = Color.FromArgb(56, 142, 80);
            activeButton.ForeColor = Color.White;
            activeButton.BorderRadius = 15;
        }
    }
}

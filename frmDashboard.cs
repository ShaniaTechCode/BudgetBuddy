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

            // Adjust the main content panel scrolling behavior.
            pnlMainContent.AutoScroll = true;
            pnlMainContent.AutoScrollMinSize = new Size(0, 1700);
            pnlMainContent.HorizontalScroll.Enabled = false;
            pnlMainContent.HorizontalScroll.Visible = false;
            pnlMainContent.HorizontalScroll.Maximum = 0;
        }

        // Loads a UserControl into the main content panel.
        private void LoadView(UserControl uc)
        {
            pnlMainContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(uc);
            uc.Visible = true;
            uc.BringToFront();
        }

        // Stores the currently active sidebar button.
        private Guna.UI2.WinForms.Guna2Button activeButton = null;

        // Updates the appearance of the selected navigation button.
        private void SetActive_Button(
            Guna.UI2.WinForms.Guna2Button selectedButton)
        {
            Guna.UI2.WinForms.Guna2Button[] buttons =
            {
                btnDashboard,
                btnBudget,
                btnIncome,
                btnExpenses,
                btnAnalytics,
                btnSettings
            };
            // Resets all navigation buttons to their default style.
            foreach (var btn in buttons)
            {
                btn.FillColor = Color.Transparent;
                btn.ForeColor = Color.White;
                btn.BorderRadius = 15;
            }
            // Highlights the selected button.
            activeButton = selectedButton;
            activeButton.FillColor = Color.FromArgb(56, 142, 80);
            activeButton.ForeColor = Color.White;
            activeButton.BorderRadius = 15;
        }

        // Displays the Dashboard view.
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadView(new ucDashboard());
            SetActive_Button(btnDashboard);
        }

        // Displays the Budget view.
        private void btnBudget_Click(object sender, EventArgs e)
        {
            LoadView(new ucBudget());
            SetActive_Button(btnBudget);
        }

        // Displays the Income view.
        private void btnIncome_Click(object sender, EventArgs e)
        {
            LoadView(new ucIncome());
            SetActive_Button(btnIncome);
        }

        // Displays the Expenses view.
        private void btnExpenses_Click(object sender, EventArgs e)
        {
            LoadView(new ucExpenses());
            SetActive_Button(btnExpenses);
        }

        // Displays the Analytics view.
        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            LoadView(new ucAnalytics());
            SetActive_Button(btnAnalytics);
        }

        // Displays the Settings view.
        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadView(new ucSettings());
            SetActive_Button(btnSettings);
        }
    }
}

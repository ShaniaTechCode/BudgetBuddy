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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Show the settings header and menu 
            pnlSettingsHeader.Visible = true;
            pnlSettingsMenu.Visible = true;

            // Set the active button
            SetActive_Button(btnSettings);
        }

        private void SetActive_Button(Guna.UI2.WinForms.Guna2Button selectedButton)
        {
            Guna.UI2.WinForms.Guna2Button[] buttons =
            {
               btnDashboard,
               btnBudget,
               btnIncome,
               btnExpenses,
               btnAnalytics,
               btnSettings,
            };

            foreach (var btn in buttons)
            {
                btn.FillColor = Color.Transparent;
                btn.BorderRadius = 15;
            }

            activeButton = selectedButton;

            activeButton.FillColor = Color.FromArgb(56, 142, 80);
            activeButton.ForeColor = Color.White;
            activeButton.BorderRadius = 15;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            // Show the Settings header, menu, and content panels
            pnlSettingsHeader.Visible = true;
            pnlSettingsMenu.Visible = true;
            pnlMainContentSettings.Visible = true;
            pnlContentSettings.Visible = true;

            // Clear the previous content
            pnlContentSettings.Controls.Clear();

            // Create and add the Account UserControl
            ucAccount ctrl = new ucAccount();
            ctrl.Dock = DockStyle.Fill;
            ctrl.Visible = true;
            pnlContentSettings.Controls.Add(ctrl);
            ctrl.BringToFront();

            // Set the active button
            SetActiveButton(btnAccount);
        }

        private Guna.UI2.WinForms.Guna2Button activeButton = null;

        private void SetActiveButton(Guna.UI2.WinForms.Guna2Button selectedButton)
        {
            Guna.UI2.WinForms.Guna2Button[] buttons =
            {
               btnAccount,
               btnPassword,
               btnNotifications,
               btnAbout
            };

            foreach (var btn in buttons)
            {
                btn.FillColor = Color.Transparent;
                btn.ForeColor = Color.FromArgb(80, 80, 80);
                btn.BorderRadius = 15;
            }

            activeButton = selectedButton;

            activeButton.FillColor = Color.FromArgb(102, 187, 106);
            activeButton.ForeColor = Color.White;
            activeButton.BorderRadius = 15;
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            // Show the Settings header, menu, and content panels
            pnlSettingsHeader.Visible = true;
            pnlSettingsMenu.Visible = true;
            pnlMainContentSettings.Visible = true;
            pnlContentSettings.Visible = true;

            // Clear the previous content
            pnlContentSettings.Controls.Clear();

            // Create and add the Password UserControl
            ucPassword ctrl = new ucPassword();
            ctrl.Dock = DockStyle.Fill;
            ctrl.Visible = true;
            pnlContentSettings.Controls.Add(ctrl);
            ctrl.BringToFront();

            // Set the active button
            SetActiveButton(btnPassword);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            // Show the Settings header, menu, and content panels
            pnlSettingsHeader.Visible = true;
            pnlSettingsMenu.Visible = true;
            pnlMainContentSettings.Visible = true;
            pnlContentSettings.Visible = true;

            // Clear the previous content
            pnlContentSettings.Controls.Clear();

            // Create and add the Notifications UserControl
            ucNotifications ctrl = new ucNotifications();
            ctrl.Dock = DockStyle.Fill;
            ctrl.Visible = true;
            pnlContentSettings.Controls.Add(ctrl);
            ctrl.BringToFront();

            // Set the active button
            SetActiveButton(btnNotifications);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // Show the Settings header, menu, and content panels
            pnlSettingsHeader.Visible = true;
            pnlSettingsMenu.Visible = true;
            pnlMainContentSettings.Visible = true;
            pnlContentSettings.Visible = true;

            // Clear the previous content
            pnlContentSettings.Controls.Clear();

            // Create and add the About UserControl
            ucAbout ctrl = new ucAbout();
            ctrl.Dock = DockStyle.Fill;
            ctrl.Visible = true;
            pnlContentSettings.Controls.Add(ctrl);
            ctrl.BringToFront();

            // Set the active button
            SetActiveButton(btnAbout);
        }
    }
}

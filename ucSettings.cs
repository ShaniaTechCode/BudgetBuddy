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
    public partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            InitializeComponent();

            // Shows the main Settings layout.
            pnlMainContentSettings.Visible = true;
            pnlSettingsHeader.Visible = true;
            pnlSettingsMenu.Visible = true;

            // Hides the content panel until a menu is selected.
            pnlContentSettings.Controls.Clear();
            pnlContentSettings.Visible = false;
        }

        // Loads the selected UserControl into the content panel.
        private void LoadView(UserControl uc)
        {
            pnlContentSettings.Controls.Clear();

            uc.Dock = DockStyle.Fill;
            uc.Visible = true;

            pnlContentSettings.Controls.Add(uc);
            pnlContentSettings.Visible = true;
            pnlContentSettings.BringToFront();
        }
        // Tracks the currently selected Settings button.
        private Guna.UI2.WinForms.Guna2Button activeSettingsButton = null;

        // Updates the appearance of the selected menu button.
        private void SetActiveButton(
            Guna.UI2.WinForms.Guna2Button selectedButton)
        {
            // Lists all Settings menu buttons.
            Guna.UI2.WinForms.Guna2Button[] buttons =
            {
                btnAccount,
                btnPassword,
                btnNotifications,
                btnAbout
            };

            // Resets the menu buttons to their default style.
            foreach (var btn in buttons)
            {
                btn.FillColor = Color.Transparent;
                btn.ForeColor = Color.FromArgb(80, 80, 80);
                btn.BorderRadius = 15;
            }

            // Highlights the selected button.
            activeSettingsButton = selectedButton;
            activeSettingsButton.FillColor =
                Color.FromArgb(102, 187, 106);
            activeSettingsButton.ForeColor = Color.White;
        }

        // Opens the Account settings.
        private void btnAccount_Click(object sender, EventArgs e)
        {
            LoadView(new ucAccount());
            SetActiveButton(btnAccount);
        }

        // Opens the Password settings.
        private void btnPassword_Click(object sender, EventArgs e)
        {
            LoadView(new ucPassword());
            SetActiveButton(btnPassword);
        }

        // Opens the Notifications settings.
        private void btnNotifications_Click(object sender, EventArgs e)
        {
            LoadView(new ucNotifications());
            SetActiveButton(btnNotifications);
        }

        // Opens the About section.
        private void btnAbout_Click(object sender, EventArgs e)
        {
            LoadView(new ucAbout());
            SetActiveButton(btnAbout);
        }
    }
}

        
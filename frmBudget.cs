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
    public partial class frmBudget : Form
    {
        public frmBudget()
        {
            InitializeComponent();
        }

        private void btnBudget_Click(object sender, EventArgs e)
        {   
            // Display the Budget UserControl 
            ucBudget ctrl = new ucBudget();
            pnlMainContentBudget.Controls.Clear();
            pnlMainContentBudget.Controls.Add(ctrl);

            // Set the active button
            SetActive_Button(btnBudget);
        }

        private Guna.UI2.WinForms.Guna2Button activeButton = null;

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
    }
}

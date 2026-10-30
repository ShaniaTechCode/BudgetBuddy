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
    public partial class frmExpenses : Form
    {
        public frmExpenses()
        {
            InitializeComponent();

            // Adjust the main content panel scrolling behavior.
            pnlMainContentExpenses.AutoScroll = true;
            pnlMainContentExpenses.AutoScrollMinSize = new Size(0, 1700);
            pnlMainContentExpenses.HorizontalScroll.Enabled = false;
            pnlMainContentExpenses.HorizontalScroll.Visible = false;
            pnlMainContentExpenses.HorizontalScroll.Maximum = 0;
        }
    }
}

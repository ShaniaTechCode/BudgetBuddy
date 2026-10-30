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

            pnlMainContentBudget.AutoScroll = true;
            pnlMainContentBudget.AutoScrollMinSize = new Size(0, 1200);
            pnlMainContentBudget.HorizontalScroll.Enabled = false;
            pnlMainContentBudget.HorizontalScroll.Visible = false;
            pnlMainContentBudget.HorizontalScroll.Maximum = 0;
        }
    }
}

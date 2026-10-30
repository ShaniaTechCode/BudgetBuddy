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
    public partial class frmAnalytics : Form
    {
        public frmAnalytics()
        {
            InitializeComponent();

            pnlMainContentAnalytics.AutoScroll = true;
            pnlMainContentAnalytics.AutoScrollMinSize = new Size(0, 1200);
            pnlMainContentAnalytics.HorizontalScroll.Enabled = false;
            pnlMainContentAnalytics.HorizontalScroll.Visible = false;
            pnlMainContentAnalytics.HorizontalScroll.Maximum = 0;
        }
    }
}

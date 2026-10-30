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
    public partial class frmIncome : Form
    {
        public frmIncome()
        {
            InitializeComponent();

            pnlMainContentIncome.AutoScroll = true;
            pnlMainContentIncome.AutoScrollMinSize = new Size(0, 1200);
            pnlMainContentIncome.HorizontalScroll.Enabled = false;
            pnlMainContentIncome.HorizontalScroll.Visible = false;
            pnlMainContentIncome.HorizontalScroll.Maximum = 0;
        }
    }
}

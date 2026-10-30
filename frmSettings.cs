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

            pnlMainContentSettings.AutoScroll = true;
            pnlMainContentSettings.AutoScrollMinSize = new Size(0, 1200);
            pnlMainContentSettings.HorizontalScroll.Enabled = false;
            pnlMainContentSettings.HorizontalScroll.Visible = false;
            pnlMainContentSettings.HorizontalScroll.Maximum = 0;
        }
    }
}

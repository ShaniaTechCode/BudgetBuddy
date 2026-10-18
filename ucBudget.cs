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
    public partial class ucBudget : UserControl
    {
        public ucBudget()
        {
            InitializeComponent();


            // Sample output
            dgvBudgetList.Rows.Add(
                "Food Budget",
                "2,000.00",
                "Monthly",
                "Sept 27, 2026"
                );
        }
    }
}

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
    public partial class ucIncome : UserControl
    {
        public ucIncome()
        {
            InitializeComponent();

            // Sample output
            dgvIncomeList.Rows.Add(
                "Allowance",
                "1,000.00",
                "Sept 27, 2026"
                );
        }
    }
}

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
    public partial class ucExpenses : UserControl
    {
        public ucExpenses()
        {
            InitializeComponent();

            // Sample output
            dgvExpenseList.Rows.Add(
                "Internet",
                "Bills",
                "1,000.00",
                "October 5, 2026"
                );
        }
    }
}

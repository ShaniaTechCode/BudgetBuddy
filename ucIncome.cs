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

            rbExpected.Size = new Size(100,100);
        }

        private void ucIncome_Load(object sender, EventArgs e)
        {

        }

        private void cbBudgetPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvIncomeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using BudgetBuddy;
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
        private CalculatorEngine calc = new CalculatorEngine();
        public ucIncome()
        {
            InitializeComponent();
            pnlCalcu.Visible = false;
            Calculator();
            datagridincome();


        }
        private void btnEqual_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtboxDisplay.Text = calc.Calculate();
            }
            catch (CalculatorException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // responsible for the calculator button click event btn# represents the number buttons on the calculator and btnDecimal represents the decimal button on the calculator aswell as the operation buttons for addition, subtraction, multiplication, and division
        public void Calculator()
        {
            Control[] dBtn = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0 };
            foreach (Control btn in dBtn)
            {
                btn.Click += Nbtn_click;
            }

            btnDecimal.Click += btnDecimal_Click;

            btnAdd.Click += (s, e) => OpBtn_click('+');
            btnMinus.Click += (s, e) => OpBtn_click('-');
            btnMultiply.Click += (s, e) => OpBtn_click('*');
            btnDivide.Click += (s, e) => OpBtn_click('/');
        }
        //responsible for checking the numbers entered into the calculator and parsing/formatting them to display correctly


        //responsible for the clear button click event
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtboxDisplay.Text = calc.Clear();
        }

        //for hiding or showing the calculator panel when the calculator button is clicked
        private void btnCalculator_Click_1(object sender, EventArgs e)
        {
            pnlCalcu.Visible = !pnlCalcu.Visible;
        }

        //responsible for the decimal button click event
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = calc.InputDecimal();
        }

        private void pnlDashboardHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {

        }

        //responsible for the operation button click events
        private void OpBtn_click(char op)
        {
            try
            {
                txtboxDisplay.Text = calc.InputOperator(op);
            }
            catch (CalculatorException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nbtn_click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = calc.InputDigit(((Control)sender).Text);
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            pnlCalcu.Visible = !pnlCalcu.Visible;
        }

        class Income
        {
            public string IncSource { get; set; }
            public decimal Amount { get; set; }
            public string IncPeriod { get; set; }
            public DateTime IncDate { get; set; }
            public string IncStatus { get; set; }
        }

        private List<Income> incomeList = new List<Income>();
        private Income IncInsert = null;

        private void datagridincome()
        {
            dgvIncomeList.Columns[0].DataPropertyName = "IncSource";
            dgvIncomeList.Columns[1].DataPropertyName = "Amount";
            dgvIncomeList.Columns[2].DataPropertyName = "IncPeriod";
            dgvIncomeList.Columns[3].DataPropertyName = "IncDate";
            dgvIncomeList.Columns[4].DataPropertyName = "IncStatus";

            dgvIncomeList.Columns[1].DefaultCellStyle.Format = "₱#,##0.00";
            dgvIncomeList.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";

            dgvIncomeList.AllowUserToAddRows = false;
            dgvIncomeList.ReadOnly = true;
            dgvIncomeList.RowHeadersVisible = false;
            dgvIncomeList.AutoGenerateColumns = false;
            dgvIncomeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            txtSearchIncome.TextChanged += (s, e) => refreshIncomeList();


        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSourceOfIncome.Text) || txtSourceOfIncome.Text.Trim() == "")
            {
                MessageBox.Show("please enter the name of the soource of income");
                return;
            }
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("please enter a valid amount");
                return;
            }
            if (cbIncomePeriod.SelectedItem == null)
            {
                MessageBox.Show("please select a period");
                return;
            }
            if(dtpIncomeDate.Value == null)
            {
                MessageBox.Show("please select a valid date");
                return;
            }
            if (rbExpected.Checked == false && rbReceived.Checked == false)
            {
                MessageBox.Show("please select a status");
                return;
            }
            if (IncInsert == null)
            {
                Income newIncome = new Income
                {
                    IncSource = txtSourceOfIncome.Text,
                    Amount = amount,
                    IncPeriod = cbIncomePeriod.SelectedItem.ToString(),
                    IncDate = dtpIncomeDate.Value.Date,
                    IncStatus = rbExpected.Checked ? "Expected" : "Received"
                };
                incomeList.Add(newIncome);
            }
            else
            {
                IncInsert.IncSource = txtSourceOfIncome.Text;
                IncInsert.Amount = amount;
                IncInsert.IncPeriod = cbIncomePeriod.SelectedItem.ToString();
                IncInsert.IncDate = dtpIncomeDate.Value;
                IncInsert.IncStatus = rbExpected.Checked ? "Expected" : "Received";
                IncInsert = null;
            }
            refreshIncomeList();
            btnAddIncome.Text = "+   ADD INCOME";
            clearIncomeFields();


        }
        private void inctotal()
        {
           decimal totalIncome = incomeList.Sum(income => income.Amount);
           if (totalIncome >= 1000000)
           {
                decimal millionIncome = totalIncome / 1000000;
                lblTotalIncome_Amount.Text = "P" + millionIncome.ToString("N2") + "M";
           }
           else if (totalIncome >= 1000)
           {
                decimal thousandIncome = totalIncome / 1000;
                lblTotalIncome_Amount.Text = "P" + thousandIncome.ToString("N2") + "K";
           }
           else
           {
                lblTotalIncome_Amount.Text = "P" + totalIncome.ToString("N2");
           }

           decimal recievedIncome = incomeList.Where(recieved => recieved.IncStatus == "Received").Sum(recieved => recieved.Amount);
           if (recievedIncome >= 1000000)
            {
                decimal millionIncome = recievedIncome / 1000000;
                lblReceivedIncome_Amount.Text = "P" + millionIncome.ToString("N2") + "M";
            }
            else if (recievedIncome >= 1000)
            {
                decimal thousandIncome = recievedIncome / 1000;
                lblReceivedIncome_Amount.Text = "P" + thousandIncome.ToString("N2") + "K";
            }
            else
            {
                lblReceivedIncome_Amount.Text = "P" + recievedIncome.ToString("N2");
            }

            decimal expectedIncome = incomeList.Where(expected => expected.IncStatus == "Expected").Sum(expected => expected.Amount);
            if (expectedIncome >= 1000000)
            {
                decimal millionIncome = expectedIncome / 1000000;
                lblExpectedIncome_Amount.Text = "P" + millionIncome.ToString("N2") + "M";
            }
            else if (expectedIncome >= 1000)
            {
                decimal thousandIncome = expectedIncome / 1000;
                lblExpectedIncome_Amount.Text = "P" + thousandIncome.ToString("N2") + "K";
            }
            else
            {
                lblExpectedIncome_Amount.Text = "P" + expectedIncome.ToString("N2");
            }
        }

        private void refreshIncomeList()
        {
            IEnumerable<Income> query = incomeList;
            string searchText = txtSearchIncome.Text.Trim();
            if (searchText != "")
            {
                query = query.Where(income => income.IncSource.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);
            }
            dgvIncomeList.DataSource = null;
            dgvIncomeList.DataSource = query.OrderByDescending(income => income.IncDate).ToList();

            inctotal();
        }

        private void clearIncomeFields()
        {
            txtSourceOfIncome.Clear();
            txtAmount.Clear();
            cbIncomePeriod.SelectedIndex = -1;
            dtpIncomeDate.Value = DateTime.Now;
            rbExpected.Checked = false;
            rbReceived.Checked = false;
        }

        private void dgvIncomeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Income selectedIncome = (Income)dgvIncomeList.Rows[e.RowIndex].DataBoundItem;
            string columnName = dgvIncomeList.Columns[e.ColumnIndex].Name;

            if (columnName == "Edit")
            {
                var result = MessageBox.Show("Are you sure you want to edit this income entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                IncInsert = selectedIncome;
                txtSourceOfIncome.Text = selectedIncome.IncSource;
                txtAmount.Text = selectedIncome.Amount.ToString();
                cbIncomePeriod.SelectedItem = selectedIncome.IncPeriod;
                dtpIncomeDate.Value = selectedIncome.IncDate;
                rbExpected.Checked = selectedIncome.IncStatus == "Expected";
                rbReceived.Checked = selectedIncome.IncStatus == "Received";
            }
            else if (columnName == "Delete")
            {
                var result = MessageBox.Show("Are you sure you want to delete this income entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    incomeList.Remove(selectedIncome);
                    refreshIncomeList();
                }
            }
        }
    }
}
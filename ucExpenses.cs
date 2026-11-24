using BudgetBuddy;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy
{
    public partial class ucExpenses : UserControl
    {
        private CalculatorEngine calc = new CalculatorEngine();
        public ucExpenses()
        {
            InitializeComponent();
            pnlCalcu.Visible = false;
            Calculator();
            Datagridcon();
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

        class expense
        {
            public string expName { get; set; }
            public string expcategory { get; set; }
            public decimal expAmount { get; set; }
            public DateTime expDate { get; set; }
            public string expstatus { get; set; }
        }

        private List<expense> expenses = new List<expense>();
        private expense editingexpenses = null;

        private void Datagridcon()
        {
            dgvExpenseList.Columns[0].DataPropertyName = "expName";
            dgvExpenseList.Columns[1].DataPropertyName = "expcategory";
            dgvExpenseList.Columns[2].DataPropertyName = "expAmount";
            dgvExpenseList.Columns[3].DataPropertyName = "expDate";
            dgvExpenseList.Columns[4].DataPropertyName = "expstatus";

            dgvExpenseList.Columns[2].DefaultCellStyle.Format = "₱#,##0.00";
            dgvExpenseList.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";

           
            dgvExpenseList.AllowUserToAddRows = false;
            dgvExpenseList.ReadOnly = true;
            dgvExpenseList.RowHeadersVisible = false;
            dgvExpenseList.AutoGenerateColumns = false;
            dgvExpenseList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            txtSearchExpense.TextChanged += (s, e) => RefreshGrid();
            cbFilterCategory.SelectedIndexChanged += (s, e) => RefreshGrid();

            cbFilterCategory.Items.Clear();
            cbFilterCategory.Items.Add("All");
            cbFilterCategory.Items.AddRange(cbCategory.Items.Cast<string>().ToArray());
            cbFilterCategory.SelectedIndex = 0;

        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExpenseName.Text)|| txtExpenseName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter an expense name.");
                return;
            }
            if (cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }
            if (!decimal.TryParse(txtExpensesAmount.Text, out decimal amount)|| amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }
            if (dtpExpensesDate.Value > DateTime.Today)
            {
                MessageBox.Show("Please select a valid date, nothing is free.");
                return;
            }
            if (rbPlanned.Checked == false && rbCompleted.Checked == false)
            {
                MessageBox.Show("Please select a status.");
                return;
            }
            if (editingexpenses == null)
            {
                expense newExpense = new expense
                {
                    expName = txtExpenseName.Text,
                    expcategory = cbCategory.SelectedItem.ToString(),
                    expAmount = amount,
                    expDate = dtpExpensesDate.Value.Date,
                    expstatus = rbPlanned.Checked ? "Planned" : "Completed"
                };
                expenses.Add(newExpense);
            }
            else
            {
                editingexpenses.expName = txtExpenseName.Text.Trim();
                editingexpenses.expcategory = cbCategory.SelectedItem.ToString();
                editingexpenses.expAmount = amount;
                editingexpenses.expDate = dtpExpensesDate.Value;
                editingexpenses.expstatus = rbPlanned.Checked ? "Planned" : "Completed";
                editingexpenses = null;
            }
            RefreshGrid();
            btnAddExpense.Text = "+   ADD EXPENSE";
            ClearForm();

        }
        private void RefreshGrid()
        {
            IEnumerable<expense> query = expenses;
            string searchText = txtSearchExpense.Text.Trim();
            if (searchText != "")
            {
                query = query.Where(x => x.expName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);
            }
            if (cbFilterCategory.SelectedItem != null && cbFilterCategory.SelectedItem.ToString() != "All")
            {
                query = query.Where(x => x.expcategory == cbFilterCategory.SelectedItem.ToString());
            }

            dgvExpenseList.DataSource = null;
            dgvExpenseList.DataSource = query.OrderByDescending(x => x.expDate).ToList();
        }
        private void ClearForm()
        {
            txtExpenseName.Clear();
            cbCategory.SelectedIndex = -1;
            txtExpensesAmount.Clear();
            dtpExpensesDate.Value = DateTime.Now;
            rbPlanned.Checked = false;
            rbCompleted.Checked = false;

        }

        private void dgvExpenseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            expense selected = (expense)dgvExpenseList.Rows[e.RowIndex].DataBoundItem;
            string colName = dgvExpenseList.Columns[e.ColumnIndex].Name;

            if (colName == "colDelete")
            {
                var result = MessageBox.Show("Delete \"" + selected.expName + "\"?",
                                             "Confirm delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    expenses.Remove(selected);
                    RefreshGrid();
                }
            }
            else if (colName == "colEdit" )
            {
                editingexpenses = selected;
                txtExpenseName.Text = selected.expName;
                cbCategory.SelectedItem = selected.expcategory;
                txtExpensesAmount.Text = selected.expAmount.ToString();
                dtpExpensesDate.Value = selected.expDate;
                rbPlanned.Checked = selected.expstatus == "Planned";
                rbCompleted.Checked = selected.expstatus == "Completed";
                btnAddExpense.Text = "Update Expense";
            }
        }
        //reminder for other me to use this  to display on dashboard charts and graphs
        //public List<expense> GetExpenses() {return expenses;}
    }
}
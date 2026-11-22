using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculator;

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
    }
}
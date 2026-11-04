using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BudgetBuddy
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            pnlCalcu.Visible = false;
            Calculator();
        }


        decimal num1 = 0, num2 = 0, num3 = 0;
        string operation = null;
        bool startNewNumber = false;

        //responsible for the equal button click event/ the calculation of the numbers
        private void btnEqual_Click(object sender, EventArgs e)
        {
            {
                
                if (operation == null || num1 == 0)
                {
                    MessageBox.Show("Please enter valid numbers and operator");
                    return;
                }
                if (startNewNumber)
                {
                    MessageBox.Show("Please enter a second number.");
                    return;
                }

                num2 = ParseNumber(txtboxDisplay.Text);

                if (operation == "+")
                {
                    num3 = num1 + num2;
                }
                else if (operation == "-")
                {
                    num3 = num1 - num2;
                }
                else if (operation == "*")
                {
                    num3 = num1 * num2;
                }
                else if (operation == "/")
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    num3 = num1 / num2;
                }
                num1 = num3;
                operation = null;
                startNewNumber = true;

            }

            txtboxDisplay.Text = num3.ToString();
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
        private decimal ParseNumber(string text)
        {
            if (text.Contains("."))
            {
                return decimal.Parse(text, CultureInfo.InvariantCulture);
            }
            else
            {
                return int.Parse(text, CultureInfo.InvariantCulture);
            }
        }

        //responsible for the clear button click event
        private void btnClear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
            operation = null;
            txtboxDisplay.Text = "0";
            startNewNumber = false;
        }

        //for hiding or showing the calculator panel when the calculator button is clicked
        private void btnCalculator_Click(object sender, EventArgs e)
        {
            pnlCalcu.Visible = !pnlCalcu.Visible;
        }

        //responsible for the decimal button click event
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (startNewNumber)
            {
                txtboxDisplay.Text = "0.";
                startNewNumber = false;
            }
            else if (!txtboxDisplay.Text.Contains("."))
            {
                txtboxDisplay.Text += ".";
            }
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
            if (operation == null)
            {
                num1 = ParseNumber(txtboxDisplay.Text);
            }
            else if (!startNewNumber)
            {
                num2 = ParseNumber(txtboxDisplay.Text);
                if (operation == "+")
                {
                    num1 += num2;
                }
                else if (operation == "-")
                {
                    num1 -= num2;
                }
                else if (operation == "*")
                {
                    num1 *= num2;
                }
                else if (operation == "/")
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    num1 /= num2;
                }
            }

            operation = op.ToString();
            txtboxDisplay.Text = operation;
            startNewNumber = true;
        }

        
        private void Nbtn_click(object sender, EventArgs e)
        {
            string btnText = ((Control)sender).Text;

            if (txtboxDisplay.Text == "0" || startNewNumber)
            {
                txtboxDisplay.Text = btnText;
                startNewNumber = false;
            }
            else
            {
                txtboxDisplay.Text += btnText;
            }
        }
    }
}

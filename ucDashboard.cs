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
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            pnlCalcu.Visible = false;
            Calculator();
        }


        int num1 = 0, num2 = 0, num3 = 0;
        string operation;
        bool startNewNumber = false;
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (operation == null)
            {
                MessageBox.Show("Please select an operation.");
                return;
            }
            else if (operation == "+")
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

            txtboxDisplay.Text = num3.ToString();
        }

        public void Calculator()
        {
            Control[] dBtn = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0 };
            foreach (Control btn in dBtn)
            {
                btn.Click += Nbtn_click;
            }

            btnAdd.Click += (s, e) => OpBtn_click('+');
            btnMinus.Click += (s, e) => OpBtn_click('-');
            btnMultiply.Click += (s, e) => OpBtn_click('*');
            btnDivide.Click += (s, e) => OpBtn_click('/');
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
            operation = null;
            txtboxDisplay.Text = "0";
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            pnlCalcu.Visible = !pnlCalcu.Visible;
        }

        private void OpBtn_click(char op)
        {
            if (operation == null)
            {
                operation = op.ToString();
                txtboxDisplay.Text = operation;
                startNewNumber = true;
            }
            else
            {
                MessageBox.Show("Operation already completed. Please press clear.");
            }
        }

        private void Nbtn_click(object sender, EventArgs e)
        {
            string btnText = ((Control)sender).Text;
            
            if (txtboxDisplay.Text == "0" || startNewNumber == true)
            {
                txtboxDisplay.Text = btnText;
                startNewNumber = false;
            }
            else
            {
                txtboxDisplay.Text += btnText;
            }
            if (operation == null)
            {
                num1 = int.Parse(txtboxDisplay.Text);
            }
            else
            {
                num2 = int.Parse(txtboxDisplay.Text);
            }

        }
    }
}

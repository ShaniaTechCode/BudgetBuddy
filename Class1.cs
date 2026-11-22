using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy
{
    public class CalculatorException : Exception
    {
        public CalculatorException(string message) : base(message) { }
    }

    public class CalculatorEngine
    {
        private decimal num1 = 0, num2 = 0, num3 = 0;
        private string operation = null;
        private bool startNewNumber = false;
        private string display = "0";

        public string Display
        {
            get { return display; }
        }

        public string PendingOperation
        {
            get { return operation; }
        }

        public static decimal ParseNumber(string text)
        {
            if (text.Contains("."))
                return decimal.Parse(text, CultureInfo.InvariantCulture);

            return long.Parse(text, CultureInfo.InvariantCulture);
        }

        public static string FormatNumber(decimal number)
        {
            return Math.Round(number, 8).ToString("G29", CultureInfo.InvariantCulture);
        }

        public decimal Add(decimal a, decimal b) { return a + b; }
        public decimal Subtract(decimal a, decimal b) { return a - b; }
        public decimal Multiply(decimal a, decimal b) { return a * b; }

        public decimal Divide(decimal a, decimal b)
        {
            if (b == 0)
                throw new CalculatorException("Cannot divide by zero.");
            return a / b;
        }

        private decimal Compute(decimal a, decimal b, string op)
        {
            switch (op)
            {
                case "+": return Add(a, b);
                case "-": return Subtract(a, b);
                case "*": return Multiply(a, b);
                case "/": return Divide(a, b);
                default: throw new CalculatorException("Unknown operator.");
            }
        }

        public string InputDigit(string digit)
        {
            if (display == "0" || startNewNumber)
            {
                display = digit;
                startNewNumber = false;
            }
            else
            {
                display += digit;
            }
            return display;
        }

        public string InputDecimal()
        {
            if (startNewNumber)
            {
                display = "0.";
                startNewNumber = false;
            }
            else if (!display.Contains("."))
            {
                display += ".";
            }
            return display;
        }

        public string InputOperator(char op)
        {
            if (operation == null)
            {
                num1 = ParseNumber(display);
            }
            else if (!startNewNumber)
            {
                num2 = ParseNumber(display);
                num1 = Compute(num1, num2, operation);
            }

            operation = op.ToString();
            display = operation;
            startNewNumber = true;
            return display;
        }

        public string Calculate()
        {
            if (operation == null)
                throw new CalculatorException("Please enter valid numbers and operator.");

            if (startNewNumber)
                throw new CalculatorException("Please enter a second number.");

            num2 = ParseNumber(display);
            num3 = Compute(num1, num2, operation);

            num1 = num3;
            operation = null;
            startNewNumber = true;

            display = FormatNumber(num3);
            return display;
        }

        public string Clear()
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
            operation = null;
            startNewNumber = false;
            display = "0";
            return display;
        }
    }
}
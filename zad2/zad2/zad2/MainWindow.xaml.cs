using System;
using System.Windows;
using System.Windows.Controls;
using System.Numerics;

namespace CalculatorApp
{
    public partial class MainWindow : Window
    {
        private string operand1 = "";
        private string operand2 = "";
        private string operation = "";
        private double result = 0.0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (operation == "")
            {
                operand1 += button.Content.ToString();
                display.Text = operand1;
            }
            else
            {
                operand2 += button.Content.ToString();
                display.Text = operand2;
            }
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Content.ToString();
            display.Text = "";
            previousOperation.Text = $"{operand1} {operation}";
        }

        private void SingleOperation_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            if (operand1 == "")
            {
                display.Text = "0";
                return;
            }
            if(display.Text == string.Empty)
            {
                display.Text = operand1;
            }
            var num = double.Parse(display.Text);
            result = 0.0;

            switch (button.Content.ToString())
            {
                case "√":
                    result = Math.Sqrt(num);
                    break;
                case "1/x":
                    if (num != 0) result = 1 / num;
                    break;
                case "n!":
                    result = Factorial((int)num);
                    break;
                case "log":
                    if (num > 0) result = Math.Log10(num);
                    break;
                case "ln":
                    if (num > 0) result = Math.Log(num);
                    break;
                case "log₂":
                    if (num > 0) result = Math.Log(num, 2);
                    break;
                case "floor":
                    result = Math.Floor(num);
                    break;
                case "ceil":
                    result = Math.Ceiling(num);
                    break;
            }

            display.Text = result.ToString();
            previousOperation.Text = $"{button.Content}({operand1}) =";
            operand1 = result.ToString();
            operand2 = "";
            operation = "";
        }

        private double Factorial(int n)
        {
            if (n < 0)
                return double.NaN;
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            display.Text = "0";
            previousOperation.Text = "";
            operand1 = "";
            operand2 = "";
            operation = "";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            switch (operation)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "*": result = num1 * num2; break;
                case "/": result = num2 != 0 ? num1 / num2 : double.NaN; break;
                case "^": result = Math.Pow(num1, num2); break;
                case "mod": result = num1 % num2; break;
                case "+ %": result = num1 + (num1 * num2 / 100); break;
                case "- %": result = num1 - (num1 * num2 / 100); break;
                case "* %": result = num1 * (num1 * num2 / 100); break;
            }

            display.Text = result.ToString();
            previousOperation.Text = $"{operand1} {operation} {operand2} =";
            operand1 = result.ToString();
            operand2 = "";
            operation = "";
        }
    }
}

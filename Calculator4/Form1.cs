using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator4
{
    public partial class Form1 : Form
    {
        public bool tm = false;
        Double result = 0;
        String op = "";
        bool enter_value = false;
        String firstnum, secondnum;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void numbers_Only(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(TextDisplay.Text == "0" || enter_value)
            {
                TextDisplay.Text = "";
            }
            enter_value = false;
            if (b.Text == ",")
            {
                if (!TextDisplay.Text.Contains(","))
                {
                    TextDisplay.Text = TextDisplay.Text + b.Text;
                }
            }
            else
            {
                TextDisplay.Text = TextDisplay.Text + b.Text;
            }
        }

        private void op_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (result != 0)
            {
                btnEqual.PerformClick();
                enter_value = true;
                op = b.Text;
                labelOp.Text = result + "  " + op;
            }
            else
            {
                op = b.Text;
                result = Double.Parse(TextDisplay.Text);
                enter_value = true;
                TextDisplay.Text = "";
                labelOp.Text = Convert.ToString(result) + "    " + op;
            }
            firstnum = labelOp.Text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = "0";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = "0";
            result = 0;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            secondnum = TextDisplay.Text;
            labelOp.Text = "";
            switch (op)
            {
                case "+":
                    TextDisplay.Text = (result + Double.Parse(TextDisplay.Text)).ToString();
                    break;
                case "-":
                    TextDisplay.Text = (result - Double.Parse(TextDisplay.Text)).ToString();
                    break;
                case "*":
                    TextDisplay.Text = (result * Double.Parse(TextDisplay.Text)).ToString(); 
                    break;
                case "/":
                    TextDisplay.Text = (result / Double.Parse(TextDisplay.Text)).ToString();
                    break;
                case "√":
                    TextDisplay.Text = (Math.Sqrt(result)).ToString();
                    break;
                case "x²":
                    TextDisplay.Text = (Math.Pow(result,2)).ToString();
                    break;
                case "1/x":
                    TextDisplay.Text = (1/result).ToString();
                    break;
                case "%":
                    TextDisplay.Text = (result * (Double.Parse(TextDisplay.Text)/100)).ToString();
                    break;
                case "+/-":
                    if (TextDisplay.Text[0] == '-')
                        TextDisplay.Text = TextDisplay.Text.Remove(0, 1);
                    else
                        TextDisplay.Text = "-" + TextDisplay.Text;
                    break;
                case "x³":
                    TextDisplay.Text = (Math.Pow(result, 3)).ToString();
                    break;
                case "x^y":
                    TextDisplay.Text = (Math.Pow(result, Double.Parse(TextDisplay.Text))).ToString();
                    break;
                case "p":
                    double n = Double.Parse(TextDisplay.Text);
                    double m = result;
                    double tmp = 0;
                    if (m < n)
                    {
                        tmp = m;
                        m = n;
                        n = tmp;
                    }
                    while (n != 0)
                    {
                        tmp = m % n;
                        m = n;
                        n = tmp;
                    }
                    TextDisplay.Text = m.ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(TextDisplay.Text);
            op = "";
            /**********************/
            ClearHistory.Visible = true;
            rtbHistory.AppendText(firstnum + "  " + secondnum + " = " + "\n");
            rtbHistory.AppendText("\n\t" + TextDisplay.Text +"\n\n");
            labelhd.Text = "";
        }

        private void ClearHistory_Click(object sender, EventArgs e)
        {
            rtbHistory.Clear();
            if (labelhd.Text == "")
            {
                labelhd.Text = "There is no history yet";
            }
            ClearHistory.Visible = false;
            rtbHistory.ScrollBars = 0;
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            tm = !tm;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width < 615 && tm == true)
            {
                while (!(this.Width == 615))
                {
                    this.Width += 1;
                    if (this.Width == 615)
                    {
                        button24.Text = "<";
                        tm = false;

                    }


                }

            }


            if (this.Width > 614 && tm == true)
            {
                while (!(this.Width == 404))
                {

                    this.Width -= 1;

                    if (this.Width == 404)
                    {
                        button24.Text = ">";
                        tm = false;

                    }


                }

            }
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = (Fib(Int32.Parse(TextDisplay.Text))).ToString();
        }

        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            Task<int> task = Task.Factory.StartNew<int>(() => Fib(n - 1));
            var p = Fib(n - 2);
            return task.Result + p;
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            string hexValue = TextDisplay.Text;
            TextDisplay.Text = (Hex(hexValue)).ToString();
        }

        public static int Hex(string n)
        {
            int intAgain = int.Parse(n, System.Globalization.NumberStyles.HexNumber);
            return intAgain;
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = (Bin(Int32.Parse(TextDisplay.Text))).ToString();
        }

        public static string Bin(int n)
        {
            string binary = Convert.ToString(n, 2);
            return binary;
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = (Factorial(Int32.Parse(TextDisplay.Text))).ToString();
        }

        public double Factorial(int a)
        {
            double f = 1;

            for (int i = 1; i <= a; i++)
                f *= (double)i;

            return f;
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            if(TextDisplay.Text.Length > 0)
            {
                TextDisplay.Text = TextDisplay.Text.Remove(TextDisplay.Text.Length - 1, 1);
            }
            if(TextDisplay.Text == " ")
            {
                TextDisplay.Text = "0";
            }
        }
    }
}

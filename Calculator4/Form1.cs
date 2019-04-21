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
            if (this.Width < 491 && tm == true)
            {
                while (!(this.Width == 491))
                {
                    this.Width += 1;
                    if (this.Width == 491)
                    {
                        button24.Text = "<";
                        tm = false;

                    }


                }

            }


            if (this.Width > 490 && tm == true)
            {
                while (!(this.Width == 310))
                {

                    this.Width -= 1;

                    if (this.Width == 311)
                    {
                        button24.Text = ">";
                        tm = false;

                    }


                }

            }
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

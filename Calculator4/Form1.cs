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
        double result = 0;
        string op = "";
        bool enter_value = false;
        char iOperation;
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
            if (b.Text == ".")
            {
                if (!TextDisplay.Text.Contains("."))
                {
                    TextDisplay.Text = TextDisplay.Text + b.Text;
                }
            }
            else
            {
                TextDisplay.Text = TextDisplay.Text + b.Text;
            }
        }
    }
}

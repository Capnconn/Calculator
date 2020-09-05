using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
 /*
 * Maybe work on completing this calculator appp without the need for
 * the predefined parser function.
 */
    public partial class CalculaterGUI : Form
    {
        public CalculaterGUI()
        {
            InitializeComponent();
        }

        /* TODO:
            1. Work on differentiating between subtracting sign and negative sign
        */

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += "9";
        }

        private void buttonNeg_Click(object sender, EventArgs e)
        {
            /* This function is envoked when the - button in the bottom left corner is clicked. This function is
               in charge of making whaterver number it is infront of negative. */

            textBoxFeed.Text += "-";
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += ".";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            /* When the "=" button is clicked all of the numbers that are stored in the output box of the calculater
               are sent as a string to the class "Calculate." */
            DataTable dt = new DataTable();
            string equation = textBoxFeed.Text;
            textBoxFeed.Text = (Convert.ToDouble(dt.Compute(equation, ""))).ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += "+";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text += "/";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            /* This method is envoked when the "<--" button is clicked, it works by removing 
               the last index of the string in the output box of the calculator. */

            textBoxFeed.Text = textBoxFeed.Text.Remove(textBoxFeed.Text.Length - 1, 1);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text = "";
        }
    }
}

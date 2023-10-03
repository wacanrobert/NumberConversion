using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox2.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string inputText = richTextBox1.Text;

            if (radioButton1.Checked) // Convert from binary
            {
                if (IsValidBinary(inputText))
                {
                    int decimalNumber = Convert.ToInt32(inputText, 2);
                    ConvertAndDisplay(decimalNumber);
                }
                else
                {
                    richTextBox2.Text = "Invalid binary input.";
                }
            }
            else if (radioButton2.Checked) // Convert from hexadecimal
            {
                if (IsValidHexadecimal(inputText))
                {
                    int decimalNumber = Convert.ToInt32(inputText, 16);
                    ConvertAndDisplay(decimalNumber);
                }
                else
                {
                    richTextBox2.Text = "Invalid hexadecimal input.";
                }
            }
            else if (radioButton3.Checked) // Convert from octal
            {
                if (IsValidOctal(inputText))
                {
                    int decimalNumber = Convert.ToInt32(inputText, 8);
                    ConvertAndDisplay(decimalNumber);
                }
                else
                {
                    richTextBox2.Text = "Invalid octal input.";
                }
            }
            else if (radioButton7.Checked) // Convert from decimal
            {
                if (IsValidDecimal(inputText))
                {
                    int decimalNumber = int.Parse(inputText);
                    ConvertAndDisplay(decimalNumber);
                }
                else
                {
                    richTextBox2.Text = "Invalid decimal input.";
                }
            }
            else
            {
                richTextBox2.Text = "Please select a conversion option.";
            }

        }

        private bool IsValidBinary(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, "^[01]+$");
        }

        private bool IsValidHexadecimal(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, "^[0-9A-Fa-f]+$");
        }

        private bool IsValidOctal(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, "^[0-7]+$");
        }

        private bool IsValidDecimal(string input)
        {
            return int.TryParse(input, out _);
        }

        private void ConvertAndDisplay(int decimalNumber)
        {
            if (radioButton4.Checked) // Convert to binary
            {
                richTextBox2.Text = Convert.ToString(decimalNumber, 2);
            }
            else if (radioButton5.Checked) // Convert to hexadecimal
            {
                richTextBox2.Text = Convert.ToString(decimalNumber, 16).ToUpper();
            }
            else if (radioButton6.Checked) // Convert to octal
            {
                richTextBox2.Text = Convert.ToString(decimalNumber, 8);
            }
            else if (radioButton8.Checked) // Convert to decimal (no conversion needed)
            {
                richTextBox2.Text = decimalNumber.ToString();
            }
            else
            {
                richTextBox2.Text = "Please select a conversion option.";
            }
        }
    }
}

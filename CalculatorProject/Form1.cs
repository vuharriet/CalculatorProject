/**
 * Name: Harriet Vumiliya
 * Date: Feb/9/2024 - Feb/11/2024
* **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class Form1 : Form
    {
        private double accumulator = 0;
        private string pendingOperation = "";
        private bool newNumberEntered = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (newNumberEntered)
            {
                textDisplay.Text = "0";
                newNumberEntered = false;
            }
            else
            {
                textDisplay.Text += "0";
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (newNumberEntered)
            {
                textDisplay.Text = ".";
                newNumberEntered = false;
            }
            else
            {
                textDisplay.Text += ".";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (newNumberEntered)
            {
                textDisplay.Text = "1";
                newNumberEntered = false;
            }
            else
            {
                textDisplay.Text += "1";
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (newNumberEntered)
            {
                textDisplay.Text = "2";
                newNumberEntered = false;
            }
            else
            {
                textDisplay.Text += "2";
            }


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (newNumberEntered)
            {
                textDisplay.Text = "3";
                newNumberEntered = false;
            }
            else
            {
                textDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (newNumberEntered)
            {
                textDisplay.Text = "4";
                newNumberEntered = false;
            }
            else
            {
                textDisplay.Text += "4";
            }
        }

        private void brn5_Click(object sender, EventArgs e)
        {
            if (newNumberEntered)
            {
                textDisplay.Text = "5";
                newNumberEntered = false;
            }
            else
            {
                textDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (newNumberEntered)
            {
                textDisplay.Text = "6";
                newNumberEntered = false;
            }
            else
            {
                textDisplay.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (newNumberEntered)
            {
                textDisplay.Text = "7";
                newNumberEntered = false;
            }
            else
            {
                textDisplay.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (newNumberEntered)
            {
                textDisplay.Text = "8";
                newNumberEntered = false;
            }
            else
            {
                textDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (newNumberEntered)
            {
                textDisplay.Text = "9";
                newNumberEntered = false;
            }
            else
            {
                textDisplay.Text += "9";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textDisplay.Text))
            {
                textDisplay.Text = textDisplay.Text.Substring(0, textDisplay.Text.Length - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textDisplay.Text))
            {
                textDisplay.Text = textDisplay.Text.Substring(0, 0);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            accumulator = double.Parse(textDisplay.Text);
            pendingOperation = "*";
            newNumberEntered = true;


        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            accumulator = double.Parse(textDisplay.Text);
            pendingOperation = "/";
            newNumberEntered = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            accumulator = double.Parse(textDisplay.Text);
            pendingOperation = "+";
            newNumberEntered = true;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            accumulator = double.Parse(textDisplay.Text);
            pendingOperation = "-";
            newNumberEntered = true;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            // Display the last answer (accumulator) in the text display
            textDisplay.Text = accumulator.ToString();
            // This makes the displayed answer the starting point of a new calculation or allows it to be used in a continuing calculation
            newNumberEntered = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(textDisplay.Text);
            switch (pendingOperation)
            {
                case "+":
                    textDisplay.Text = (accumulator + secondNumber).ToString();
                    break;
                case "-":
                    textDisplay.Text = (accumulator - secondNumber).ToString();
                    break;
                case "*":
                    textDisplay.Text = (accumulator * secondNumber).ToString();
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        textDisplay.Text = "Cannot divide by zero";
                        // Optionally, reset the calculator's state here
                    }
                    else
                    {
                        textDisplay.Text = (accumulator / secondNumber).ToString();
                    }
                    break;
            }
            accumulator = double.Parse(textDisplay.Text); // Update for the next calculation
            newNumberEntered = true; // Ready for new number entry
        }




    }
}

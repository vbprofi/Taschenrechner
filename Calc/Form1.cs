﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        //Variables
        double FirstNumber;
        double SecondNumber;
        double Result;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnN1.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btnN1.Text;
            }
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnN2.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btnN2.Text;
            }
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnN3.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btnN3.Text;
            }
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnN4.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btnN4.Text;
            }
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnN5.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btnN5.Text;
            }
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnN6.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btnN6.Text;
            }
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnN7.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btnN7.Text;
            }
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnN8.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btnN8.Text;
            }
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnN9.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btnN9.Text;
            }
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnN0.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btnN0.Text;
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtDisplay.Text);
            Operation = "+";
            txtDisplay.Text = "0";
        }

        private void btnSUB_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtDisplay.Text);
            Operation = "-";
            txtDisplay.Text = "0";
        }

        private void btnMUL_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtDisplay.Text);
            Operation = "*";
            txtDisplay.Text = "0";
        }

        private void btnDIV_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtDisplay.Text);
            Operation = "/";
            txtDisplay.Text = "0";
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnDOT_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ",";
        }

        private void btnEQUAL_Click(object sender, EventArgs e)
        {
            SecondNumber = Convert.ToDouble(txtDisplay.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                txtDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                txtDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                txtDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txtDisplay.Text = "Nicht durch 0 teilbar";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    txtDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }


        }

    }//end class
}//end namespace
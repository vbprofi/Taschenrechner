using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

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
                txtDisplay.Text = (sender as Button).Text; //btnN1.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + (sender as Button).Text; //btnN1.Text;
            }
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = (sender as Button).Text; //btnN2.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + (sender as Button).Text; //btnN2.Text;
            }
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = (sender as Button).Text;  //btnN3.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + (sender as Button).Text; //btnN3.Text;
            }
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = (sender as Button).Text; //btnN4.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + (sender as Button).Text; //btnN4.Text;
            }
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = (sender as Button).Text; //btnN5.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + (sender as Button).Text; //btnN5.Text;
            }
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = (sender as Button).Text; //btnN6.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + (sender as Button).Text; //btnN6.Text;
            }
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = (sender as Button).Text; //btnN7.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + (sender as Button).Text; //btnN7.Text;
            }
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = (sender as Button).Text; //btnN8.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + (sender as Button).Text; //btnN8.Text;
            }
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = (sender as Button).Text; //btnN9.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + (sender as Button).Text; //btnN9.Text;
            }
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = (sender as Button).Text; //btnN0.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + (sender as Button).Text; //btnN0.Text;
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
                //txtDisplay.Text = Convert.ToString(Result);
                txtDisplay.Text = String.Format("{0:0,0.0}", Result);
                FirstNumber = Result;
            }

            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                //txtDisplay.Text = Convert.ToString(Result);
                txtDisplay.Text = String.Format("{0:0,0.0}", Result);
                FirstNumber = Result;
            }

            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                //txtDisplay.Text = Convert.ToString(Result);
                txtDisplay.Text = String.Format("{0:0,0.0}", Result);
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
                    //txtDisplay.Text = Convert.ToString(Result);
                    txtDisplay.Text = String.Format("{0:0,0.0}", Result);
                    FirstNumber = Result;
                }
            }

            if (Operation == "%")
            {
                Result = (FirstNumber * (SecondNumber/100));
                txtDisplay.Text = String.Format("{0:0,0.0}", Result);
                FirstNumber = Result;
            }
                
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemplus)
                btnADD_Click(sender as Button, e);
            if (e.KeyCode == Keys.OemMinus)
                btnSUB_Click(sender as Button, e);

            if (e.KeyCode == Keys.Escape)
                btnBC_Click(sender as Button, e);
            if (e.KeyCode == Keys.Multiply)
                btnMUL_Click(sender as Button, e);
            if (e.KeyCode == Keys.Divide)
                btnDIV_Click(sender as Button, e);
            if (e.KeyCode == Keys.Return)
                btnEQUAL_Click(sender as Button, e);

            if(e.KeyCode == Keys.D0 && (e.Shift))
                btnEQUAL_Click(sender as Button, e);

            if (e.KeyCode == Keys.F1)
                MessageBox.Show(this.Text + " v" + this.ProductVersion + "\n\n(c)2020, Egid", "Info über" + Application.ProductName);
        }

        private void btnPER_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtDisplay.Text);
            Operation = "%";
            txtDisplay.Text = "0";
        }

    }//end class
}//end namespace

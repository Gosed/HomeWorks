using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       

        /// <summary>
        /// Operation
        /// </summary>
        private char Operation = '0';

        /// <summary>
        /// True if symbol has been printed
        /// </summary>
        private bool Printed = false;

        /// <summary>
        /// First value
        /// </summary>
        private int FVal = 0;

        /// <summary>
        /// Saves first value
        /// </summary>
        public void SaveFVal()
        {
            if (label1.Text == "")
                return;
            FVal = int.Parse(label1.Text);
            Printed = true;
        }   

        /// <summary>
        /// Adding number to label
        /// </summary>
        /// <param name="value">Symbol to add</param>
        public void Number(int tmp)
        {
            if (Printed)
            {
                label1.ResetText();
                Printed = false;
            }
            label1.Text = label1.Text + tmp;
        }

        /// <summary>
        /// numbers buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Number(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Number(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Number(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Number(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Number(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Number(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Number(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Number(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Number(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Number(0);
        }

        /// <summary>
        /// Operations buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            SaveFVal();
            Operation = '+';
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            SaveFVal();
            Operation = '-';
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            SaveFVal();
            Operation = '*';
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            SaveFVal();
            Operation = '/';
        }
        
        /// <summary>
        /// Delete everything
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            label1.ResetText();
            FVal = 0;
        }

        /// <summary>
        /// Counts the result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResult_Click(object sender, EventArgs e)
        {
            int result = 0;
            if ((Operation == '0') || (label1.Text == ""))
                return;
            if (Operation == '+')
            {
                result = FVal + int.Parse(label1.Text);
                label1.ResetText();
                label1.Text = label1.Text + result;
            }
            if (Operation == '-')
            {
                result = FVal - int.Parse(label1.Text);
                label1.ResetText();
                label1.Text = label1.Text + result;
            }
            if (Operation == '*')
            {
                result = FVal * int.Parse(label1.Text);
                label1.ResetText();
                label1.Text = label1.Text + result;
            }
            if (Operation == '/')
            {
                if (int.Parse(label1.Text) == 0)
                {
                    label1.ResetText();
                    FVal = 0;
                    Operation = '0';
                    Printed = false;
                    return;
                }
                result = FVal / int.Parse(label1.Text);
                label1.ResetText();
                label1.Text = label1.Text + result;
            }
            FVal = int.Parse(label1.Text);
            Operation = '0';
            Printed = true;
        }
    }
}

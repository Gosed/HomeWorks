using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// timer 1 event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            int Hour = DateTime.Now.Hour;
            int Minute = DateTime.Now.Minute;
            int Second = DateTime.Now.Second;
            string HourText = Hour.ToString();
            string MinuteText = Minute.ToString();
            string SecondText = Second.ToString();
            if (Hour < 10)
                HourText = "0" + HourText;
            if (Minute < 10)
                MinuteText = "0" + MinuteText;
            if (Second < 10)
                SecondText = "0" + SecondText;
            label1.Text = HourText + ":" + MinuteText + ":" + SecondText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

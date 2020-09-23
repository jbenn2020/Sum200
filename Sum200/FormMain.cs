// Author : Jeffrey Benn
// Date   : 2020/09/22
// Chapter 5 Exercise 9 Sum200
// New feature of top value added.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sum200
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int topValue = Convert.ToInt32(txtTopValue.Text);

            for (int i = 0; i <= topValue; i++)
            {
                sum += i;
                if (i == topValue / 2) txtHalfWay.Text = Convert.ToString(sum);
                //Console.WriteLine("i = " + i + " sum = " + sum);
            }

            txtSum.Text = Convert.ToString(sum);
        }
    }
}

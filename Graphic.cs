﻿using System;
using System.Windows.Forms;

namespace Graphic
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double y, h = 10, X0, Xn;
            X0 = Convert.ToDouble(textBox1.Text);
            Xn = Convert.ToDouble(textBox2.Text);
            this.chart1.Series[0].Points.Clear();

            
            while (X0 <= Xn)
            {
                y = X0 * X0;
                this.chart1.Series[0].Points.AddXY(X0, y);
                X0 += h;
            }
        }

        
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            button2.Visible = false;
        }
        public int a;
        public int b;
        private void Form3_Load(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            label1.Text = c.f3[0];
            radioButton1.Text = c.f3[1];
            radioButton2.Text = c.f3[2];
            radioButton3.Text = c.f3[3];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                if (radioButton1.Checked)
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }
            button1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;

            label4.Text = a.ToString();
            label5.Text = b.ToString();
            button2.Visible = true;
        }

    }
}

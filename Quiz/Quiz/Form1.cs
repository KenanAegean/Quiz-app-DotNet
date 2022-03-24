using System;
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

    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
            label2.Visible = false;
        }
        public int a = 0;
        public int b = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            label1.Text = c.f1[0];
            radioButton1.Text = c.f1[1];
            radioButton2.Text = c.f1[2];
            radioButton3.Text = c.f1[3];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button2.Visible = true;
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                if (radioButton1.Checked)
                {
                    a++;
                    label2.Text = "Correct";
                }
                else{
                    b++;
                    label2.Text = "Wrong";
                }
            }
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            button1.Enabled= false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2();
            f.a = a;
            f.b = b;
            f.Show();
            this.Hide();
        }
    }
}

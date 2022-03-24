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
    public partial class Form2 : Form
    {
        public int CorrectCounter = 0;
        public int FalseCounter = 0;
        public Form2()
        {
            InitializeComponent();
            nextButton.Visible = false;
            answerShow.Visible = false;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            TextMaker();

            void TextMaker()
            {

                Class1 textClass = new Class1();
                question.Text = textClass.FormTexts2[0];
                answer1.Text = textClass.FormTexts2[1];
                answer2.Text = textClass.FormTexts2[2];
                answer3.Text = textClass.FormTexts2[3];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            answerShow.Visible = true;
            nextButton.Visible = true;
            if (answer1.Checked || answer2.Checked || answer3.Checked)
            {
                if (answer3.Checked)
                {
                    CorrectCounter++;
                    answerShow.Text = "Correct Answer!";
                }
                else
                {
                    FalseCounter++;
                    answerShow.Text = "Wrong Answer! answer is: " + answer3.Text;
                }
            }
            answer1.Enabled = false;
            answer2.Enabled = false;
            answer3.Enabled = false;
            checkButton.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 nextForm = new Form3();
            nextForm.CorrectCounter = CorrectCounter;
            nextForm.FalseCounter = FalseCounter;
            nextForm.Show();
            this.Hide();
        }
    }
}

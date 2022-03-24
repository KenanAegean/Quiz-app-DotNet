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
    public partial class Form3 : Form
    {
        public int CorrectCounter = 0;
        public int FalseCounter = 0;
        public Form3()
        {
            InitializeComponent();
            exitButton.Visible = false;
            wrongShow.Visible = false;
            correctShow.Visible = false;
            answerShow.Visible = false;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            TextMaker();

            void TextMaker()
            {

                Class1 textClass = new Class1();
                question.Text = textClass.FormTexts3[0];
                answer1.Text = textClass.FormTexts3[1];
                answer2.Text = textClass.FormTexts3[2];
                answer3.Text = textClass.FormTexts3[3];
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (answer1.Checked || answer2.Checked || answer3.Checked)
            {
                if (answer2.Checked)
                {
                    CorrectCounter++;
                }
                else
                {
                    FalseCounter++;
                    answerShow.Text = "Wrong Answer! answer is: " + answer2.Text;
                }
            }
            checkButton.Enabled = false;
            answer1.Enabled = false;
            answer2.Enabled = false;
            answer3.Enabled = false;

            wrongShow.Visible = true;
            correctShow.Visible = true;
            answerShow.Visible = true;

            correctShow.Text = "You have " + CorrectCounter.ToString() + " correct ancswer!";
            wrongShow.Text = "You have " + FalseCounter.ToString() + " wrong answer!";
            exitButton.Visible = true;
        }

    }
}

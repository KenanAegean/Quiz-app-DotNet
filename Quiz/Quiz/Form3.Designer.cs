
namespace Quiz
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.answer3 = new System.Windows.Forms.RadioButton();
            this.answer2 = new System.Windows.Forms.RadioButton();
            this.answer1 = new System.Windows.Forms.RadioButton();
            this.question = new System.Windows.Forms.Label();
            this.wrongShow = new System.Windows.Forms.Label();
            this.correctShow = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.answerShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answer3
            // 
            this.answer3.AutoSize = true;
            this.answer3.Location = new System.Drawing.Point(101, 154);
            this.answer3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(85, 17);
            this.answer3.TabIndex = 3;
            this.answer3.TabStop = true;
            this.answer3.Text = "radioButton3";
            this.answer3.UseVisualStyleBackColor = true;
            // 
            // answer2
            // 
            this.answer2.AutoSize = true;
            this.answer2.Location = new System.Drawing.Point(101, 132);
            this.answer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(85, 17);
            this.answer2.TabIndex = 2;
            this.answer2.TabStop = true;
            this.answer2.Text = "radioButton2";
            this.answer2.UseVisualStyleBackColor = true;
            // 
            // answer1
            // 
            this.answer1.AutoSize = true;
            this.answer1.Location = new System.Drawing.Point(101, 110);
            this.answer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(85, 17);
            this.answer1.TabIndex = 1;
            this.answer1.TabStop = true;
            this.answer1.Text = "radioButton1";
            this.answer1.UseVisualStyleBackColor = true;
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(99, 86);
            this.question.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(55, 13);
            this.question.TabIndex = 0;
            this.question.Text = "What is... ";
            // 
            // wrongShow
            // 
            this.wrongShow.AutoSize = true;
            this.wrongShow.Location = new System.Drawing.Point(404, 161);
            this.wrongShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongShow.Name = "wrongShow";
            this.wrongShow.Size = new System.Drawing.Size(35, 13);
            this.wrongShow.TabIndex = 1;
            this.wrongShow.Text = "label5";
            // 
            // correctShow
            // 
            this.correctShow.AutoSize = true;
            this.correctShow.Location = new System.Drawing.Point(404, 136);
            this.correctShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.correctShow.Name = "correctShow";
            this.correctShow.Size = new System.Drawing.Size(35, 13);
            this.correctShow.TabIndex = 0;
            this.correctShow.Text = "label4";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(388, 253);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 31);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(158, 253);
            this.checkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(92, 31);
            this.checkButton.TabIndex = 9;
            this.checkButton.Text = "Check Answer";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // answerShow
            // 
            this.answerShow.AutoSize = true;
            this.answerShow.Location = new System.Drawing.Point(404, 110);
            this.answerShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerShow.Name = "answerShow";
            this.answerShow.Size = new System.Drawing.Size(35, 13);
            this.answerShow.TabIndex = 10;
            this.answerShow.Text = "label3";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.answerShow);
            this.Controls.Add(this.wrongShow);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.correctShow);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.question);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton answer3;
        private System.Windows.Forms.RadioButton answer2;
        private System.Windows.Forms.RadioButton answer1;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label wrongShow;
        private System.Windows.Forms.Label correctShow;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label answerShow;
    }
}
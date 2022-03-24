
namespace Quiz
{
    partial class Form2
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
            this.checkButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.answerShow = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.RadioButton();
            this.answer2 = new System.Windows.Forms.RadioButton();
            this.answer3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(160, 245);
            this.checkButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(92, 35);
            this.checkButton.TabIndex = 7;
            this.checkButton.Text = "Check Answer";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(325, 245);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(85, 35);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "Next Question";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // answerShow
            // 
            this.answerShow.AutoSize = true;
            this.answerShow.Location = new System.Drawing.Point(384, 134);
            this.answerShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerShow.Name = "answerShow";
            this.answerShow.Size = new System.Drawing.Size(55, 13);
            this.answerShow.TabIndex = 9;
            this.answerShow.Text = "What is... ";
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(135, 93);
            this.question.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(55, 13);
            this.question.TabIndex = 0;
            this.question.Text = "What is... ";
            // 
            // answer1
            // 
            this.answer1.AutoSize = true;
            this.answer1.Location = new System.Drawing.Point(137, 117);
            this.answer1.Margin = new System.Windows.Forms.Padding(2);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(85, 17);
            this.answer1.TabIndex = 1;
            this.answer1.TabStop = true;
            this.answer1.Text = "radioButton1";
            this.answer1.UseVisualStyleBackColor = true;
            // 
            // answer2
            // 
            this.answer2.AutoSize = true;
            this.answer2.Location = new System.Drawing.Point(137, 139);
            this.answer2.Margin = new System.Windows.Forms.Padding(2);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(85, 17);
            this.answer2.TabIndex = 2;
            this.answer2.TabStop = true;
            this.answer2.Text = "radioButton2";
            this.answer2.UseVisualStyleBackColor = true;
            // 
            // answer3
            // 
            this.answer3.AutoSize = true;
            this.answer3.Location = new System.Drawing.Point(137, 161);
            this.answer3.Margin = new System.Windows.Forms.Padding(2);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(85, 17);
            this.answer3.TabIndex = 3;
            this.answer3.TabStop = true;
            this.answer3.Text = "radioButton3";
            this.answer3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answerShow);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.question);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label answerShow;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.RadioButton answer1;
        private System.Windows.Forms.RadioButton answer2;
        private System.Windows.Forms.RadioButton answer3;
    }
}
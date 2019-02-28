﻿namespace Jeopardy
{
    partial class frmReviewWrongQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReviewWrongQuestions));
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnRevealAnswer = new System.Windows.Forms.Button();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(44, 28);
            this.lblQuestionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestionText.MaximumSize = new System.Drawing.Size(1200, 369);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(1191, 240);
            this.lblQuestionText.TabIndex = 12;
            this.lblQuestionText.Text = resources.GetString("lblQuestionText.Text");
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(485, 567);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(328, 73);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnRevealAnswer
            // 
            this.btnRevealAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevealAnswer.Location = new System.Drawing.Point(931, 391);
            this.btnRevealAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRevealAnswer.Name = "btnRevealAnswer";
            this.btnRevealAnswer.Size = new System.Drawing.Size(328, 73);
            this.btnRevealAnswer.TabIndex = 14;
            this.btnRevealAnswer.Text = "Show Answer";
            this.btnRevealAnswer.UseVisualStyleBackColor = true;
            this.btnRevealAnswer.Click += new System.EventHandler(this.btnRevealAnswer_Click);
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectAnswer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCorrectAnswer.Location = new System.Drawing.Point(41, 401);
            this.txtCorrectAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.ReadOnly = true;
            this.txtCorrectAnswer.Size = new System.Drawing.Size(871, 53);
            this.txtCorrectAnswer.TabIndex = 15;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(41, 567);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(328, 73);
            this.btnPrevious.TabIndex = 16;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(929, 567);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(328, 73);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(577, 490);
            this.lblIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(120, 46);
            this.lblIndex.TabIndex = 18;
            this.lblIndex.Text = "1 of 5";
            // 
            // frmReviewWrongQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 678);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.btnRevealAnswer);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblQuestionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReviewWrongQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jeopardy - Review";
            this.Load += new System.EventHandler(this.frmReviewWrongQuestions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnRevealAnswer;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblIndex;
    }
}
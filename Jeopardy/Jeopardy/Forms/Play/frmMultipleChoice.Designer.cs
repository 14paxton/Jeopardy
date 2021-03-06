﻿namespace Jeopardy
{
    partial class frmMultipleChoice
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMultipleChoice));
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlRadioButtons = new System.Windows.Forms.Panel();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.rdoFourthChoice = new System.Windows.Forms.RadioButton();
            this.rdoThirdChoice = new System.Windows.Forms.RadioButton();
            this.rdoSecondChoice = new System.Windows.Forms.RadioButton();
            this.rdoFirstChoice = new System.Windows.Forms.RadioButton();
            this.pnlRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(274, 526);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(211, 53);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "1:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(34, 525);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(234, 54);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(786, 525);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(234, 54);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(28, 9);
            this.lblQuestionText.MaximumSize = new System.Drawing.Size(1000, 200);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(997, 190);
            this.lblQuestionText.TabIndex = 10;
            this.lblQuestionText.Text = resources.GetString("lblQuestionText.Text");
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(491, 525);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(234, 54);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlRadioButtons
            // 
            this.pnlRadioButtons.Controls.Add(this.lblD);
            this.pnlRadioButtons.Controls.Add(this.lblC);
            this.pnlRadioButtons.Controls.Add(this.lblB);
            this.pnlRadioButtons.Controls.Add(this.lblA);
            this.pnlRadioButtons.Controls.Add(this.rdoFourthChoice);
            this.pnlRadioButtons.Controls.Add(this.rdoThirdChoice);
            this.pnlRadioButtons.Controls.Add(this.rdoSecondChoice);
            this.pnlRadioButtons.Controls.Add(this.rdoFirstChoice);
            this.pnlRadioButtons.Location = new System.Drawing.Point(11, 206);
            this.pnlRadioButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRadioButtons.Name = "pnlRadioButtons";
            this.pnlRadioButtons.Size = new System.Drawing.Size(1029, 304);
            this.pnlRadioButtons.TabIndex = 12;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(3, 224);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(34, 31);
            this.lblD.TabIndex = 14;
            this.lblD.Text = "D";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(4, 151);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(34, 31);
            this.lblC.TabIndex = 13;
            this.lblC.Text = "C";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(4, 78);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(32, 31);
            this.lblB.TabIndex = 12;
            this.lblB.Text = "B";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(3, 5);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(32, 31);
            this.lblA.TabIndex = 11;
            this.lblA.Text = "A";
            // 
            // rdoFourthChoice
            // 
            this.rdoFourthChoice.AutoSize = true;
            this.rdoFourthChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFourthChoice.Location = new System.Drawing.Point(59, 222);
            this.rdoFourthChoice.MaximumSize = new System.Drawing.Size(1000, 90);
            this.rdoFourthChoice.Name = "rdoFourthChoice";
            this.rdoFourthChoice.Size = new System.Drawing.Size(139, 35);
            this.rdoFourthChoice.TabIndex = 10;
            this.rdoFourthChoice.TabStop = true;
            this.rdoFourthChoice.Text = "Choice 4";
            this.rdoFourthChoice.UseVisualStyleBackColor = true;
            // 
            // rdoThirdChoice
            // 
            this.rdoThirdChoice.AutoSize = true;
            this.rdoThirdChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoThirdChoice.Location = new System.Drawing.Point(59, 149);
            this.rdoThirdChoice.MaximumSize = new System.Drawing.Size(1000, 90);
            this.rdoThirdChoice.Name = "rdoThirdChoice";
            this.rdoThirdChoice.Size = new System.Drawing.Size(139, 35);
            this.rdoThirdChoice.TabIndex = 9;
            this.rdoThirdChoice.TabStop = true;
            this.rdoThirdChoice.Text = "Choice 3";
            this.rdoThirdChoice.UseVisualStyleBackColor = true;
            // 
            // rdoSecondChoice
            // 
            this.rdoSecondChoice.AutoSize = true;
            this.rdoSecondChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSecondChoice.Location = new System.Drawing.Point(59, 76);
            this.rdoSecondChoice.MaximumSize = new System.Drawing.Size(1000, 90);
            this.rdoSecondChoice.Name = "rdoSecondChoice";
            this.rdoSecondChoice.Size = new System.Drawing.Size(139, 35);
            this.rdoSecondChoice.TabIndex = 8;
            this.rdoSecondChoice.TabStop = true;
            this.rdoSecondChoice.Text = "Choice 2";
            this.rdoSecondChoice.UseVisualStyleBackColor = true;
            // 
            // rdoFirstChoice
            // 
            this.rdoFirstChoice.AutoSize = true;
            this.rdoFirstChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFirstChoice.Location = new System.Drawing.Point(59, 3);
            this.rdoFirstChoice.MaximumSize = new System.Drawing.Size(1000, 90);
            this.rdoFirstChoice.Name = "rdoFirstChoice";
            this.rdoFirstChoice.Size = new System.Drawing.Size(139, 35);
            this.rdoFirstChoice.TabIndex = 7;
            this.rdoFirstChoice.TabStop = true;
            this.rdoFirstChoice.Text = "Choice 1";
            this.rdoFirstChoice.UseVisualStyleBackColor = true;
            // 
            // frmMultipleChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 602);
            this.ControlBox = false;
            this.Controls.Add(this.pnlRadioButtons);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMultipleChoice";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Multiple Choice";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMultipleChoice_FormClosing);
            this.Load += new System.EventHandler(this.frmMultipleChoice_Load);
            this.pnlRadioButtons.ResumeLayout(false);
            this.pnlRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlRadioButtons;
        private System.Windows.Forms.RadioButton rdoFourthChoice;
        private System.Windows.Forms.RadioButton rdoThirdChoice;
        private System.Windows.Forms.RadioButton rdoSecondChoice;
        private System.Windows.Forms.RadioButton rdoFirstChoice;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
    }
}
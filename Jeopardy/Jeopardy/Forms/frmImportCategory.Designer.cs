﻿namespace Jeopardy
{
    partial class frmImportCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportCategory));
            this.lstGames = new System.Windows.Forms.ListBox();
            this.cbxQuestions = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.lsvQuestions = new System.Windows.Forms.ListView();
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Answer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bwLoadGames = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lstGames
            // 
            this.lstGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGames.FormattingEnabled = true;
            this.lstGames.ItemHeight = 20;
            this.lstGames.Location = new System.Drawing.Point(42, 66);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(309, 164);
            this.lstGames.TabIndex = 0;
            this.lstGames.SelectedIndexChanged += new System.EventHandler(this.lstGames_SelectedIndexChanged);
            // 
            // cbxQuestions
            // 
            this.cbxQuestions.AutoSize = true;
            this.cbxQuestions.Checked = true;
            this.cbxQuestions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQuestions.Location = new System.Drawing.Point(276, 508);
            this.cbxQuestions.Name = "cbxQuestions";
            this.cbxQuestions.Size = new System.Drawing.Size(213, 28);
            this.cbxQuestions.TabIndex = 1;
            this.cbxQuestions.Text = "Also Import Questions";
            this.cbxQuestions.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Game";
            // 
            // lstCategories
            // 
            this.lstCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 20;
            this.lstCategories.Location = new System.Drawing.Point(409, 66);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(309, 164);
            this.lstCategories.TabIndex = 3;
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
            // 
            // lsvQuestions
            // 
            this.lsvQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chType,
            this.Question,
            this.Answer});
            this.lsvQuestions.Enabled = false;
            this.lsvQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvQuestions.FullRowSelect = true;
            this.lsvQuestions.Location = new System.Drawing.Point(42, 262);
            this.lsvQuestions.MultiSelect = false;
            this.lsvQuestions.Name = "lsvQuestions";
            this.lsvQuestions.Size = new System.Drawing.Size(676, 188);
            this.lsvQuestions.TabIndex = 4;
            this.lsvQuestions.UseCompatibleStateImageBehavior = false;
            this.lsvQuestions.View = System.Windows.Forms.View.Details;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 140;
            // 
            // Question
            // 
            this.Question.Text = "Question";
            this.Question.Width = 342;
            // 
            // Answer
            // 
            this.Answer.Text = "Answer";
            this.Answer.Width = 174;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Category";
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(514, 495);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(204, 49);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Import Category";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(42, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(204, 49);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bwLoadGames
            // 
            this.bwLoadGames.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadGames_DoWork);
            this.bwLoadGames.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadGames_RunWorkerCompleted);
            // 
            // frmImportCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 590);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsvQuestions);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxQuestions);
            this.Controls.Add(this.lstGames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmImportCategory";
            this.Load += new System.EventHandler(this.frmImportCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGames;
        private System.Windows.Forms.CheckBox cbxQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.ListView lsvQuestions;
        private System.Windows.Forms.ColumnHeader Question;
        private System.Windows.Forms.ColumnHeader Answer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnCancel;
        private System.ComponentModel.BackgroundWorker bwLoadGames;
        private System.Windows.Forms.ColumnHeader chType;
    }
}
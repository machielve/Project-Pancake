﻿
namespace Project_pancake
{
    partial class NewAssemblyDetailOps
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
            this.txtAssemblyID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.countOps = new System.Windows.Forms.NumericUpDown();
            this.BtnAddOperation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOps = new System.Windows.Forms.ComboBox();
            this.BtnFinnish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countOps)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAssemblyID
            // 
            this.txtAssemblyID.Location = new System.Drawing.Point(100, 23);
            this.txtAssemblyID.Name = "txtAssemblyID";
            this.txtAssemblyID.ReadOnly = true;
            this.txtAssemblyID.Size = new System.Drawing.Size(218, 20);
            this.txtAssemblyID.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Assembly";
            // 
            // countOps
            // 
            this.countOps.DecimalPlaces = 1;
            this.countOps.Location = new System.Drawing.Point(100, 77);
            this.countOps.Name = "countOps";
            this.countOps.Size = new System.Drawing.Size(218, 20);
            this.countOps.TabIndex = 22;
            // 
            // BtnAddOperation
            // 
            this.BtnAddOperation.Location = new System.Drawing.Point(12, 154);
            this.BtnAddOperation.Name = "BtnAddOperation";
            this.BtnAddOperation.Size = new System.Drawing.Size(133, 23);
            this.BtnAddOperation.TabIndex = 21;
            this.BtnAddOperation.Text = "Add Operation";
            this.BtnAddOperation.UseVisualStyleBackColor = true;
            this.BtnAddOperation.Click += new System.EventHandler(this.BtnAddOperation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Operation";
            // 
            // cmbOps
            // 
            this.cmbOps.FormattingEnabled = true;
            this.cmbOps.Location = new System.Drawing.Point(100, 49);
            this.cmbOps.Name = "cmbOps";
            this.cmbOps.Size = new System.Drawing.Size(218, 21);
            this.cmbOps.TabIndex = 18;
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(185, 154);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(133, 23);
            this.BtnFinnish.TabIndex = 17;
            this.BtnFinnish.Text = "Cancel";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // NewAssemblyDetailOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 258);
            this.Controls.Add(this.txtAssemblyID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countOps);
            this.Controls.Add(this.BtnAddOperation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOps);
            this.Controls.Add(this.BtnFinnish);
            this.Name = "NewAssemblyDetailOps";
            this.Text = "New assembly operations";
            this.Load += new System.EventHandler(this.NewAssemblyDetailOps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countOps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAssemblyID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown countOps;
        private System.Windows.Forms.Button BtnAddOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOps;
        private System.Windows.Forms.Button BtnFinnish;
    }
}
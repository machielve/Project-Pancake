
namespace Project_pancake
{
    partial class NewOperation
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
            this.txtMatMod = new System.Windows.Forms.ComboBox();
            this.BtnAddAnotherOperation = new System.Windows.Forms.Button();
            this.BtnNewOperation = new System.Windows.Forms.Button();
            this.txtOperationID = new System.Windows.Forms.TextBox();
            this.txtOperationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFinnish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbWeightUnit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatMod
            // 
            this.txtMatMod.FormattingEnabled = true;
            this.txtMatMod.Items.AddRange(new object[] {
            "-",
            "Neutral",
            "Adding",
            "Removal"});
            this.txtMatMod.Location = new System.Drawing.Point(124, 46);
            this.txtMatMod.Name = "txtMatMod";
            this.txtMatMod.Size = new System.Drawing.Size(218, 21);
            this.txtMatMod.TabIndex = 16;
            // 
            // BtnAddAnotherOperation
            // 
            this.BtnAddAnotherOperation.Location = new System.Drawing.Point(203, 239);
            this.BtnAddAnotherOperation.Name = "BtnAddAnotherOperation";
            this.BtnAddAnotherOperation.Size = new System.Drawing.Size(139, 23);
            this.BtnAddAnotherOperation.TabIndex = 15;
            this.BtnAddAnotherOperation.Text = "Add another operation";
            this.BtnAddAnotherOperation.UseVisualStyleBackColor = true;
            this.BtnAddAnotherOperation.Click += new System.EventHandler(this.BtnAddAnotherOperation_Click);
            // 
            // BtnNewOperation
            // 
            this.BtnNewOperation.Location = new System.Drawing.Point(108, 178);
            this.BtnNewOperation.Name = "BtnNewOperation";
            this.BtnNewOperation.Size = new System.Drawing.Size(234, 23);
            this.BtnNewOperation.TabIndex = 14;
            this.BtnNewOperation.Text = "Add new operation";
            this.BtnNewOperation.UseVisualStyleBackColor = true;
            this.BtnNewOperation.Click += new System.EventHandler(this.BtnNewOperation_Click);
            // 
            // txtOperationID
            // 
            this.txtOperationID.Location = new System.Drawing.Point(124, 126);
            this.txtOperationID.Name = "txtOperationID";
            this.txtOperationID.ReadOnly = true;
            this.txtOperationID.Size = new System.Drawing.Size(218, 20);
            this.txtOperationID.TabIndex = 13;
            // 
            // txtOperationName
            // 
            this.txtOperationName.Location = new System.Drawing.Point(124, 20);
            this.txtOperationName.Name = "txtOperationName";
            this.txtOperationName.Size = new System.Drawing.Size(218, 20);
            this.txtOperationName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Operation name";
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(15, 239);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(146, 23);
            this.BtnFinnish.TabIndex = 10;
            this.BtnFinnish.Text = "Finnish";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Material modification";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Operation ID";
            // 
            // cmbWeightUnit
            // 
            this.cmbWeightUnit.FormattingEnabled = true;
            this.cmbWeightUnit.Location = new System.Drawing.Point(124, 73);
            this.cmbWeightUnit.Name = "cmbWeightUnit";
            this.cmbWeightUnit.Size = new System.Drawing.Size(218, 21);
            this.cmbWeightUnit.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Operation unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Price per unt";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(124, 100);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(218, 20);
            this.numericUpDown1.TabIndex = 31;
            // 
            // NewOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 278);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cmbWeightUnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatMod);
            this.Controls.Add(this.BtnAddAnotherOperation);
            this.Controls.Add(this.BtnNewOperation);
            this.Controls.Add(this.txtOperationID);
            this.Controls.Add(this.txtOperationName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFinnish);
            this.Name = "NewOperation";
            this.Text = "New Operation";
            this.Load += new System.EventHandler(this.NewOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtMatMod;
        private System.Windows.Forms.Button BtnAddAnotherOperation;
        private System.Windows.Forms.Button BtnNewOperation;
        private System.Windows.Forms.TextBox txtOperationID;
        private System.Windows.Forms.TextBox txtOperationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFinnish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbWeightUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
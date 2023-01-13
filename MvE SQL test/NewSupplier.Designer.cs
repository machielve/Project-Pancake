
namespace MvE_SQL_test
{
    partial class NewSupplier
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
            this.btnAddAnotherSupplier = new System.Windows.Forms.Button();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewSupplier = new System.Windows.Forms.Button();
            this.btnFinnish = new System.Windows.Forms.Button();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAnotherSupplier
            // 
            this.btnAddAnotherSupplier.Location = new System.Drawing.Point(211, 167);
            this.btnAddAnotherSupplier.Name = "btnAddAnotherSupplier";
            this.btnAddAnotherSupplier.Size = new System.Drawing.Size(139, 23);
            this.btnAddAnotherSupplier.TabIndex = 16;
            this.btnAddAnotherSupplier.Text = "Add another supplier";
            this.btnAddAnotherSupplier.UseVisualStyleBackColor = true;
            this.btnAddAnotherSupplier.Click += new System.EventHandler(this.btnAddAnotherSupplier_Click);
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(116, 34);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(234, 20);
            this.txtSupplierID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Supplier ID";
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.Location = new System.Drawing.Point(116, 106);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Size = new System.Drawing.Size(234, 23);
            this.btnNewSupplier.TabIndex = 13;
            this.btnNewSupplier.Text = "Add new supplier";
            this.btnNewSupplier.UseVisualStyleBackColor = true;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(23, 167);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(146, 23);
            this.btnFinnish.TabIndex = 12;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(116, 8);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(234, 20);
            this.txtSupplierName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Supplier name";
            // 
            // NewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.btnAddAnotherSupplier);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNewSupplier);
            this.Controls.Add(this.btnFinnish);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.label1);
            this.Name = "NewSupplier";
            this.Text = "New supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnotherSupplier;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewSupplier;
        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label1;
    }
}
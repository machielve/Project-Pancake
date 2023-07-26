
namespace MvE_SQL_test
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
            this.btnAddAnotherOperation = new System.Windows.Forms.Button();
            this.btnNewOperation = new System.Windows.Forms.Button();
            this.txtOperationID = new System.Windows.Forms.TextBox();
            this.txtOperationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinnish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // btnAddAnotherOperation
            // 
            this.btnAddAnotherOperation.Location = new System.Drawing.Point(203, 179);
            this.btnAddAnotherOperation.Name = "btnAddAnotherOperation";
            this.btnAddAnotherOperation.Size = new System.Drawing.Size(139, 23);
            this.btnAddAnotherOperation.TabIndex = 15;
            this.btnAddAnotherOperation.Text = "Add another operation";
            this.btnAddAnotherOperation.UseVisualStyleBackColor = true;
            this.btnAddAnotherOperation.Click += new System.EventHandler(this.btnAddAnotherOperation_Click);
            // 
            // btnNewOperation
            // 
            this.btnNewOperation.Location = new System.Drawing.Point(108, 118);
            this.btnNewOperation.Name = "btnNewOperation";
            this.btnNewOperation.Size = new System.Drawing.Size(234, 23);
            this.btnNewOperation.TabIndex = 14;
            this.btnNewOperation.Text = "Add new operation";
            this.btnNewOperation.UseVisualStyleBackColor = true;
            this.btnNewOperation.Click += new System.EventHandler(this.btnNewOperation_Click);
            // 
            // txtOperationID
            // 
            this.txtOperationID.Location = new System.Drawing.Point(108, 72);
            this.txtOperationID.Name = "txtOperationID";
            this.txtOperationID.ReadOnly = true;
            this.txtOperationID.Size = new System.Drawing.Size(234, 20);
            this.txtOperationID.TabIndex = 13;
            // 
            // txtOperationName
            // 
            this.txtOperationName.Location = new System.Drawing.Point(108, 20);
            this.txtOperationName.Name = "txtOperationName";
            this.txtOperationName.Size = new System.Drawing.Size(234, 20);
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
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(15, 179);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(146, 23);
            this.btnFinnish.TabIndex = 10;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
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
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Operation ID";
            // 
            // NewOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatMod);
            this.Controls.Add(this.btnAddAnotherOperation);
            this.Controls.Add(this.btnNewOperation);
            this.Controls.Add(this.txtOperationID);
            this.Controls.Add(this.txtOperationName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinnish);
            this.Name = "NewOperation";
            this.Text = "New Operation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtMatMod;
        private System.Windows.Forms.Button btnAddAnotherOperation;
        private System.Windows.Forms.Button btnNewOperation;
        private System.Windows.Forms.TextBox txtOperationID;
        private System.Windows.Forms.TextBox txtOperationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
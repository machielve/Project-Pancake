
namespace MvE_SQL_test
{
    partial class NewPartSupplier
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
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAnotherSupplier = new System.Windows.Forms.Button();
            this.btnNewSupplier = new System.Windows.Forms.Button();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFinnish = new System.Windows.Forms.Button();
            this.countPrice = new System.Windows.Forms.NumericUpDown();
            this.CountQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Items.AddRange(new object[] {
            "-",
            "Time",
            "Weight",
            "Length"});
            this.cmbSupplier.Location = new System.Drawing.Point(108, 39);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(234, 21);
            this.cmbSupplier.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Supplier";
            // 
            // btnAddAnotherSupplier
            // 
            this.btnAddAnotherSupplier.Location = new System.Drawing.Point(203, 177);
            this.btnAddAnotherSupplier.Name = "btnAddAnotherSupplier";
            this.btnAddAnotherSupplier.Size = new System.Drawing.Size(139, 23);
            this.btnAddAnotherSupplier.TabIndex = 16;
            this.btnAddAnotherSupplier.Text = "Add another supplier";
            this.btnAddAnotherSupplier.UseVisualStyleBackColor = true;
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.Location = new System.Drawing.Point(108, 135);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Size = new System.Drawing.Size(234, 23);
            this.btnNewSupplier.TabIndex = 15;
            this.btnNewSupplier.Text = "Add new supplier";
            this.btnNewSupplier.UseVisualStyleBackColor = true;
            // 
            // txtUnitID
            // 
            this.txtUnitID.Location = new System.Drawing.Point(108, 13);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.ReadOnly = true;
            this.txtUnitID.Size = new System.Drawing.Size(234, 20);
            this.txtUnitID.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Part ID";
            // 
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(15, 177);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(146, 23);
            this.btnFinnish.TabIndex = 10;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // countPrice
            // 
            this.countPrice.Location = new System.Drawing.Point(108, 67);
            this.countPrice.Name = "countPrice";
            this.countPrice.Size = new System.Drawing.Size(234, 20);
            this.countPrice.TabIndex = 19;
            // 
            // CountQuantity
            // 
            this.CountQuantity.Location = new System.Drawing.Point(108, 93);
            this.CountQuantity.Name = "CountQuantity";
            this.CountQuantity.Size = new System.Drawing.Size(234, 20);
            this.CountQuantity.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Total price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantity";
            // 
            // NewPartSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountQuantity);
            this.Controls.Add(this.countPrice);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddAnotherSupplier);
            this.Controls.Add(this.btnNewSupplier);
            this.Controls.Add(this.txtUnitID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinnish);
            this.Name = "NewPartSupplier";
            this.Text = "New part supplier";
            this.Load += new System.EventHandler(this.NewPartSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAnotherSupplier;
        private System.Windows.Forms.Button btnNewSupplier;
        private System.Windows.Forms.TextBox txtUnitID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.NumericUpDown countPrice;
        private System.Windows.Forms.NumericUpDown CountQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
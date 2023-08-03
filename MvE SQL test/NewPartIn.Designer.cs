
namespace MvE_SQL_test
{
    partial class NewPartIn
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
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRelation = new System.Windows.Forms.ComboBox();
            this.countQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.countPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinnish = new System.Windows.Forms.Button();
            this.txtPONumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.btnAddStockIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPart
            // 
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Location = new System.Drawing.Point(105, 17);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(234, 21);
            this.cmbPart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Part";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Relation";
            // 
            // cmbRelation
            // 
            this.cmbRelation.FormattingEnabled = true;
            this.cmbRelation.Location = new System.Drawing.Point(105, 44);
            this.cmbRelation.Name = "cmbRelation";
            this.cmbRelation.Size = new System.Drawing.Size(234, 21);
            this.cmbRelation.TabIndex = 2;
            // 
            // countQuantity
            // 
            this.countQuantity.DecimalPlaces = 2;
            this.countQuantity.Location = new System.Drawing.Point(105, 72);
            this.countQuantity.Name = "countQuantity";
            this.countQuantity.Size = new System.Drawing.Size(234, 20);
            this.countQuantity.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // countPrice
            // 
            this.countPrice.DecimalPlaces = 2;
            this.countPrice.Location = new System.Drawing.Point(105, 98);
            this.countPrice.Name = "countPrice";
            this.countPrice.Size = new System.Drawing.Size(234, 20);
            this.countPrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(12, 473);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(146, 23);
            this.btnFinnish.TabIndex = 11;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // txtPONumber
            // 
            this.txtPONumber.Location = new System.Drawing.Point(105, 124);
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.Size = new System.Drawing.Size(234, 20);
            this.txtPONumber.TabIndex = 12;
            this.txtPONumber.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Purchase order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Serial numbers";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(105, 150);
            this.txtSerialNumber.Multiline = true;
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(234, 135);
            this.txtSerialNumber.TabIndex = 14;
            this.txtSerialNumber.Text = "-";
            // 
            // btnAddStockIn
            // 
            this.btnAddStockIn.Location = new System.Drawing.Point(105, 380);
            this.btnAddStockIn.Name = "btnAddStockIn";
            this.btnAddStockIn.Size = new System.Drawing.Size(146, 23);
            this.btnAddStockIn.TabIndex = 16;
            this.btnAddStockIn.Text = "Add stock";
            this.btnAddStockIn.UseVisualStyleBackColor = true;
            this.btnAddStockIn.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // NewPartIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 508);
            this.Controls.Add(this.btnAddStockIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPONumber);
            this.Controls.Add(this.btnFinnish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.countPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRelation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPart);
            this.Name = "NewPartIn";
            this.Text = "New Part In";
            this.Load += new System.EventHandler(this.NewPartIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRelation;
        private System.Windows.Forms.NumericUpDown countQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown countPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.TextBox txtPONumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Button btnAddStockIn;
    }
}
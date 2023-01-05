
namespace MvE_SQL_test
{
    partial class NewAssemblyDetailPart
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
            this.btnFinnish = new System.Windows.Forms.Button();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.countPart = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAssemblyID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.countPart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(185, 154);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(133, 23);
            this.btnFinnish.TabIndex = 8;
            this.btnFinnish.Text = "Cancel";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // cmbPart
            // 
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Location = new System.Drawing.Point(100, 49);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(218, 21);
            this.cmbPart.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Part";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantity";
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(15, 154);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(133, 23);
            this.btnAddPart.TabIndex = 13;
            this.btnAddPart.Text = "Add part";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // countPart
            // 
            this.countPart.Location = new System.Drawing.Point(100, 77);
            this.countPart.Name = "countPart";
            this.countPart.Size = new System.Drawing.Size(218, 20);
            this.countPart.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Assembly";
            // 
            // txtAssemblyID
            // 
            this.txtAssemblyID.Location = new System.Drawing.Point(100, 23);
            this.txtAssemblyID.Name = "txtAssemblyID";
            this.txtAssemblyID.Size = new System.Drawing.Size(218, 20);
            this.txtAssemblyID.TabIndex = 16;
            // 
            // NewAssemblyDetailPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 258);
            this.Controls.Add(this.txtAssemblyID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countPart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPart);
            this.Controls.Add(this.btnFinnish);
            this.Name = "NewAssemblyDetailPart";
            this.Text = "New assembly part";
            this.Load += new System.EventHandler(this.NewAssemblyDetailPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.NumericUpDown countPart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAssemblyID;
    }
}
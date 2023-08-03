
namespace MvE_SQL_test
{
    partial class NewJobOrderPart
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
            this.BtnFinnish = new System.Windows.Forms.Button();
            this.txtProjectDetailID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countPart = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.BtnAddPart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countPart)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(180, 176);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(146, 23);
            this.BtnFinnish.TabIndex = 11;
            this.BtnFinnish.Text = "Cancel";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // txtProjectDetailID
            // 
            this.txtProjectDetailID.Location = new System.Drawing.Point(108, 9);
            this.txtProjectDetailID.Name = "txtProjectDetailID";
            this.txtProjectDetailID.ReadOnly = true;
            this.txtProjectDetailID.Size = new System.Drawing.Size(218, 20);
            this.txtProjectDetailID.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Job order ID";
            // 
            // countPart
            // 
            this.countPart.DecimalPlaces = 1;
            this.countPart.Location = new System.Drawing.Point(108, 63);
            this.countPart.Name = "countPart";
            this.countPart.Size = new System.Drawing.Size(218, 20);
            this.countPart.TabIndex = 18;
            this.countPart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Part";
            // 
            // cmbPart
            // 
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Location = new System.Drawing.Point(108, 35);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(218, 21);
            this.cmbPart.TabIndex = 15;
            // 
            // BtnAddPart
            // 
            this.BtnAddPart.Location = new System.Drawing.Point(12, 176);
            this.BtnAddPart.Name = "BtnAddPart";
            this.BtnAddPart.Size = new System.Drawing.Size(133, 23);
            this.BtnAddPart.TabIndex = 19;
            this.BtnAddPart.Text = "Add part";
            this.BtnAddPart.UseVisualStyleBackColor = true;
            // 
            // NewJobOrderPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.BtnAddPart);
            this.Controls.Add(this.countPart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPart);
            this.Controls.Add(this.txtProjectDetailID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFinnish);
            this.Name = "NewJobOrderPart";
            this.Text = "New job order part";
            this.Load += new System.EventHandler(this.NewProjectDetailPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFinnish;
        private System.Windows.Forms.TextBox txtProjectDetailID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown countPart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.Button BtnAddPart;
    }
}
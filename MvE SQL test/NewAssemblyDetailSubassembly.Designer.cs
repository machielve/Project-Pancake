
namespace MvE_SQL_test
{
    partial class NewAssemblyDetailSubassembly
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
            this.countSubs = new System.Windows.Forms.NumericUpDown();
            this.BtnAddSubs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubs = new System.Windows.Forms.ComboBox();
            this.BtnFinnish = new System.Windows.Forms.Button();
            this.ChboxPhantom = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countSubs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAssemblyID
            // 
            this.txtAssemblyID.Location = new System.Drawing.Point(100, 23);
            this.txtAssemblyID.Name = "txtAssemblyID";
            this.txtAssemblyID.ReadOnly = true;
            this.txtAssemblyID.Size = new System.Drawing.Size(218, 20);
            this.txtAssemblyID.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Assembly";
            // 
            // countSubs
            // 
            this.countSubs.DecimalPlaces = 1;
            this.countSubs.Location = new System.Drawing.Point(100, 77);
            this.countSubs.Name = "countSubs";
            this.countSubs.Size = new System.Drawing.Size(218, 20);
            this.countSubs.TabIndex = 30;
            // 
            // BtnAddSubs
            // 
            this.BtnAddSubs.Location = new System.Drawing.Point(12, 154);
            this.BtnAddSubs.Name = "BtnAddSubs";
            this.BtnAddSubs.Size = new System.Drawing.Size(133, 23);
            this.BtnAddSubs.TabIndex = 29;
            this.BtnAddSubs.Text = "Add Subassembly";
            this.BtnAddSubs.UseVisualStyleBackColor = true;
            this.BtnAddSubs.Click += new System.EventHandler(this.BtnAddSubs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Subassembly";
            // 
            // cmbSubs
            // 
            this.cmbSubs.FormattingEnabled = true;
            this.cmbSubs.Location = new System.Drawing.Point(100, 49);
            this.cmbSubs.Name = "cmbSubs";
            this.cmbSubs.Size = new System.Drawing.Size(218, 21);
            this.cmbSubs.TabIndex = 26;
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(185, 154);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(133, 23);
            this.BtnFinnish.TabIndex = 25;
            this.BtnFinnish.Text = "Cancel";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // ChboxPhantom
            // 
            this.ChboxPhantom.AutoSize = true;
            this.ChboxPhantom.Location = new System.Drawing.Point(100, 104);
            this.ChboxPhantom.Name = "ChboxPhantom";
            this.ChboxPhantom.Size = new System.Drawing.Size(15, 14);
            this.ChboxPhantom.TabIndex = 33;
            this.ChboxPhantom.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Phantom";
            // 
            // NewAssemblyDetailSubassembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 258);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChboxPhantom);
            this.Controls.Add(this.txtAssemblyID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countSubs);
            this.Controls.Add(this.BtnAddSubs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSubs);
            this.Controls.Add(this.BtnFinnish);
            this.Name = "NewAssemblyDetailSubassembly";
            this.Text = "New assembly subassembly";
            this.Load += new System.EventHandler(this.NewAssemblyDetailSubassembly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countSubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAssemblyID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown countSubs;
        private System.Windows.Forms.Button BtnAddSubs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubs;
        private System.Windows.Forms.Button BtnFinnish;
        private System.Windows.Forms.CheckBox ChboxPhantom;
        private System.Windows.Forms.Label label4;
    }
}

namespace MvE_SQL_test
{
    partial class NewProjectAssembly
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
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddPart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAssembly = new System.Windows.Forms.ComboBox();
            this.BtnFinnish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProjectID
            // 
            this.txtProjectID.Location = new System.Drawing.Point(100, 15);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.ReadOnly = true;
            this.txtProjectID.Size = new System.Drawing.Size(218, 20);
            this.txtProjectID.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Project";
            // 
            // BtnAddPart
            // 
            this.BtnAddPart.Location = new System.Drawing.Point(12, 198);
            this.BtnAddPart.Name = "BtnAddPart";
            this.BtnAddPart.Size = new System.Drawing.Size(133, 23);
            this.BtnAddPart.TabIndex = 20;
            this.BtnAddPart.Text = "Add assembly";
            this.BtnAddPart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Assembly";
            // 
            // cmbAssembly
            // 
            this.cmbAssembly.FormattingEnabled = true;
            this.cmbAssembly.Location = new System.Drawing.Point(100, 41);
            this.cmbAssembly.Name = "cmbAssembly";
            this.cmbAssembly.Size = new System.Drawing.Size(218, 21);
            this.cmbAssembly.TabIndex = 18;
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(185, 198);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(133, 23);
            this.BtnFinnish.TabIndex = 17;
            this.BtnFinnish.Text = "Cancel";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // NewProjectAssembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 261);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAddPart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAssembly);
            this.Controls.Add(this.BtnFinnish);
            this.Name = "NewProjectAssembly";
            this.Text = "New project assembly";
            this.Load += new System.EventHandler(this.NewProjectAssembly_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAddPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAssembly;
        private System.Windows.Forms.Button BtnFinnish;
    }
}
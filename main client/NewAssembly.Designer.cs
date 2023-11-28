
namespace Project_pancake
{
    partial class NewAssembly
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
            this.BtnNewAssembly = new System.Windows.Forms.Button();
            this.BtnAddAnotherAssembly = new System.Windows.Forms.Button();
            this.txtAssemblyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAssemblyID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(15, 179);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(146, 23);
            this.BtnFinnish.TabIndex = 1;
            this.BtnFinnish.Text = "Finnish";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // BtnNewAssembly
            // 
            this.BtnNewAssembly.Location = new System.Drawing.Point(108, 118);
            this.BtnNewAssembly.Name = "BtnNewAssembly";
            this.BtnNewAssembly.Size = new System.Drawing.Size(234, 23);
            this.BtnNewAssembly.TabIndex = 6;
            this.BtnNewAssembly.Text = "Add new assembly";
            this.BtnNewAssembly.UseVisualStyleBackColor = true;
            this.BtnNewAssembly.Click += new System.EventHandler(this.BtnNewAssembly_Click);
            // 
            // BtnAddAnotherAssembly
            // 
            this.BtnAddAnotherAssembly.Location = new System.Drawing.Point(203, 179);
            this.BtnAddAnotherAssembly.Name = "BtnAddAnotherAssembly";
            this.BtnAddAnotherAssembly.Size = new System.Drawing.Size(139, 23);
            this.BtnAddAnotherAssembly.TabIndex = 7;
            this.BtnAddAnotherAssembly.Text = "Add another assembly";
            this.BtnAddAnotherAssembly.UseVisualStyleBackColor = true;
            this.BtnAddAnotherAssembly.Click += new System.EventHandler(this.BtnAddAnotherAssembly_Click);
            // 
            // txtAssemblyName
            // 
            this.txtAssemblyName.Location = new System.Drawing.Point(108, 20);
            this.txtAssemblyName.Name = "txtAssemblyName";
            this.txtAssemblyName.Size = new System.Drawing.Size(234, 20);
            this.txtAssemblyName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Assembly name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Assembly ID";
            // 
            // txtAssemblyID
            // 
            this.txtAssemblyID.Location = new System.Drawing.Point(108, 76);
            this.txtAssemblyID.Name = "txtAssemblyID";
            this.txtAssemblyID.ReadOnly = true;
            this.txtAssemblyID.Size = new System.Drawing.Size(234, 20);
            this.txtAssemblyID.TabIndex = 11;
            // 
            // NewAssembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.txtAssemblyID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAssemblyName);
            this.Controls.Add(this.BtnAddAnotherAssembly);
            this.Controls.Add(this.BtnNewAssembly);
            this.Controls.Add(this.BtnFinnish);
            this.Name = "NewAssembly";
            this.Text = "New Assembly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFinnish;
        private System.Windows.Forms.Button BtnNewAssembly;
        private System.Windows.Forms.Button BtnAddAnotherAssembly;
        private System.Windows.Forms.TextBox txtAssemblyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAssemblyID;
    }
}
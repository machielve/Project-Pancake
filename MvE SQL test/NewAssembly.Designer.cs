
namespace MvE_SQL_test
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
            this.btnFinnish = new System.Windows.Forms.Button();
            this.btnNewAssembly = new System.Windows.Forms.Button();
            this.btnAddAnotherAssembly = new System.Windows.Forms.Button();
            this.txtAssemblyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(15, 179);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(146, 23);
            this.btnFinnish.TabIndex = 1;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            // 
            // btnNewAssembly
            // 
            this.btnNewAssembly.Location = new System.Drawing.Point(108, 118);
            this.btnNewAssembly.Name = "btnNewAssembly";
            this.btnNewAssembly.Size = new System.Drawing.Size(234, 23);
            this.btnNewAssembly.TabIndex = 6;
            this.btnNewAssembly.Text = "Add new assembly";
            this.btnNewAssembly.UseVisualStyleBackColor = true;
            // 
            // btnAddAnotherAssembly
            // 
            this.btnAddAnotherAssembly.Location = new System.Drawing.Point(203, 179);
            this.btnAddAnotherAssembly.Name = "btnAddAnotherAssembly";
            this.btnAddAnotherAssembly.Size = new System.Drawing.Size(139, 23);
            this.btnAddAnotherAssembly.TabIndex = 7;
            this.btnAddAnotherAssembly.Text = "Add another assembly";
            this.btnAddAnotherAssembly.UseVisualStyleBackColor = true;
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
            // txtUnitID
            // 
            this.txtUnitID.Location = new System.Drawing.Point(108, 76);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.ReadOnly = true;
            this.txtUnitID.Size = new System.Drawing.Size(234, 20);
            this.txtUnitID.TabIndex = 11;
            // 
            // NewAssembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.txtUnitID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAssemblyName);
            this.Controls.Add(this.btnAddAnotherAssembly);
            this.Controls.Add(this.btnNewAssembly);
            this.Controls.Add(this.btnFinnish);
            this.Name = "NewAssembly";
            this.Text = "New Assembly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.Button btnNewAssembly;
        private System.Windows.Forms.Button btnAddAnotherAssembly;
        private System.Windows.Forms.TextBox txtAssemblyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitID;
    }
}
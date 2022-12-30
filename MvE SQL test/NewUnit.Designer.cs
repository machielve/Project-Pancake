
namespace MvE_SQL_test
{
    partial class NewUnit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            this.btnNewUnit = new System.Windows.Forms.Button();
            this.btnAddAnotherUnit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(15, 179);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(146, 23);
            this.btnFinnish.TabIndex = 0;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unit name";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(108, 20);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(234, 20);
            this.txtUnitName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unit ID";
            // 
            // txtUnitID
            // 
            this.txtUnitID.Location = new System.Drawing.Point(108, 52);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.ReadOnly = true;
            this.txtUnitID.Size = new System.Drawing.Size(234, 20);
            this.txtUnitID.TabIndex = 4;
            // 
            // btnNewUnit
            // 
            this.btnNewUnit.Location = new System.Drawing.Point(108, 118);
            this.btnNewUnit.Name = "btnNewUnit";
            this.btnNewUnit.Size = new System.Drawing.Size(234, 23);
            this.btnNewUnit.TabIndex = 5;
            this.btnNewUnit.Text = "Add new unit";
            this.btnNewUnit.UseVisualStyleBackColor = true;
            this.btnNewUnit.Click += new System.EventHandler(this.btnNewUnit_Click);
            // 
            // btnAddAnotherUnit
            // 
            this.btnAddAnotherUnit.Location = new System.Drawing.Point(203, 179);
            this.btnAddAnotherUnit.Name = "btnAddAnotherUnit";
            this.btnAddAnotherUnit.Size = new System.Drawing.Size(139, 23);
            this.btnAddAnotherUnit.TabIndex = 6;
            this.btnAddAnotherUnit.Text = "Add another unit";
            this.btnAddAnotherUnit.UseVisualStyleBackColor = true;
            this.btnAddAnotherUnit.Click += new System.EventHandler(this.btnAddAnotherUnit_Click);
            // 
            // NewUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 260);
            this.Controls.Add(this.btnAddAnotherUnit);
            this.Controls.Add(this.btnNewUnit);
            this.Controls.Add(this.txtUnitID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinnish);
            this.Name = "NewUnit";
            this.Text = "New Unit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitID;
        private System.Windows.Forms.Button btnNewUnit;
        private System.Windows.Forms.Button btnAddAnotherUnit;
    }
}
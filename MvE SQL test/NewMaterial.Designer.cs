
namespace MvE_SQL_test
{
    partial class NewMaterial
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
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFinnish = new System.Windows.Forms.Button();
            this.BtnNewMaterial = new System.Windows.Forms.Button();
            this.BtnAddAnotherUnit = new System.Windows.Forms.Button();
            this.txtMaterialID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Location = new System.Drawing.Point(108, 20);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(234, 20);
            this.txtMaterialName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Material name";
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(15, 179);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(146, 23);
            this.BtnFinnish.TabIndex = 5;
            this.BtnFinnish.Text = "Finnish";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // BtnNewMaterial
            // 
            this.BtnNewMaterial.Location = new System.Drawing.Point(108, 118);
            this.BtnNewMaterial.Name = "BtnNewMaterial";
            this.BtnNewMaterial.Size = new System.Drawing.Size(234, 23);
            this.BtnNewMaterial.TabIndex = 6;
            this.BtnNewMaterial.Text = "Add new material";
            this.BtnNewMaterial.UseVisualStyleBackColor = true;
            this.BtnNewMaterial.Click += new System.EventHandler(this.BtnNewMaterial_Click);
            // 
            // BtnAddAnotherUnit
            // 
            this.BtnAddAnotherUnit.Location = new System.Drawing.Point(203, 179);
            this.BtnAddAnotherUnit.Name = "BtnAddAnotherUnit";
            this.BtnAddAnotherUnit.Size = new System.Drawing.Size(139, 23);
            this.BtnAddAnotherUnit.TabIndex = 9;
            this.BtnAddAnotherUnit.Text = "Add another unit";
            this.BtnAddAnotherUnit.UseVisualStyleBackColor = true;
            this.BtnAddAnotherUnit.Click += new System.EventHandler(this.BtnAddAnotherUnit_Click);
            // 
            // txtMaterialID
            // 
            this.txtMaterialID.Location = new System.Drawing.Point(108, 46);
            this.txtMaterialID.Name = "txtMaterialID";
            this.txtMaterialID.ReadOnly = true;
            this.txtMaterialID.Size = new System.Drawing.Size(234, 20);
            this.txtMaterialID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Material ID";
            // 
            // NewMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.BtnAddAnotherUnit);
            this.Controls.Add(this.txtMaterialID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnNewMaterial);
            this.Controls.Add(this.BtnFinnish);
            this.Controls.Add(this.txtMaterialName);
            this.Controls.Add(this.label1);
            this.Name = "NewMaterial";
            this.Text = "New material";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFinnish;
        private System.Windows.Forms.Button BtnNewMaterial;
        private System.Windows.Forms.Button BtnAddAnotherUnit;
        private System.Windows.Forms.TextBox txtMaterialID;
        private System.Windows.Forms.Label label2;
    }
}
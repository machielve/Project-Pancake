
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
            this.btnFinnish = new System.Windows.Forms.Button();
            this.btnNewMaterial = new System.Windows.Forms.Button();
            this.btnAddAnotherUnit = new System.Windows.Forms.Button();
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
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(15, 179);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(146, 23);
            this.btnFinnish.TabIndex = 5;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // btnNewMaterial
            // 
            this.btnNewMaterial.Location = new System.Drawing.Point(108, 118);
            this.btnNewMaterial.Name = "btnNewMaterial";
            this.btnNewMaterial.Size = new System.Drawing.Size(234, 23);
            this.btnNewMaterial.TabIndex = 6;
            this.btnNewMaterial.Text = "Add new material";
            this.btnNewMaterial.UseVisualStyleBackColor = true;
            this.btnNewMaterial.Click += new System.EventHandler(this.btnNewMaterial_Click);
            // 
            // btnAddAnotherUnit
            // 
            this.btnAddAnotherUnit.Location = new System.Drawing.Point(203, 179);
            this.btnAddAnotherUnit.Name = "btnAddAnotherUnit";
            this.btnAddAnotherUnit.Size = new System.Drawing.Size(139, 23);
            this.btnAddAnotherUnit.TabIndex = 9;
            this.btnAddAnotherUnit.Text = "Add another unit";
            this.btnAddAnotherUnit.UseVisualStyleBackColor = true;
            this.btnAddAnotherUnit.Click += new System.EventHandler(this.btnAddAnotherUnit_Click);
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
            this.Controls.Add(this.btnAddAnotherUnit);
            this.Controls.Add(this.txtMaterialID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNewMaterial);
            this.Controls.Add(this.btnFinnish);
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
        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.Button btnNewMaterial;
        private System.Windows.Forms.Button btnAddAnotherUnit;
        private System.Windows.Forms.TextBox txtMaterialID;
        private System.Windows.Forms.Label label2;
    }
}
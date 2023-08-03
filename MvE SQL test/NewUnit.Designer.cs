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
            this.components = new System.ComponentModel.Container();
            this.BtnFinnish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            this.BtnNewUnit = new System.Windows.Forms.Button();
            this.BtnAddAnotherMaterial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnitGroup = new System.Windows.Forms.ComboBox();
            this.tUNITBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tUNITBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(15, 179);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(146, 23);
            this.BtnFinnish.TabIndex = 0;
            this.BtnFinnish.Text = "Finnish";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
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
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unit ID";
            // 
            // txtUnitID
            // 
            this.txtUnitID.Location = new System.Drawing.Point(108, 72);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.ReadOnly = true;
            this.txtUnitID.Size = new System.Drawing.Size(234, 20);
            this.txtUnitID.TabIndex = 4;
            // 
            // BtnNewUnit
            // 
            this.BtnNewUnit.Location = new System.Drawing.Point(108, 118);
            this.BtnNewUnit.Name = "BtnNewUnit";
            this.BtnNewUnit.Size = new System.Drawing.Size(234, 23);
            this.BtnNewUnit.TabIndex = 5;
            this.BtnNewUnit.Text = "Add new unit";
            this.BtnNewUnit.UseVisualStyleBackColor = true;
            this.BtnNewUnit.Click += new System.EventHandler(this.BtnNewUnit_Click);
            // 
            // BtnAddAnotherMaterial
            // 
            this.BtnAddAnotherMaterial.Location = new System.Drawing.Point(203, 179);
            this.BtnAddAnotherMaterial.Name = "BtnAddAnotherMaterial";
            this.BtnAddAnotherMaterial.Size = new System.Drawing.Size(139, 23);
            this.BtnAddAnotherMaterial.TabIndex = 6;
            this.BtnAddAnotherMaterial.Text = "Add another material";
            this.BtnAddAnotherMaterial.UseVisualStyleBackColor = true;
            this.BtnAddAnotherMaterial.Click += new System.EventHandler(this.BtnAddAnotherUnit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unit group";
            // 
            // txtUnitGroup
            // 
            this.txtUnitGroup.FormattingEnabled = true;
            this.txtUnitGroup.Items.AddRange(new object[] {
            "-",
            "Time",
            "Weight",
            "Length"});
            this.txtUnitGroup.Location = new System.Drawing.Point(108, 46);
            this.txtUnitGroup.Name = "txtUnitGroup";
            this.txtUnitGroup.Size = new System.Drawing.Size(234, 21);
            this.txtUnitGroup.TabIndex = 9;
            // 
            // NewUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.txtUnitGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAddAnotherMaterial);
            this.Controls.Add(this.BtnNewUnit);
            this.Controls.Add(this.txtUnitID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFinnish);
            this.Name = "NewUnit";
            this.Text = "New Unit";
            ((System.ComponentModel.ISupportInitialize)(this.tUNITBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFinnish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitID;
        private System.Windows.Forms.Button BtnNewUnit;
        private System.Windows.Forms.Button BtnAddAnotherMaterial;
        private System.Windows.Forms.BindingSource tUNITBindingSource;
        private System.Windows.Forms.BindingSource tUNITBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtUnitGroup;
    }
}
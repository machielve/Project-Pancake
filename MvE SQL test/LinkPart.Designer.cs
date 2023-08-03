
namespace MvE_SQL_test
{
    partial class LinkPart
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
            this.BtnLinkPart = new System.Windows.Forms.Button();
            this.BtnFinnish = new System.Windows.Forms.Button();
            this.txtAssemblyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDrawingNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.countDrawingRevision = new System.Windows.Forms.NumericUpDown();
            this.countAssemblyWeight = new System.Windows.Forms.NumericUpDown();
            this.cmbPartType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPartUnit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAssemblyID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countDrawingRevision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countAssemblyWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLinkPart
            // 
            this.BtnLinkPart.Location = new System.Drawing.Point(200, 473);
            this.BtnLinkPart.Name = "BtnLinkPart";
            this.BtnLinkPart.Size = new System.Drawing.Size(139, 23);
            this.BtnLinkPart.TabIndex = 18;
            this.BtnLinkPart.Text = "Link part";
            this.BtnLinkPart.UseVisualStyleBackColor = true;
            this.BtnLinkPart.Click += new System.EventHandler(this.BtnLinkPart_Click);
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(12, 473);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(146, 23);
            this.BtnFinnish.TabIndex = 17;
            this.BtnFinnish.Text = "Finnish";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // txtAssemblyName
            // 
            this.txtAssemblyName.Location = new System.Drawing.Point(105, 17);
            this.txtAssemblyName.Name = "txtAssemblyName";
            this.txtAssemblyName.ReadOnly = true;
            this.txtAssemblyName.Size = new System.Drawing.Size(234, 20);
            this.txtAssemblyName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Assembly name";
            // 
            // cmbPart
            // 
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Location = new System.Drawing.Point(105, 211);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(234, 21);
            this.cmbPart.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Part selection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Weight";
            // 
            // txtDrawingNumber
            // 
            this.txtDrawingNumber.Location = new System.Drawing.Point(105, 95);
            this.txtDrawingNumber.Name = "txtDrawingNumber";
            this.txtDrawingNumber.ReadOnly = true;
            this.txtDrawingNumber.Size = new System.Drawing.Size(234, 20);
            this.txtDrawingNumber.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Drawing number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Drawing revision";
            // 
            // countDrawingRevision
            // 
            this.countDrawingRevision.Location = new System.Drawing.Point(105, 121);
            this.countDrawingRevision.Name = "countDrawingRevision";
            this.countDrawingRevision.ReadOnly = true;
            this.countDrawingRevision.Size = new System.Drawing.Size(234, 20);
            this.countDrawingRevision.TabIndex = 28;
            // 
            // countAssemblyWeight
            // 
            this.countAssemblyWeight.DecimalPlaces = 2;
            this.countAssemblyWeight.Location = new System.Drawing.Point(105, 69);
            this.countAssemblyWeight.Name = "countAssemblyWeight";
            this.countAssemblyWeight.ReadOnly = true;
            this.countAssemblyWeight.Size = new System.Drawing.Size(234, 20);
            this.countAssemblyWeight.TabIndex = 29;
            // 
            // cmbPartType
            // 
            this.cmbPartType.FormattingEnabled = true;
            this.cmbPartType.Items.AddRange(new object[] {
            "-",
            "Time",
            "Weight",
            "Length"});
            this.cmbPartType.Location = new System.Drawing.Point(105, 238);
            this.cmbPartType.Name = "cmbPartType";
            this.cmbPartType.Size = new System.Drawing.Size(234, 21);
            this.cmbPartType.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Part type";
            // 
            // cmbPartUnit
            // 
            this.cmbPartUnit.FormattingEnabled = true;
            this.cmbPartUnit.Items.AddRange(new object[] {
            "-",
            "Time",
            "Weight",
            "Length"});
            this.cmbPartUnit.Location = new System.Drawing.Point(105, 265);
            this.cmbPartUnit.Name = "cmbPartUnit";
            this.cmbPartUnit.Size = new System.Drawing.Size(234, 21);
            this.cmbPartUnit.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Part unit";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Items.AddRange(new object[] {
            "-",
            "Time",
            "Weight",
            "Length"});
            this.cmbMaterial.Location = new System.Drawing.Point(105, 292);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(234, 21);
            this.cmbMaterial.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Material";
            // 
            // txtAssemblyID
            // 
            this.txtAssemblyID.Location = new System.Drawing.Point(105, 43);
            this.txtAssemblyID.Name = "txtAssemblyID";
            this.txtAssemblyID.ReadOnly = true;
            this.txtAssemblyID.Size = new System.Drawing.Size(234, 20);
            this.txtAssemblyID.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Assembly ID";
            // 
            // txtPartID
            // 
            this.txtPartID.Location = new System.Drawing.Point(105, 147);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.ReadOnly = true;
            this.txtPartID.Size = new System.Drawing.Size(234, 20);
            this.txtPartID.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Linked part";
            // 
            // LinkPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 508);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAssemblyID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbPartUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbPartType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.countAssemblyWeight);
            this.Controls.Add(this.countDrawingRevision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDrawingNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPart);
            this.Controls.Add(this.txtAssemblyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLinkPart);
            this.Controls.Add(this.BtnFinnish);
            this.Name = "LinkPart";
            this.Text = "Link part to assembly";
            this.Load += new System.EventHandler(this.LinkPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countDrawingRevision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countAssemblyWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLinkPart;
        private System.Windows.Forms.Button BtnFinnish;
        private System.Windows.Forms.TextBox txtAssemblyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDrawingNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown countDrawingRevision;
        private System.Windows.Forms.NumericUpDown countAssemblyWeight;
        private System.Windows.Forms.ComboBox cmbPartType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPartUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAssemblyID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Label label10;
    }
}
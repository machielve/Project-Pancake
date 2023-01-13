
namespace MvE_SQL_test
{
    partial class NewPart
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
            this.cmbPartType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAnotherUnit = new System.Windows.Forms.Button();
            this.btnNewUnit = new System.Windows.Forms.Button();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinnish = new System.Windows.Forms.Button();
            this.txtPartMemo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPartUnit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbWeightUnit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDrawingNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDrawingRevision = new System.Windows.Forms.NumericUpDown();
            this.countRevision = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDrawingRevision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countRevision)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPartType
            // 
            this.cmbPartType.FormattingEnabled = true;
            this.cmbPartType.Items.AddRange(new object[] {
            "-",
            "Time",
            "Weight",
            "Length"});
            this.cmbPartType.Location = new System.Drawing.Point(109, 153);
            this.cmbPartType.Name = "cmbPartType";
            this.cmbPartType.Size = new System.Drawing.Size(234, 21);
            this.cmbPartType.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Part type";
            // 
            // btnAddAnotherUnit
            // 
            this.btnAddAnotherUnit.Location = new System.Drawing.Point(204, 454);
            this.btnAddAnotherUnit.Name = "btnAddAnotherUnit";
            this.btnAddAnotherUnit.Size = new System.Drawing.Size(139, 23);
            this.btnAddAnotherUnit.TabIndex = 16;
            this.btnAddAnotherUnit.Text = "Add another part";
            this.btnAddAnotherUnit.UseVisualStyleBackColor = true;
            this.btnAddAnotherUnit.Click += new System.EventHandler(this.btnAddAnotherUnit_Click);
            // 
            // btnNewUnit
            // 
            this.btnNewUnit.Location = new System.Drawing.Point(109, 404);
            this.btnNewUnit.Name = "btnNewUnit";
            this.btnNewUnit.Size = new System.Drawing.Size(234, 23);
            this.btnNewUnit.TabIndex = 15;
            this.btnNewUnit.Text = "Add new part";
            this.btnNewUnit.UseVisualStyleBackColor = true;
            this.btnNewUnit.Click += new System.EventHandler(this.btnNewUnit_Click);
            // 
            // txtUnitID
            // 
            this.txtUnitID.Location = new System.Drawing.Point(109, 378);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.ReadOnly = true;
            this.txtUnitID.Size = new System.Drawing.Size(234, 20);
            this.txtUnitID.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Part ID";
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(109, 17);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(234, 20);
            this.txtPartName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Part name";
            // 
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(16, 454);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(146, 23);
            this.btnFinnish.TabIndex = 10;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // txtPartMemo
            // 
            this.txtPartMemo.Location = new System.Drawing.Point(109, 69);
            this.txtPartMemo.Multiline = true;
            this.txtPartMemo.Name = "txtPartMemo";
            this.txtPartMemo.Size = new System.Drawing.Size(234, 78);
            this.txtPartMemo.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Part memo";
            // 
            // cmbPartUnit
            // 
            this.cmbPartUnit.FormattingEnabled = true;
            this.cmbPartUnit.Items.AddRange(new object[] {
            "-",
            "Time",
            "Weight",
            "Length"});
            this.cmbPartUnit.Location = new System.Drawing.Point(109, 180);
            this.cmbPartUnit.Name = "cmbPartUnit";
            this.cmbPartUnit.Size = new System.Drawing.Size(234, 21);
            this.cmbPartUnit.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Part unit";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Items.AddRange(new object[] {
            "-",
            "Time",
            "Weight",
            "Length"});
            this.cmbMaterial.Location = new System.Drawing.Point(109, 207);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(234, 21);
            this.cmbMaterial.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Material";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(109, 235);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(234, 20);
            this.numericUpDown1.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Weight";
            // 
            // cmbWeightUnit
            // 
            this.cmbWeightUnit.FormattingEnabled = true;
            this.cmbWeightUnit.Items.AddRange(new object[] {
            "-",
            "Time",
            "Weight",
            "Length"});
            this.cmbWeightUnit.Location = new System.Drawing.Point(109, 261);
            this.cmbWeightUnit.Name = "cmbWeightUnit";
            this.cmbWeightUnit.Size = new System.Drawing.Size(234, 21);
            this.cmbWeightUnit.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Weight unit";
            // 
            // txtDrawingNumber
            // 
            this.txtDrawingNumber.Location = new System.Drawing.Point(109, 288);
            this.txtDrawingNumber.Name = "txtDrawingNumber";
            this.txtDrawingNumber.Size = new System.Drawing.Size(234, 20);
            this.txtDrawingNumber.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Drawing number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Drawing revision";
            // 
            // txtDrawingRevision
            // 
            this.txtDrawingRevision.Location = new System.Drawing.Point(109, 315);
            this.txtDrawingRevision.Name = "txtDrawingRevision";
            this.txtDrawingRevision.Size = new System.Drawing.Size(234, 20);
            this.txtDrawingRevision.TabIndex = 32;
            // 
            // countRevision
            // 
            this.countRevision.Location = new System.Drawing.Point(109, 43);
            this.countRevision.Name = "countRevision";
            this.countRevision.Size = new System.Drawing.Size(234, 20);
            this.countRevision.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Revision";
            // 
            // NewPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 508);
            this.Controls.Add(this.countRevision);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDrawingRevision);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDrawingNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbWeightUnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbPartUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPartMemo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPartType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddAnotherUnit);
            this.Controls.Add(this.btnNewUnit);
            this.Controls.Add(this.txtUnitID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinnish);
            this.Name = "NewPart";
            this.Text = "New Part";
            this.Load += new System.EventHandler(this.NewPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDrawingRevision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countRevision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPartType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAnotherUnit;
        private System.Windows.Forms.Button btnNewUnit;
        private System.Windows.Forms.TextBox txtUnitID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.TextBox txtPartMemo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPartUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbWeightUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDrawingNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtDrawingRevision;
        private System.Windows.Forms.NumericUpDown countRevision;
        private System.Windows.Forms.Label label11;
    }
}
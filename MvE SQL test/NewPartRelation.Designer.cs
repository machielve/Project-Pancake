
namespace Project_pancake
{
    partial class NewPartRelation
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
            this.cmbRelation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddAnotherRelation = new System.Windows.Forms.Button();
            this.BtnNewRelation = new System.Windows.Forms.Button();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFinnish = new System.Windows.Forms.Button();
            this.countPrice = new System.Windows.Forms.NumericUpDown();
            this.CountQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCreateRelation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRelation
            // 
            this.cmbRelation.FormattingEnabled = true;
            this.cmbRelation.Items.AddRange(new object[] {
            "-",
            "Time",
            "Weight",
            "Length"});
            this.cmbRelation.Location = new System.Drawing.Point(108, 39);
            this.cmbRelation.Name = "cmbRelation";
            this.cmbRelation.Size = new System.Drawing.Size(234, 21);
            this.cmbRelation.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Relation";
            // 
            // BtnAddAnotherRelation
            // 
            this.BtnAddAnotherRelation.Location = new System.Drawing.Point(196, 203);
            this.BtnAddAnotherRelation.Name = "BtnAddAnotherRelation";
            this.BtnAddAnotherRelation.Size = new System.Drawing.Size(146, 23);
            this.BtnAddAnotherRelation.TabIndex = 16;
            this.BtnAddAnotherRelation.Text = "Add another relation";
            this.BtnAddAnotherRelation.UseVisualStyleBackColor = true;
            this.BtnAddAnotherRelation.Click += new System.EventHandler(this.BtnAddAnotherRelation_Click);
            // 
            // BtnNewRelation
            // 
            this.BtnNewRelation.Location = new System.Drawing.Point(108, 131);
            this.BtnNewRelation.Name = "BtnNewRelation";
            this.BtnNewRelation.Size = new System.Drawing.Size(234, 23);
            this.BtnNewRelation.TabIndex = 15;
            this.BtnNewRelation.Text = "Add new relation";
            this.BtnNewRelation.UseVisualStyleBackColor = true;
            this.BtnNewRelation.Click += new System.EventHandler(this.BtnNewSupplier_Click);
            // 
            // txtPartID
            // 
            this.txtPartID.Location = new System.Drawing.Point(108, 13);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.ReadOnly = true;
            this.txtPartID.Size = new System.Drawing.Size(234, 20);
            this.txtPartID.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Part ID";
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(15, 203);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(146, 23);
            this.BtnFinnish.TabIndex = 10;
            this.BtnFinnish.Text = "Finnish";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // countPrice
            // 
            this.countPrice.DecimalPlaces = 2;
            this.countPrice.Location = new System.Drawing.Point(108, 67);
            this.countPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.countPrice.Name = "countPrice";
            this.countPrice.Size = new System.Drawing.Size(234, 20);
            this.countPrice.TabIndex = 19;
            // 
            // CountQuantity
            // 
            this.CountQuantity.Location = new System.Drawing.Point(108, 93);
            this.CountQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CountQuantity.Name = "CountQuantity";
            this.CountQuantity.Size = new System.Drawing.Size(234, 20);
            this.CountQuantity.TabIndex = 20;
            this.CountQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Total price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantity";
            // 
            // BtnCreateRelation
            // 
            this.BtnCreateRelation.Location = new System.Drawing.Point(196, 174);
            this.BtnCreateRelation.Name = "BtnCreateRelation";
            this.BtnCreateRelation.Size = new System.Drawing.Size(146, 23);
            this.BtnCreateRelation.TabIndex = 23;
            this.BtnCreateRelation.Text = "Create new relation";
            this.BtnCreateRelation.UseVisualStyleBackColor = true;
            this.BtnCreateRelation.Click += new System.EventHandler(this.BtnCreateSupplier_Click);
            // 
            // NewPartRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 263);
            this.Controls.Add(this.BtnCreateRelation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountQuantity);
            this.Controls.Add(this.countPrice);
            this.Controls.Add(this.cmbRelation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAddAnotherRelation);
            this.Controls.Add(this.BtnNewRelation);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnFinnish);
            this.Name = "NewPartRelation";
            this.Text = "New part relation";
            this.Load += new System.EventHandler(this.NewPartRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRelation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAddAnotherRelation;
        private System.Windows.Forms.Button BtnNewRelation;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFinnish;
        private System.Windows.Forms.NumericUpDown countPrice;
        private System.Windows.Forms.NumericUpDown CountQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCreateRelation;
    }
}
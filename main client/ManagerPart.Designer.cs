
namespace Project_pancake
{
    partial class ManagerPart
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
            this.DgvParts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFinnish = new System.Windows.Forms.Button();
            this.BtnLoadParts = new System.Windows.Forms.Button();
            this.BtnNewPart = new System.Windows.Forms.Button();
            this.DgvRelations = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddRelation = new System.Windows.Forms.Button();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.BtnRemoveRelation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRelations)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvParts
            // 
            this.DgvParts.AllowUserToAddRows = false;
            this.DgvParts.AllowUserToDeleteRows = false;
            this.DgvParts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvParts.Location = new System.Drawing.Point(165, 38);
            this.DgvParts.MaximumSize = new System.Drawing.Size(1500, 490);
            this.DgvParts.MinimumSize = new System.Drawing.Size(900, 490);
            this.DgvParts.Name = "DgvParts";
            this.DgvParts.Size = new System.Drawing.Size(1310, 490);
            this.DgvParts.TabIndex = 0;
            this.DgvParts.SelectionChanged += new System.EventHandler(this.DgvPart_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parts";
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(13, 668);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(133, 23);
            this.BtnFinnish.TabIndex = 8;
            this.BtnFinnish.Text = "Finnish";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // BtnLoadParts
            // 
            this.BtnLoadParts.Location = new System.Drawing.Point(13, 38);
            this.BtnLoadParts.Name = "BtnLoadParts";
            this.BtnLoadParts.Size = new System.Drawing.Size(133, 23);
            this.BtnLoadParts.TabIndex = 9;
            this.BtnLoadParts.Text = "Load parts";
            this.BtnLoadParts.UseVisualStyleBackColor = true;
            this.BtnLoadParts.Click += new System.EventHandler(this.BtnLoadParts_Click);
            // 
            // BtnNewPart
            // 
            this.BtnNewPart.Location = new System.Drawing.Point(13, 67);
            this.BtnNewPart.Name = "BtnNewPart";
            this.BtnNewPart.Size = new System.Drawing.Size(133, 23);
            this.BtnNewPart.TabIndex = 10;
            this.BtnNewPart.Text = "New part";
            this.BtnNewPart.UseVisualStyleBackColor = true;
            this.BtnNewPart.Click += new System.EventHandler(this.BtnNewPart_Click);
            // 
            // DgvRelations
            // 
            this.DgvRelations.AllowUserToAddRows = false;
            this.DgvRelations.AllowUserToDeleteRows = false;
            this.DgvRelations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRelations.Location = new System.Drawing.Point(165, 587);
            this.DgvRelations.Name = "DgvRelations";
            this.DgvRelations.Size = new System.Drawing.Size(1310, 104);
            this.DgvRelations.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Relations";
            // 
            // BtnAddRelation
            // 
            this.BtnAddRelation.Location = new System.Drawing.Point(13, 587);
            this.BtnAddRelation.Name = "BtnAddRelation";
            this.BtnAddRelation.Size = new System.Drawing.Size(133, 23);
            this.BtnAddRelation.TabIndex = 13;
            this.BtnAddRelation.Text = "Add Relation";
            this.BtnAddRelation.UseVisualStyleBackColor = true;
            this.BtnAddRelation.Click += new System.EventHandler(this.BtnAddRelation_Click);
            // 
            // txtPartID
            // 
            this.txtPartID.Location = new System.Drawing.Point(165, 548);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.ReadOnly = true;
            this.txtPartID.Size = new System.Drawing.Size(100, 20);
            this.txtPartID.TabIndex = 15;
            // 
            // BtnRemoveRelation
            // 
            this.BtnRemoveRelation.Location = new System.Drawing.Point(13, 616);
            this.BtnRemoveRelation.Name = "BtnRemoveRelation";
            this.BtnRemoveRelation.Size = new System.Drawing.Size(133, 23);
            this.BtnRemoveRelation.TabIndex = 16;
            this.BtnRemoveRelation.Text = "Remove relation";
            this.BtnRemoveRelation.UseVisualStyleBackColor = true;
            this.BtnRemoveRelation.Click += new System.EventHandler(this.BtnRemoveRelation_Click);
            // 
            // ManagerPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 811);
            this.Controls.Add(this.BtnRemoveRelation);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.BtnAddRelation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvRelations);
            this.Controls.Add(this.BtnNewPart);
            this.Controls.Add(this.BtnLoadParts);
            this.Controls.Add(this.BtnFinnish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvParts);
            this.Name = "ManagerPart";
            this.Text = "Part manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRelations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFinnish;
        private System.Windows.Forms.Button BtnLoadParts;
        private System.Windows.Forms.Button BtnNewPart;
        private System.Windows.Forms.DataGridView DgvRelations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddRelation;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Button BtnRemoveRelation;
    }
}
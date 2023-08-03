
namespace MvE_SQL_test
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
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinnish = new System.Windows.Forms.Button();
            this.btnLoadParts = new System.Windows.Forms.Button();
            this.btnNewPart = new System.Windows.Forms.Button();
            this.dgvRelations = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddRelation = new System.Windows.Forms.Button();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.btnRemoveRelation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(165, 38);
            this.dgvParts.MaximumSize = new System.Drawing.Size(1500, 490);
            this.dgvParts.MinimumSize = new System.Drawing.Size(900, 490);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(1310, 490);
            this.dgvParts.TabIndex = 0;
            this.dgvParts.SelectionChanged += new System.EventHandler(this.dgvPart_SelectionChanged);
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
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(13, 668);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(133, 23);
            this.btnFinnish.TabIndex = 8;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // btnLoadParts
            // 
            this.btnLoadParts.Location = new System.Drawing.Point(13, 38);
            this.btnLoadParts.Name = "btnLoadParts";
            this.btnLoadParts.Size = new System.Drawing.Size(133, 23);
            this.btnLoadParts.TabIndex = 9;
            this.btnLoadParts.Text = "Load parts";
            this.btnLoadParts.UseVisualStyleBackColor = true;
            this.btnLoadParts.Click += new System.EventHandler(this.btnLoadParts_Click);
            // 
            // btnNewPart
            // 
            this.btnNewPart.Location = new System.Drawing.Point(13, 67);
            this.btnNewPart.Name = "btnNewPart";
            this.btnNewPart.Size = new System.Drawing.Size(133, 23);
            this.btnNewPart.TabIndex = 10;
            this.btnNewPart.Text = "New part";
            this.btnNewPart.UseVisualStyleBackColor = true;
            this.btnNewPart.Click += new System.EventHandler(this.btnNewPart_Click);
            // 
            // dgvRelations
            // 
            this.dgvRelations.AllowUserToAddRows = false;
            this.dgvRelations.AllowUserToDeleteRows = false;
            this.dgvRelations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelations.Location = new System.Drawing.Point(165, 587);
            this.dgvRelations.Name = "dgvRelations";
            this.dgvRelations.Size = new System.Drawing.Size(1310, 104);
            this.dgvRelations.TabIndex = 11;
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
            // btnAddRelation
            // 
            this.btnAddRelation.Location = new System.Drawing.Point(13, 587);
            this.btnAddRelation.Name = "btnAddRelation";
            this.btnAddRelation.Size = new System.Drawing.Size(133, 23);
            this.btnAddRelation.TabIndex = 13;
            this.btnAddRelation.Text = "Add Relation";
            this.btnAddRelation.UseVisualStyleBackColor = true;
            this.btnAddRelation.Click += new System.EventHandler(this.btnAddRelation_Click);
            // 
            // txtPartID
            // 
            this.txtPartID.Location = new System.Drawing.Point(165, 548);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.ReadOnly = true;
            this.txtPartID.Size = new System.Drawing.Size(100, 20);
            this.txtPartID.TabIndex = 15;
            // 
            // btnRemoveRelation
            // 
            this.btnRemoveRelation.Location = new System.Drawing.Point(13, 616);
            this.btnRemoveRelation.Name = "btnRemoveRelation";
            this.btnRemoveRelation.Size = new System.Drawing.Size(133, 23);
            this.btnRemoveRelation.TabIndex = 16;
            this.btnRemoveRelation.Text = "Remove relation";
            this.btnRemoveRelation.UseVisualStyleBackColor = true;
            this.btnRemoveRelation.Click += new System.EventHandler(this.btnRemoveRelation_Click);
            // 
            // ManagerPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 811);
            this.Controls.Add(this.btnRemoveRelation);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.btnAddRelation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRelations);
            this.Controls.Add(this.btnNewPart);
            this.Controls.Add(this.btnLoadParts);
            this.Controls.Add(this.btnFinnish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvParts);
            this.Name = "ManagerPart";
            this.Text = "Part manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.Button btnLoadParts;
        private System.Windows.Forms.Button btnNewPart;
        private System.Windows.Forms.DataGridView dgvRelations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddRelation;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Button btnRemoveRelation;
    }
}
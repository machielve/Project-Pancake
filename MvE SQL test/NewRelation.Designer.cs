
namespace MvE_SQL_test
{
    partial class NewRelation
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
            this.btnAddAnotherRelation = new System.Windows.Forms.Button();
            this.txtRelationID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewRelation = new System.Windows.Forms.Button();
            this.btnFinnish = new System.Windows.Forms.Button();
            this.txtRelationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAnotherRelation
            // 
            this.btnAddAnotherRelation.Location = new System.Drawing.Point(211, 167);
            this.btnAddAnotherRelation.Name = "btnAddAnotherRelation";
            this.btnAddAnotherRelation.Size = new System.Drawing.Size(139, 23);
            this.btnAddAnotherRelation.TabIndex = 16;
            this.btnAddAnotherRelation.Text = "Add another relation";
            this.btnAddAnotherRelation.UseVisualStyleBackColor = true;
            this.btnAddAnotherRelation.Click += new System.EventHandler(this.btnAddAnotherRelation_Click);
            // 
            // txtRelationID
            // 
            this.txtRelationID.Location = new System.Drawing.Point(116, 34);
            this.txtRelationID.Name = "txtRelationID";
            this.txtRelationID.ReadOnly = true;
            this.txtRelationID.Size = new System.Drawing.Size(234, 20);
            this.txtRelationID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Relation ID";
            // 
            // btnNewRelation
            // 
            this.btnNewRelation.Location = new System.Drawing.Point(116, 106);
            this.btnNewRelation.Name = "btnNewRelation";
            this.btnNewRelation.Size = new System.Drawing.Size(234, 23);
            this.btnNewRelation.TabIndex = 13;
            this.btnNewRelation.Text = "Add new relation";
            this.btnNewRelation.UseVisualStyleBackColor = true;
            this.btnNewRelation.Click += new System.EventHandler(this.btnNewRelation_Click);
            // 
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(23, 167);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(146, 23);
            this.btnFinnish.TabIndex = 12;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // txtRelationName
            // 
            this.txtRelationName.Location = new System.Drawing.Point(116, 8);
            this.txtRelationName.Name = "txtRelationName";
            this.txtRelationName.Size = new System.Drawing.Size(234, 20);
            this.txtRelationName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Relation name";
            // 
            // NewRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.btnAddAnotherRelation);
            this.Controls.Add(this.txtRelationID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNewRelation);
            this.Controls.Add(this.btnFinnish);
            this.Controls.Add(this.txtRelationName);
            this.Controls.Add(this.label1);
            this.Name = "NewRelation";
            this.Text = "New relation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnotherRelation;
        private System.Windows.Forms.TextBox txtRelationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewRelation;
        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.TextBox txtRelationName;
        private System.Windows.Forms.Label label1;
    }
}

namespace MvE_SQL_test
{
    partial class ProjectManager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFinnish = new System.Windows.Forms.Button();
            this.btnUsedAssemblies = new System.Windows.Forms.Button();
            this.ProjectNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectNumber,
            this.ProjectName,
            this.TotalValue});
            this.dataGridView1.Location = new System.Drawing.Point(165, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Project";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(13, 346);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(133, 23);
            this.btnFinnish.TabIndex = 2;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // btnUsedAssemblies
            // 
            this.btnUsedAssemblies.Location = new System.Drawing.Point(13, 42);
            this.btnUsedAssemblies.Name = "btnUsedAssemblies";
            this.btnUsedAssemblies.Size = new System.Drawing.Size(133, 23);
            this.btnUsedAssemblies.TabIndex = 3;
            this.btnUsedAssemblies.Text = "See details";
            this.btnUsedAssemblies.UseVisualStyleBackColor = true;
            // 
            // ProjectNumber
            // 
            this.ProjectNumber.HeaderText = "Project number";
            this.ProjectNumber.Name = "ProjectNumber";
            this.ProjectNumber.Width = 200;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Project name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Width = 200;
            // 
            // TotalValue
            // 
            this.TotalValue.HeaderText = "Total value";
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.Width = 200;
            // 
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 412);
            this.Controls.Add(this.btnUsedAssemblies);
            this.Controls.Add(this.btnFinnish);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProjectManager";
            this.Text = "Project manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.Button btnUsedAssemblies;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValue;
    }
}
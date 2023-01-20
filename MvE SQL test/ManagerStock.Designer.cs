
namespace MvE_SQL_test
{
    partial class ManagerStock
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
            this.btnLoadStock = new System.Windows.Forms.Button();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadStock
            // 
            this.btnLoadStock.Location = new System.Drawing.Point(12, 38);
            this.btnLoadStock.Name = "btnLoadStock";
            this.btnLoadStock.Size = new System.Drawing.Size(133, 23);
            this.btnLoadStock.TabIndex = 5;
            this.btnLoadStock.Text = "Load stock";
            this.btnLoadStock.UseVisualStyleBackColor = true;
            // 
            // dgvProject
            // 
            this.dgvProject.AllowUserToAddRows = false;
            this.dgvProject.AllowUserToDeleteRows = false;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Location = new System.Drawing.Point(165, 38);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProject.Size = new System.Drawing.Size(1028, 191);
            this.dgvProject.TabIndex = 6;
            // 
            // ManagerStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 793);
            this.Controls.Add(this.dgvProject);
            this.Controls.Add(this.btnLoadStock);
            this.Name = "ManagerStock";
            this.Text = "Stock manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadStock;
        private System.Windows.Forms.DataGridView dgvProject;
    }
}
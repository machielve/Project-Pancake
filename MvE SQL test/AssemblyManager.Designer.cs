
namespace MvE_SQL_test
{
    partial class AssemblyManager
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
            this.dgvAssemblies = new System.Windows.Forms.DataGridView();
            this.btnLoadAssemblies = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinnish = new System.Windows.Forms.Button();
            this.btnSeeDetails = new System.Windows.Forms.Button();
            this.btnNewAssembly = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssemblies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAssemblies
            // 
            this.dgvAssemblies.AllowUserToAddRows = false;
            this.dgvAssemblies.AllowUserToDeleteRows = false;
            this.dgvAssemblies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssemblies.Location = new System.Drawing.Point(165, 38);
            this.dgvAssemblies.Name = "dgvAssemblies";
            this.dgvAssemblies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAssemblies.Size = new System.Drawing.Size(691, 608);
            this.dgvAssemblies.TabIndex = 0;
            // 
            // btnLoadAssemblies
            // 
            this.btnLoadAssemblies.Location = new System.Drawing.Point(13, 39);
            this.btnLoadAssemblies.Name = "btnLoadAssemblies";
            this.btnLoadAssemblies.Size = new System.Drawing.Size(133, 23);
            this.btnLoadAssemblies.TabIndex = 5;
            this.btnLoadAssemblies.Text = "Load assemblies";
            this.btnLoadAssemblies.UseVisualStyleBackColor = true;
            this.btnLoadAssemblies.Click += new System.EventHandler(this.btnLoadAssemblies_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assemblies";
            // 
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(13, 623);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(133, 23);
            this.btnFinnish.TabIndex = 7;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // btnSeeDetails
            // 
            this.btnSeeDetails.Location = new System.Drawing.Point(12, 68);
            this.btnSeeDetails.Name = "btnSeeDetails";
            this.btnSeeDetails.Size = new System.Drawing.Size(133, 23);
            this.btnSeeDetails.TabIndex = 8;
            this.btnSeeDetails.Text = "See details";
            this.btnSeeDetails.UseVisualStyleBackColor = true;
            // 
            // btnNewAssembly
            // 
            this.btnNewAssembly.Location = new System.Drawing.Point(13, 97);
            this.btnNewAssembly.Name = "btnNewAssembly";
            this.btnNewAssembly.Size = new System.Drawing.Size(133, 23);
            this.btnNewAssembly.TabIndex = 9;
            this.btnNewAssembly.Text = "New assembly";
            this.btnNewAssembly.UseVisualStyleBackColor = true;
            // 
            // AssemblyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 703);
            this.Controls.Add(this.btnNewAssembly);
            this.Controls.Add(this.btnSeeDetails);
            this.Controls.Add(this.btnFinnish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadAssemblies);
            this.Controls.Add(this.dgvAssemblies);
            this.Name = "AssemblyManager";
            this.Text = "Assembly manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssemblies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAssemblies;
        private System.Windows.Forms.Button btnLoadAssemblies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.Button btnSeeDetails;
        private System.Windows.Forms.Button btnNewAssembly;
    }
}

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
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnFinnish = new System.Windows.Forms.Button();
            this.btnSeeDetails = new System.Windows.Forms.Button();
            this.btnLoadProjects = new System.Windows.Forms.Button();
            this.dgvProjectDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProject
            // 
            this.dgvProject.AllowUserToAddRows = false;
            this.dgvProject.AllowUserToDeleteRows = false;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Location = new System.Drawing.Point(165, 38);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProject.Size = new System.Drawing.Size(691, 191);
            this.dgvProject.TabIndex = 0;
            // 
            // btnNewProject
            // 
            this.btnNewProject.Location = new System.Drawing.Point(13, 97);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(133, 23);
            this.btnNewProject.TabIndex = 1;
            this.btnNewProject.Text = "New Project";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(13, 623);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(133, 23);
            this.btnFinnish.TabIndex = 2;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // btnSeeDetails
            // 
            this.btnSeeDetails.Location = new System.Drawing.Point(13, 68);
            this.btnSeeDetails.Name = "btnSeeDetails";
            this.btnSeeDetails.Size = new System.Drawing.Size(133, 23);
            this.btnSeeDetails.TabIndex = 3;
            this.btnSeeDetails.Text = "See details";
            this.btnSeeDetails.UseVisualStyleBackColor = true;
            this.btnSeeDetails.Click += new System.EventHandler(this.btnSeeDetails_Click);
            // 
            // btnLoadProjects
            // 
            this.btnLoadProjects.Location = new System.Drawing.Point(13, 39);
            this.btnLoadProjects.Name = "btnLoadProjects";
            this.btnLoadProjects.Size = new System.Drawing.Size(133, 23);
            this.btnLoadProjects.TabIndex = 4;
            this.btnLoadProjects.Text = "Load projects";
            this.btnLoadProjects.UseVisualStyleBackColor = true;
            this.btnLoadProjects.Click += new System.EventHandler(this.btnLoadProjects_Click);
            // 
            // dgvProjectDetails
            // 
            this.dgvProjectDetails.AllowUserToAddRows = false;
            this.dgvProjectDetails.AllowUserToDeleteRows = false;
            this.dgvProjectDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectDetails.Location = new System.Drawing.Point(165, 299);
            this.dgvProjectDetails.Name = "dgvProjectDetails";
            this.dgvProjectDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProjectDetails.Size = new System.Drawing.Size(691, 190);
            this.dgvProjectDetails.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Projects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Project details";
            // 
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProjectDetails);
            this.Controls.Add(this.btnLoadProjects);
            this.Controls.Add(this.btnSeeDetails);
            this.Controls.Add(this.btnFinnish);
            this.Controls.Add(this.btnNewProject);
            this.Controls.Add(this.dgvProject);
            this.Name = "ProjectManager";
            this.Text = "Project manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProject;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.Button btnSeeDetails;
        private System.Windows.Forms.Button btnLoadProjects;
        private System.Windows.Forms.DataGridView dgvProjectDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
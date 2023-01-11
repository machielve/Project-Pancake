
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProjectParts = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProjectOps = new System.Windows.Forms.DataGridView();
            this.txtSeeContent = new System.Windows.Forms.Button();
            this.txtAddPart = new System.Windows.Forms.Button();
            this.txtAddOperation = new System.Windows.Forms.Button();
            this.txtDetailID = new System.Windows.Forms.TextBox();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectOps)).BeginInit();
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
            this.dgvProject.Size = new System.Drawing.Size(1028, 191);
            this.dgvProject.TabIndex = 0;
            // 
            // btnNewProject
            // 
            this.btnNewProject.Location = new System.Drawing.Point(12, 206);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(133, 23);
            this.btnNewProject.TabIndex = 1;
            this.btnNewProject.Text = "New Project";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(12, 758);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(133, 23);
            this.btnFinnish.TabIndex = 2;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // btnSeeDetails
            // 
            this.btnSeeDetails.Location = new System.Drawing.Point(12, 67);
            this.btnSeeDetails.Name = "btnSeeDetails";
            this.btnSeeDetails.Size = new System.Drawing.Size(133, 23);
            this.btnSeeDetails.TabIndex = 3;
            this.btnSeeDetails.Text = "See project details";
            this.btnSeeDetails.UseVisualStyleBackColor = true;
            this.btnSeeDetails.Click += new System.EventHandler(this.btnSeeDetails_Click);
            // 
            // btnLoadProjects
            // 
            this.btnLoadProjects.Location = new System.Drawing.Point(12, 38);
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
            this.dgvProjectDetails.Location = new System.Drawing.Point(165, 292);
            this.dgvProjectDetails.Name = "dgvProjectDetails";
            this.dgvProjectDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProjectDetails.Size = new System.Drawing.Size(1028, 114);
            this.dgvProjectDetails.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Projects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Project details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Project detail parts";
            // 
            // dgvProjectParts
            // 
            this.dgvProjectParts.AllowUserToAddRows = false;
            this.dgvProjectParts.AllowUserToDeleteRows = false;
            this.dgvProjectParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectParts.Location = new System.Drawing.Point(165, 466);
            this.dgvProjectParts.Name = "dgvProjectParts";
            this.dgvProjectParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProjectParts.Size = new System.Drawing.Size(1028, 114);
            this.dgvProjectParts.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 592);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Project detail opeaions";
            // 
            // dgvProjectOps
            // 
            this.dgvProjectOps.AllowUserToAddRows = false;
            this.dgvProjectOps.AllowUserToDeleteRows = false;
            this.dgvProjectOps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectOps.Location = new System.Drawing.Point(165, 608);
            this.dgvProjectOps.Name = "dgvProjectOps";
            this.dgvProjectOps.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProjectOps.Size = new System.Drawing.Size(1028, 114);
            this.dgvProjectOps.TabIndex = 10;
            // 
            // txtSeeContent
            // 
            this.txtSeeContent.Location = new System.Drawing.Point(12, 292);
            this.txtSeeContent.Name = "txtSeeContent";
            this.txtSeeContent.Size = new System.Drawing.Size(133, 23);
            this.txtSeeContent.TabIndex = 12;
            this.txtSeeContent.Text = "See detail content";
            this.txtSeeContent.UseVisualStyleBackColor = true;
            this.txtSeeContent.Click += new System.EventHandler(this.txtSeeContent_Click);
            // 
            // txtAddPart
            // 
            this.txtAddPart.Location = new System.Drawing.Point(12, 466);
            this.txtAddPart.Name = "txtAddPart";
            this.txtAddPart.Size = new System.Drawing.Size(133, 23);
            this.txtAddPart.TabIndex = 13;
            this.txtAddPart.Text = "Add part";
            this.txtAddPart.UseVisualStyleBackColor = true;
            this.txtAddPart.Click += new System.EventHandler(this.txtAddPart_Click);
            // 
            // txtAddOperation
            // 
            this.txtAddOperation.Location = new System.Drawing.Point(12, 608);
            this.txtAddOperation.Name = "txtAddOperation";
            this.txtAddOperation.Size = new System.Drawing.Size(133, 23);
            this.txtAddOperation.TabIndex = 14;
            this.txtAddOperation.Text = "Add operation";
            this.txtAddOperation.UseVisualStyleBackColor = true;
            // 
            // txtDetailID
            // 
            this.txtDetailID.Location = new System.Drawing.Point(244, 266);
            this.txtDetailID.Name = "txtDetailID";
            this.txtDetailID.ReadOnly = true;
            this.txtDetailID.Size = new System.Drawing.Size(100, 20);
            this.txtDetailID.TabIndex = 15;
            // 
            // txtProjectID
            // 
            this.txtProjectID.Location = new System.Drawing.Point(244, 12);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.ReadOnly = true;
            this.txtProjectID.Size = new System.Drawing.Size(100, 20);
            this.txtProjectID.TabIndex = 16;
            // 
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 793);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.txtDetailID);
            this.Controls.Add(this.txtAddOperation);
            this.Controls.Add(this.txtAddPart);
            this.Controls.Add(this.txtSeeContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvProjectOps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvProjectParts);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectOps)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProjectParts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProjectOps;
        private System.Windows.Forms.Button txtSeeContent;
        private System.Windows.Forms.Button txtAddPart;
        private System.Windows.Forms.Button txtAddOperation;
        private System.Windows.Forms.TextBox txtDetailID;
        private System.Windows.Forms.TextBox txtProjectID;
    }
}
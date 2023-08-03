
namespace MvE_SQL_test
{
    partial class ManagerProject
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
            this.DgvProject = new System.Windows.Forms.DataGridView();
            this.BtnNewProject = new System.Windows.Forms.Button();
            this.BtnFinnish = new System.Windows.Forms.Button();
            this.BtnSeeDetails = new System.Windows.Forms.Button();
            this.BtnLoadProjects = new System.Windows.Forms.Button();
            this.DgvJobOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvJobOrderParts = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvJobOrderOperations = new System.Windows.Forms.DataGridView();
            this.BtnSeeContent = new System.Windows.Forms.Button();
            this.BtnAddPart = new System.Windows.Forms.Button();
            this.BtnAddOperation = new System.Windows.Forms.Button();
            this.txtDetailID = new System.Windows.Forms.TextBox();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.BtnCreateJobOrder = new System.Windows.Forms.Button();
            this.DgvProjectAssemblies = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAddAssembly = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJobOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJobOrderParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJobOrderOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectAssemblies)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProject
            // 
            this.DgvProject.AllowUserToAddRows = false;
            this.DgvProject.AllowUserToDeleteRows = false;
            this.DgvProject.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProject.Location = new System.Drawing.Point(165, 38);
            this.DgvProject.Name = "DgvProject";
            this.DgvProject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvProject.Size = new System.Drawing.Size(1028, 200);
            this.DgvProject.TabIndex = 0;
            // 
            // BtnNewProject
            // 
            this.BtnNewProject.Location = new System.Drawing.Point(12, 215);
            this.BtnNewProject.Name = "BtnNewProject";
            this.BtnNewProject.Size = new System.Drawing.Size(133, 23);
            this.BtnNewProject.TabIndex = 1;
            this.BtnNewProject.Text = "New Project";
            this.BtnNewProject.UseVisualStyleBackColor = true;
            this.BtnNewProject.Click += new System.EventHandler(this.BtnNewProject_Click);
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(12, 829);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(133, 23);
            this.BtnFinnish.TabIndex = 2;
            this.BtnFinnish.Text = "Finnish";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // BtnSeeDetails
            // 
            this.BtnSeeDetails.Location = new System.Drawing.Point(12, 96);
            this.BtnSeeDetails.Name = "BtnSeeDetails";
            this.BtnSeeDetails.Size = new System.Drawing.Size(133, 23);
            this.BtnSeeDetails.TabIndex = 3;
            this.BtnSeeDetails.Text = "See project details";
            this.BtnSeeDetails.UseVisualStyleBackColor = true;
            this.BtnSeeDetails.Click += new System.EventHandler(this.BtnSeeDetails_Click);
            // 
            // BtnLoadProjects
            // 
            this.BtnLoadProjects.Location = new System.Drawing.Point(12, 38);
            this.BtnLoadProjects.Name = "BtnLoadProjects";
            this.BtnLoadProjects.Size = new System.Drawing.Size(133, 23);
            this.BtnLoadProjects.TabIndex = 4;
            this.BtnLoadProjects.Text = "Load projects";
            this.BtnLoadProjects.UseVisualStyleBackColor = true;
            this.BtnLoadProjects.Click += new System.EventHandler(this.BtnLoadProjects_Click);
            // 
            // DgvJobOrders
            // 
            this.DgvJobOrders.AllowUserToAddRows = false;
            this.DgvJobOrders.AllowUserToDeleteRows = false;
            this.DgvJobOrders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvJobOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJobOrders.Location = new System.Drawing.Point(165, 547);
            this.DgvJobOrders.Name = "DgvJobOrders";
            this.DgvJobOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvJobOrders.Size = new System.Drawing.Size(1028, 100);
            this.DgvJobOrders.TabIndex = 5;
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
            this.label2.Location = new System.Drawing.Point(165, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Job orders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 650);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Job order parts";
            // 
            // DgvJobOrderParts
            // 
            this.DgvJobOrderParts.AllowUserToAddRows = false;
            this.DgvJobOrderParts.AllowUserToDeleteRows = false;
            this.DgvJobOrderParts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvJobOrderParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJobOrderParts.Location = new System.Drawing.Point(165, 666);
            this.DgvJobOrderParts.Name = "DgvJobOrderParts";
            this.DgvJobOrderParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvJobOrderParts.Size = new System.Drawing.Size(1028, 70);
            this.DgvJobOrderParts.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 739);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Job order operations";
            // 
            // DgvJobOrderOperations
            // 
            this.DgvJobOrderOperations.AllowUserToAddRows = false;
            this.DgvJobOrderOperations.AllowUserToDeleteRows = false;
            this.DgvJobOrderOperations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvJobOrderOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJobOrderOperations.Location = new System.Drawing.Point(165, 755);
            this.DgvJobOrderOperations.Name = "DgvJobOrderOperations";
            this.DgvJobOrderOperations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvJobOrderOperations.Size = new System.Drawing.Size(1028, 70);
            this.DgvJobOrderOperations.TabIndex = 10;
            // 
            // BtnSeeContent
            // 
            this.BtnSeeContent.Location = new System.Drawing.Point(12, 547);
            this.BtnSeeContent.Name = "BtnSeeContent";
            this.BtnSeeContent.Size = new System.Drawing.Size(133, 23);
            this.BtnSeeContent.TabIndex = 12;
            this.BtnSeeContent.Text = "See job order content";
            this.BtnSeeContent.UseVisualStyleBackColor = true;
            this.BtnSeeContent.Click += new System.EventHandler(this.BtnSeeContent_Click);
            // 
            // BtnAddPart
            // 
            this.BtnAddPart.Location = new System.Drawing.Point(12, 666);
            this.BtnAddPart.Name = "BtnAddPart";
            this.BtnAddPart.Size = new System.Drawing.Size(133, 23);
            this.BtnAddPart.TabIndex = 13;
            this.BtnAddPart.Text = "Add part";
            this.BtnAddPart.UseVisualStyleBackColor = true;
            this.BtnAddPart.Click += new System.EventHandler(this.BtnAddPart_Click);
            // 
            // BtnAddOperation
            // 
            this.BtnAddOperation.Location = new System.Drawing.Point(12, 755);
            this.BtnAddOperation.Name = "BtnAddOperation";
            this.BtnAddOperation.Size = new System.Drawing.Size(133, 23);
            this.BtnAddOperation.TabIndex = 14;
            this.BtnAddOperation.Text = "Add operation";
            this.BtnAddOperation.UseVisualStyleBackColor = true;
            this.BtnAddOperation.Click += new System.EventHandler(this.BtnAddOperation_Click);
            // 
            // txtDetailID
            // 
            this.txtDetailID.Location = new System.Drawing.Point(265, 521);
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
            // BtnCreateJobOrder
            // 
            this.BtnCreateJobOrder.Location = new System.Drawing.Point(12, 415);
            this.BtnCreateJobOrder.Name = "BtnCreateJobOrder";
            this.BtnCreateJobOrder.Size = new System.Drawing.Size(133, 23);
            this.BtnCreateJobOrder.TabIndex = 19;
            this.BtnCreateJobOrder.Text = "Create job order";
            this.BtnCreateJobOrder.UseVisualStyleBackColor = true;
            this.BtnCreateJobOrder.Click += new System.EventHandler(this.BtnCreateJobOrder_Click);
            // 
            // DgvProjectAssemblies
            // 
            this.DgvProjectAssemblies.AllowUserToAddRows = false;
            this.DgvProjectAssemblies.AllowUserToDeleteRows = false;
            this.DgvProjectAssemblies.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvProjectAssemblies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProjectAssemblies.Location = new System.Drawing.Point(165, 415);
            this.DgvProjectAssemblies.Name = "DgvProjectAssemblies";
            this.DgvProjectAssemblies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvProjectAssemblies.Size = new System.Drawing.Size(1028, 100);
            this.DgvProjectAssemblies.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Project assemblies";
            // 
            // BtnAddAssembly
            // 
            this.BtnAddAssembly.Location = new System.Drawing.Point(12, 125);
            this.BtnAddAssembly.Name = "BtnAddAssembly";
            this.BtnAddAssembly.Size = new System.Drawing.Size(133, 23);
            this.BtnAddAssembly.TabIndex = 20;
            this.BtnAddAssembly.Text = "Add assembly";
            this.BtnAddAssembly.UseVisualStyleBackColor = true;
            this.BtnAddAssembly.Click += new System.EventHandler(this.BtnAddAssembly_Click);
            // 
            // ManagerProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 864);
            this.Controls.Add(this.BtnAddAssembly);
            this.Controls.Add(this.BtnCreateJobOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DgvProjectAssemblies);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.txtDetailID);
            this.Controls.Add(this.BtnAddOperation);
            this.Controls.Add(this.BtnAddPart);
            this.Controls.Add(this.BtnSeeContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DgvJobOrderOperations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvJobOrderParts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvJobOrders);
            this.Controls.Add(this.BtnLoadProjects);
            this.Controls.Add(this.BtnSeeDetails);
            this.Controls.Add(this.BtnFinnish);
            this.Controls.Add(this.BtnNewProject);
            this.Controls.Add(this.DgvProject);
            this.Name = "ManagerProject";
            this.Text = "Project manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgvProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJobOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJobOrderParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJobOrderOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectAssemblies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProject;
        private System.Windows.Forms.Button BtnNewProject;
        private System.Windows.Forms.Button BtnFinnish;
        private System.Windows.Forms.Button BtnSeeDetails;
        private System.Windows.Forms.Button BtnLoadProjects;
        private System.Windows.Forms.DataGridView DgvJobOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvJobOrderParts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvJobOrderOperations;
        private System.Windows.Forms.Button BtnSeeContent;
        private System.Windows.Forms.Button BtnAddPart;
        private System.Windows.Forms.Button BtnAddOperation;
        private System.Windows.Forms.TextBox txtDetailID;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.Button BtnCreateJobOrder;
        private System.Windows.Forms.DataGridView DgvProjectAssemblies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAddAssembly;
    }
}
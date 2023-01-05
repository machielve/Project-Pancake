
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
            this.dgvAssemblyParts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAssemblyOps = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAssemblyLock = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnAddOperation = new System.Windows.Forms.Button();
            this.btnCreatePart = new System.Windows.Forms.Button();
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.btnRemoveOperation = new System.Windows.Forms.Button();
            this.btnAssemblyUnlock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssemblies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssemblyParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssemblyOps)).BeginInit();
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
            this.dgvAssemblies.Size = new System.Drawing.Size(800, 191);
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
            this.btnSeeDetails.Location = new System.Drawing.Point(13, 97);
            this.btnSeeDetails.Name = "btnSeeDetails";
            this.btnSeeDetails.Size = new System.Drawing.Size(133, 23);
            this.btnSeeDetails.TabIndex = 8;
            this.btnSeeDetails.Text = "See details";
            this.btnSeeDetails.UseVisualStyleBackColor = true;
            this.btnSeeDetails.Click += new System.EventHandler(this.btnSeeDetails_Click);
            // 
            // btnNewAssembly
            // 
            this.btnNewAssembly.Location = new System.Drawing.Point(13, 68);
            this.btnNewAssembly.Name = "btnNewAssembly";
            this.btnNewAssembly.Size = new System.Drawing.Size(133, 23);
            this.btnNewAssembly.TabIndex = 9;
            this.btnNewAssembly.Text = "New assembly";
            this.btnNewAssembly.UseVisualStyleBackColor = true;
            this.btnNewAssembly.Click += new System.EventHandler(this.btnNewAssembly_Click);
            // 
            // dgvAssemblyParts
            // 
            this.dgvAssemblyParts.AllowUserToAddRows = false;
            this.dgvAssemblyParts.AllowUserToDeleteRows = false;
            this.dgvAssemblyParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssemblyParts.Location = new System.Drawing.Point(165, 299);
            this.dgvAssemblyParts.Name = "dgvAssemblyParts";
            this.dgvAssemblyParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAssemblyParts.Size = new System.Drawing.Size(800, 190);
            this.dgvAssemblyParts.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Assembly parts";
            // 
            // dgvAssemblyOps
            // 
            this.dgvAssemblyOps.AllowUserToAddRows = false;
            this.dgvAssemblyOps.AllowUserToDeleteRows = false;
            this.dgvAssemblyOps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssemblyOps.Location = new System.Drawing.Point(165, 536);
            this.dgvAssemblyOps.Name = "dgvAssemblyOps";
            this.dgvAssemblyOps.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAssemblyOps.Size = new System.Drawing.Size(800, 110);
            this.dgvAssemblyOps.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Assembly operations";
            // 
            // btnAssemblyLock
            // 
            this.btnAssemblyLock.Location = new System.Drawing.Point(13, 126);
            this.btnAssemblyLock.Name = "btnAssemblyLock";
            this.btnAssemblyLock.Size = new System.Drawing.Size(133, 23);
            this.btnAssemblyLock.TabIndex = 14;
            this.btnAssemblyLock.Text = "Lock assembly";
            this.btnAssemblyLock.UseVisualStyleBackColor = true;
            this.btnAssemblyLock.Click += new System.EventHandler(this.btnAssemblyLock_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(13, 299);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(133, 23);
            this.btnAddPart.TabIndex = 15;
            this.btnAddPart.Text = "Add part";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.Location = new System.Drawing.Point(13, 536);
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Size = new System.Drawing.Size(133, 23);
            this.btnAddOperation.TabIndex = 16;
            this.btnAddOperation.Text = "Add operation";
            this.btnAddOperation.UseVisualStyleBackColor = true;
            this.btnAddOperation.Click += new System.EventHandler(this.btnAddOperation_Click);
            // 
            // btnCreatePart
            // 
            this.btnCreatePart.Location = new System.Drawing.Point(13, 184);
            this.btnCreatePart.Name = "btnCreatePart";
            this.btnCreatePart.Size = new System.Drawing.Size(133, 23);
            this.btnCreatePart.TabIndex = 17;
            this.btnCreatePart.Text = "Create part";
            this.btnCreatePart.UseVisualStyleBackColor = true;
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.Location = new System.Drawing.Point(13, 328);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(133, 23);
            this.btnRemovePart.TabIndex = 18;
            this.btnRemovePart.Text = "Remove part";
            this.btnRemovePart.UseVisualStyleBackColor = true;
            this.btnRemovePart.Click += new System.EventHandler(this.btnRemovePart_Click);
            // 
            // btnRemoveOperation
            // 
            this.btnRemoveOperation.Location = new System.Drawing.Point(13, 565);
            this.btnRemoveOperation.Name = "btnRemoveOperation";
            this.btnRemoveOperation.Size = new System.Drawing.Size(133, 23);
            this.btnRemoveOperation.TabIndex = 19;
            this.btnRemoveOperation.Text = "Remove operation";
            this.btnRemoveOperation.UseVisualStyleBackColor = true;
            this.btnRemoveOperation.Click += new System.EventHandler(this.btnRemoveOperation_Click);
            // 
            // btnAssemblyUnlock
            // 
            this.btnAssemblyUnlock.Location = new System.Drawing.Point(13, 155);
            this.btnAssemblyUnlock.Name = "btnAssemblyUnlock";
            this.btnAssemblyUnlock.Size = new System.Drawing.Size(133, 23);
            this.btnAssemblyUnlock.TabIndex = 20;
            this.btnAssemblyUnlock.Text = "Unlock assembly";
            this.btnAssemblyUnlock.UseVisualStyleBackColor = true;
            this.btnAssemblyUnlock.Click += new System.EventHandler(this.btnAssemblyUnlock_Click);
            // 
            // AssemblyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 703);
            this.Controls.Add(this.btnAssemblyUnlock);
            this.Controls.Add(this.btnRemoveOperation);
            this.Controls.Add(this.btnRemovePart);
            this.Controls.Add(this.btnCreatePart);
            this.Controls.Add(this.btnAddOperation);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.btnAssemblyLock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAssemblyOps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAssemblyParts);
            this.Controls.Add(this.btnNewAssembly);
            this.Controls.Add(this.btnSeeDetails);
            this.Controls.Add(this.btnFinnish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadAssemblies);
            this.Controls.Add(this.dgvAssemblies);
            this.Name = "AssemblyManager";
            this.Text = " Assembly manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssemblies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssemblyParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssemblyOps)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvAssemblyParts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAssemblyOps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAssemblyLock;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnAddOperation;
        private System.Windows.Forms.Button btnCreatePart;
        private System.Windows.Forms.Button btnRemovePart;
        private System.Windows.Forms.Button btnRemoveOperation;
        private System.Windows.Forms.Button btnAssemblyUnlock;
    }
}

namespace MvE_SQL_test
{
    partial class ManagerAssembly
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
            this.txtAssemblyID = new System.Windows.Forms.TextBox();
            this.btnUpdateAssembly = new System.Windows.Forms.Button();
            this.btnLinkPart = new System.Windows.Forms.Button();
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
            this.dgvAssemblies.Size = new System.Drawing.Size(1310, 271);
            this.dgvAssemblies.TabIndex = 0;
            this.dgvAssemblies.SelectionChanged += new System.EventHandler(this.dgvAssemblies_SelectionChanged);
            // 
            // btnLoadAssemblies
            // 
            this.btnLoadAssemblies.Location = new System.Drawing.Point(12, 39);
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
            this.btnFinnish.Location = new System.Drawing.Point(12, 707);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(133, 23);
            this.btnFinnish.TabIndex = 7;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // btnNewAssembly
            // 
            this.btnNewAssembly.Location = new System.Drawing.Point(12, 68);
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
            this.dgvAssemblyParts.Location = new System.Drawing.Point(165, 385);
            this.dgvAssemblyParts.Name = "dgvAssemblyParts";
            this.dgvAssemblyParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAssemblyParts.Size = new System.Drawing.Size(1310, 190);
            this.dgvAssemblyParts.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 369);
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
            this.dgvAssemblyOps.Location = new System.Drawing.Point(165, 620);
            this.dgvAssemblyOps.Name = "dgvAssemblyOps";
            this.dgvAssemblyOps.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAssemblyOps.Size = new System.Drawing.Size(1310, 110);
            this.dgvAssemblyOps.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Assembly operations";
            // 
            // btnAssemblyLock
            // 
            this.btnAssemblyLock.Location = new System.Drawing.Point(11, 199);
            this.btnAssemblyLock.Name = "btnAssemblyLock";
            this.btnAssemblyLock.Size = new System.Drawing.Size(133, 23);
            this.btnAssemblyLock.TabIndex = 14;
            this.btnAssemblyLock.Text = "Lock assembly";
            this.btnAssemblyLock.UseVisualStyleBackColor = true;
            this.btnAssemblyLock.Click += new System.EventHandler(this.btnAssemblyLock_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(12, 385);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(133, 23);
            this.btnAddPart.TabIndex = 15;
            this.btnAddPart.Text = "Add part";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.Location = new System.Drawing.Point(12, 620);
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Size = new System.Drawing.Size(133, 23);
            this.btnAddOperation.TabIndex = 16;
            this.btnAddOperation.Text = "Add operation";
            this.btnAddOperation.UseVisualStyleBackColor = true;
            this.btnAddOperation.Click += new System.EventHandler(this.btnAddOperation_Click);
            // 
            // btnCreatePart
            // 
            this.btnCreatePart.Location = new System.Drawing.Point(11, 257);
            this.btnCreatePart.Name = "btnCreatePart";
            this.btnCreatePart.Size = new System.Drawing.Size(133, 23);
            this.btnCreatePart.TabIndex = 17;
            this.btnCreatePart.Text = "Create part";
            this.btnCreatePart.UseVisualStyleBackColor = true;
            this.btnCreatePart.Click += new System.EventHandler(this.btnCreatePart_Click);
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.Location = new System.Drawing.Point(12, 414);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(133, 23);
            this.btnRemovePart.TabIndex = 18;
            this.btnRemovePart.Text = "Remove part";
            this.btnRemovePart.UseVisualStyleBackColor = true;
            this.btnRemovePart.Click += new System.EventHandler(this.btnRemovePart_Click);
            // 
            // btnRemoveOperation
            // 
            this.btnRemoveOperation.Location = new System.Drawing.Point(13, 649);
            this.btnRemoveOperation.Name = "btnRemoveOperation";
            this.btnRemoveOperation.Size = new System.Drawing.Size(133, 23);
            this.btnRemoveOperation.TabIndex = 19;
            this.btnRemoveOperation.Text = "Remove operation";
            this.btnRemoveOperation.UseVisualStyleBackColor = true;
            this.btnRemoveOperation.Click += new System.EventHandler(this.btnRemoveOperation_Click);
            // 
            // btnAssemblyUnlock
            // 
            this.btnAssemblyUnlock.Location = new System.Drawing.Point(11, 228);
            this.btnAssemblyUnlock.Name = "btnAssemblyUnlock";
            this.btnAssemblyUnlock.Size = new System.Drawing.Size(133, 23);
            this.btnAssemblyUnlock.TabIndex = 20;
            this.btnAssemblyUnlock.Text = "Unlock assembly";
            this.btnAssemblyUnlock.UseVisualStyleBackColor = true;
            this.btnAssemblyUnlock.Click += new System.EventHandler(this.btnAssemblyUnlock_Click);
            // 
            // txtAssemblyID
            // 
            this.txtAssemblyID.Location = new System.Drawing.Point(165, 346);
            this.txtAssemblyID.Name = "txtAssemblyID";
            this.txtAssemblyID.ReadOnly = true;
            this.txtAssemblyID.Size = new System.Drawing.Size(100, 20);
            this.txtAssemblyID.TabIndex = 21;
            // 
            // btnUpdateAssembly
            // 
            this.btnUpdateAssembly.Location = new System.Drawing.Point(11, 170);
            this.btnUpdateAssembly.Name = "btnUpdateAssembly";
            this.btnUpdateAssembly.Size = new System.Drawing.Size(133, 23);
            this.btnUpdateAssembly.TabIndex = 22;
            this.btnUpdateAssembly.Text = "Update assembly";
            this.btnUpdateAssembly.UseVisualStyleBackColor = true;
            this.btnUpdateAssembly.Click += new System.EventHandler(this.btnUpdateAssembly_Click);
            // 
            // btnLinkPart
            // 
            this.btnLinkPart.Location = new System.Drawing.Point(12, 286);
            this.btnLinkPart.Name = "btnLinkPart";
            this.btnLinkPart.Size = new System.Drawing.Size(133, 23);
            this.btnLinkPart.TabIndex = 23;
            this.btnLinkPart.Text = "Link Part";
            this.btnLinkPart.UseVisualStyleBackColor = true;
            this.btnLinkPart.Click += new System.EventHandler(this.btnLinkPart_Click);
            // 
            // ManagerAssembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.btnLinkPart);
            this.Controls.Add(this.btnUpdateAssembly);
            this.Controls.Add(this.txtAssemblyID);
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
            this.Controls.Add(this.btnFinnish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadAssemblies);
            this.Controls.Add(this.dgvAssemblies);
            this.Name = "ManagerAssembly";
            this.Text = " Assembly manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AssemblyManager_Load);
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
        private System.Windows.Forms.TextBox txtAssemblyID;
        private System.Windows.Forms.Button btnUpdateAssembly;
        private System.Windows.Forms.Button btnLinkPart;
    }
}

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
            this.DgvAssemblies = new System.Windows.Forms.DataGridView();
            this.BtnLoadAssemblies = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFinnish = new System.Windows.Forms.Button();
            this.BtnNewAssembly = new System.Windows.Forms.Button();
            this.DgvAssemblyParts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvAssemblyOps = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAssemblyLock = new System.Windows.Forms.Button();
            this.BtnAddPart = new System.Windows.Forms.Button();
            this.BtnAddOperation = new System.Windows.Forms.Button();
            this.BtnCreatePart = new System.Windows.Forms.Button();
            this.BtnRemovePart = new System.Windows.Forms.Button();
            this.BtnRemoveOperation = new System.Windows.Forms.Button();
            this.BtnAssemblyUnlock = new System.Windows.Forms.Button();
            this.txtAssemblyID = new System.Windows.Forms.TextBox();
            this.BtnUpdateAssembly = new System.Windows.Forms.Button();
            this.BtnLinkPart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssemblies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssemblyParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssemblyOps)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAssemblies
            // 
            this.DgvAssemblies.AllowUserToAddRows = false;
            this.DgvAssemblies.AllowUserToDeleteRows = false;
            this.DgvAssemblies.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvAssemblies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAssemblies.Location = new System.Drawing.Point(165, 38);
            this.DgvAssemblies.Name = "DgvAssemblies";
            this.DgvAssemblies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvAssemblies.Size = new System.Drawing.Size(1310, 271);
            this.DgvAssemblies.TabIndex = 0;
            this.DgvAssemblies.SelectionChanged += new System.EventHandler(this.DgvAssemblies_SelectionChanged);
            // 
            // BtnLoadAssemblies
            // 
            this.BtnLoadAssemblies.Location = new System.Drawing.Point(12, 39);
            this.BtnLoadAssemblies.Name = "BtnLoadAssemblies";
            this.BtnLoadAssemblies.Size = new System.Drawing.Size(133, 23);
            this.BtnLoadAssemblies.TabIndex = 5;
            this.BtnLoadAssemblies.Text = "Load assemblies";
            this.BtnLoadAssemblies.UseVisualStyleBackColor = true;
            this.BtnLoadAssemblies.Click += new System.EventHandler(this.BtnLoadAssemblies_Click);
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
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(12, 707);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(133, 23);
            this.BtnFinnish.TabIndex = 7;
            this.BtnFinnish.Text = "Finnish";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // BtnNewAssembly
            // 
            this.BtnNewAssembly.Location = new System.Drawing.Point(12, 68);
            this.BtnNewAssembly.Name = "BtnNewAssembly";
            this.BtnNewAssembly.Size = new System.Drawing.Size(133, 23);
            this.BtnNewAssembly.TabIndex = 9;
            this.BtnNewAssembly.Text = "New assembly";
            this.BtnNewAssembly.UseVisualStyleBackColor = true;
            this.BtnNewAssembly.Click += new System.EventHandler(this.BtnNewAssembly_Click);
            // 
            // DgvAssemblyParts
            // 
            this.DgvAssemblyParts.AllowUserToAddRows = false;
            this.DgvAssemblyParts.AllowUserToDeleteRows = false;
            this.DgvAssemblyParts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvAssemblyParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAssemblyParts.Location = new System.Drawing.Point(165, 385);
            this.DgvAssemblyParts.Name = "DgvAssemblyParts";
            this.DgvAssemblyParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvAssemblyParts.Size = new System.Drawing.Size(1310, 190);
            this.DgvAssemblyParts.TabIndex = 10;
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
            // DgvAssemblyOps
            // 
            this.DgvAssemblyOps.AllowUserToAddRows = false;
            this.DgvAssemblyOps.AllowUserToDeleteRows = false;
            this.DgvAssemblyOps.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvAssemblyOps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAssemblyOps.Location = new System.Drawing.Point(165, 620);
            this.DgvAssemblyOps.Name = "DgvAssemblyOps";
            this.DgvAssemblyOps.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvAssemblyOps.Size = new System.Drawing.Size(1310, 110);
            this.DgvAssemblyOps.TabIndex = 12;
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
            // BtnAssemblyLock
            // 
            this.BtnAssemblyLock.Location = new System.Drawing.Point(11, 199);
            this.BtnAssemblyLock.Name = "BtnAssemblyLock";
            this.BtnAssemblyLock.Size = new System.Drawing.Size(133, 23);
            this.BtnAssemblyLock.TabIndex = 14;
            this.BtnAssemblyLock.Text = "Lock assembly";
            this.BtnAssemblyLock.UseVisualStyleBackColor = true;
            this.BtnAssemblyLock.Click += new System.EventHandler(this.BtnAssemblyLock_Click);
            // 
            // BtnAddPart
            // 
            this.BtnAddPart.Location = new System.Drawing.Point(12, 385);
            this.BtnAddPart.Name = "BtnAddPart";
            this.BtnAddPart.Size = new System.Drawing.Size(133, 23);
            this.BtnAddPart.TabIndex = 15;
            this.BtnAddPart.Text = "Add part";
            this.BtnAddPart.UseVisualStyleBackColor = true;
            this.BtnAddPart.Click += new System.EventHandler(this.BtnAddPart_Click);
            // 
            // BtnAddOperation
            // 
            this.BtnAddOperation.Location = new System.Drawing.Point(12, 620);
            this.BtnAddOperation.Name = "BtnAddOperation";
            this.BtnAddOperation.Size = new System.Drawing.Size(133, 23);
            this.BtnAddOperation.TabIndex = 16;
            this.BtnAddOperation.Text = "Add operation";
            this.BtnAddOperation.UseVisualStyleBackColor = true;
            this.BtnAddOperation.Click += new System.EventHandler(this.BtnAddOperation_Click);
            // 
            // BtnCreatePart
            // 
            this.BtnCreatePart.Location = new System.Drawing.Point(11, 257);
            this.BtnCreatePart.Name = "BtnCreatePart";
            this.BtnCreatePart.Size = new System.Drawing.Size(133, 23);
            this.BtnCreatePart.TabIndex = 17;
            this.BtnCreatePart.Text = "Create part";
            this.BtnCreatePart.UseVisualStyleBackColor = true;
            this.BtnCreatePart.Click += new System.EventHandler(this.BtnCreatePart_Click);
            // 
            // BtnRemovePart
            // 
            this.BtnRemovePart.Location = new System.Drawing.Point(12, 414);
            this.BtnRemovePart.Name = "BtnRemovePart";
            this.BtnRemovePart.Size = new System.Drawing.Size(133, 23);
            this.BtnRemovePart.TabIndex = 18;
            this.BtnRemovePart.Text = "Remove part";
            this.BtnRemovePart.UseVisualStyleBackColor = true;
            this.BtnRemovePart.Click += new System.EventHandler(this.BtnRemovePart_Click);
            // 
            // BtnRemoveOperation
            // 
            this.BtnRemoveOperation.Location = new System.Drawing.Point(13, 649);
            this.BtnRemoveOperation.Name = "BtnRemoveOperation";
            this.BtnRemoveOperation.Size = new System.Drawing.Size(133, 23);
            this.BtnRemoveOperation.TabIndex = 19;
            this.BtnRemoveOperation.Text = "Remove operation";
            this.BtnRemoveOperation.UseVisualStyleBackColor = true;
            this.BtnRemoveOperation.Click += new System.EventHandler(this.BtnRemoveOperation_Click);
            // 
            // BtnAssemblyUnlock
            // 
            this.BtnAssemblyUnlock.Location = new System.Drawing.Point(11, 228);
            this.BtnAssemblyUnlock.Name = "BtnAssemblyUnlock";
            this.BtnAssemblyUnlock.Size = new System.Drawing.Size(133, 23);
            this.BtnAssemblyUnlock.TabIndex = 20;
            this.BtnAssemblyUnlock.Text = "Unlock assembly";
            this.BtnAssemblyUnlock.UseVisualStyleBackColor = true;
            this.BtnAssemblyUnlock.Click += new System.EventHandler(this.BtnAssemblyUnlock_Click);
            // 
            // txtAssemblyID
            // 
            this.txtAssemblyID.Location = new System.Drawing.Point(165, 346);
            this.txtAssemblyID.Name = "txtAssemblyID";
            this.txtAssemblyID.ReadOnly = true;
            this.txtAssemblyID.Size = new System.Drawing.Size(100, 20);
            this.txtAssemblyID.TabIndex = 21;
            // 
            // BtnUpdateAssembly
            // 
            this.BtnUpdateAssembly.Location = new System.Drawing.Point(11, 170);
            this.BtnUpdateAssembly.Name = "BtnUpdateAssembly";
            this.BtnUpdateAssembly.Size = new System.Drawing.Size(133, 23);
            this.BtnUpdateAssembly.TabIndex = 22;
            this.BtnUpdateAssembly.Text = "Update assembly";
            this.BtnUpdateAssembly.UseVisualStyleBackColor = true;
            this.BtnUpdateAssembly.Click += new System.EventHandler(this.BtnUpdateAssembly_Click);
            // 
            // BtnLinkPart
            // 
            this.BtnLinkPart.Location = new System.Drawing.Point(12, 286);
            this.BtnLinkPart.Name = "BtnLinkPart";
            this.BtnLinkPart.Size = new System.Drawing.Size(133, 23);
            this.BtnLinkPart.TabIndex = 23;
            this.BtnLinkPart.Text = "Link Part";
            this.BtnLinkPart.UseVisualStyleBackColor = true;
            this.BtnLinkPart.Click += new System.EventHandler(this.BtnLinkPart_Click);
            // 
            // ManagerAssembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.BtnLinkPart);
            this.Controls.Add(this.BtnUpdateAssembly);
            this.Controls.Add(this.txtAssemblyID);
            this.Controls.Add(this.BtnAssemblyUnlock);
            this.Controls.Add(this.BtnRemoveOperation);
            this.Controls.Add(this.BtnRemovePart);
            this.Controls.Add(this.BtnCreatePart);
            this.Controls.Add(this.BtnAddOperation);
            this.Controls.Add(this.BtnAddPart);
            this.Controls.Add(this.BtnAssemblyLock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvAssemblyOps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvAssemblyParts);
            this.Controls.Add(this.BtnNewAssembly);
            this.Controls.Add(this.BtnFinnish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLoadAssemblies);
            this.Controls.Add(this.DgvAssemblies);
            this.Name = "ManagerAssembly";
            this.Text = " Assembly manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AssemblyManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssemblies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssemblyParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssemblyOps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAssemblies;
        private System.Windows.Forms.Button BtnLoadAssemblies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFinnish;
        private System.Windows.Forms.Button BtnNewAssembly;
        private System.Windows.Forms.DataGridView DgvAssemblyParts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvAssemblyOps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAssemblyLock;
        private System.Windows.Forms.Button BtnAddPart;
        private System.Windows.Forms.Button BtnAddOperation;
        private System.Windows.Forms.Button BtnCreatePart;
        private System.Windows.Forms.Button BtnRemovePart;
        private System.Windows.Forms.Button BtnRemoveOperation;
        private System.Windows.Forms.Button BtnAssemblyUnlock;
        private System.Windows.Forms.TextBox txtAssemblyID;
        private System.Windows.Forms.Button BtnUpdateAssembly;
        private System.Windows.Forms.Button BtnLinkPart;
    }
}
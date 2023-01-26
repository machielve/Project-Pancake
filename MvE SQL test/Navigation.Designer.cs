
namespace MvE_SQL_test
{
    partial class Navigation
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.btnProjectManager = new System.Windows.Forms.Button();
            this.btnAssemblyManager = new System.Windows.Forms.Button();
            this.btnPartManager = new System.Windows.Forms.Button();
            this.btnOperationManager = new System.Windows.Forms.Button();
            this.btnStockManager = new System.Windows.Forms.Button();
            this.Managers = new System.Windows.Forms.TabControl();
            this.GeneralSettings = new System.Windows.Forms.TabPage();
            this.rdbIPAdres2 = new System.Windows.Forms.RadioButton();
            this.rdbIPAdres1 = new System.Windows.Forms.RadioButton();
            this.txtIPAdres = new System.Windows.Forms.TextBox();
            this.txtIPExtern = new System.Windows.Forms.TextBox();
            this.txtIPIntern = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLoadSuppliers = new System.Windows.Forms.Button();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.btnNewSupplier = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLoadMaterials = new System.Windows.Forms.Button();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.btnNewMaterial = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvUnits = new System.Windows.Forms.DataGridView();
            this.btnLoadUnits = new System.Windows.Forms.Button();
            this.Managers.SuspendLayout();
            this.GeneralSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "What do you want to do?";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(15, 756);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Location = new System.Drawing.Point(6, 35);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(124, 23);
            this.btnAddUnit.TabIndex = 4;
            this.btnAddUnit.Text = "New unit";
            this.btnAddUnit.UseVisualStyleBackColor = true;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // btnProjectManager
            // 
            this.btnProjectManager.Location = new System.Drawing.Point(15, 37);
            this.btnProjectManager.Name = "btnProjectManager";
            this.btnProjectManager.Size = new System.Drawing.Size(124, 23);
            this.btnProjectManager.TabIndex = 5;
            this.btnProjectManager.Text = "Project manager";
            this.btnProjectManager.UseVisualStyleBackColor = true;
            this.btnProjectManager.Click += new System.EventHandler(this.btnProjectManager_Click);
            // 
            // btnAssemblyManager
            // 
            this.btnAssemblyManager.Location = new System.Drawing.Point(15, 66);
            this.btnAssemblyManager.Name = "btnAssemblyManager";
            this.btnAssemblyManager.Size = new System.Drawing.Size(124, 23);
            this.btnAssemblyManager.TabIndex = 6;
            this.btnAssemblyManager.Text = "Assembly manager";
            this.btnAssemblyManager.UseVisualStyleBackColor = true;
            this.btnAssemblyManager.Click += new System.EventHandler(this.btnAssemblyManager_Click);
            // 
            // btnPartManager
            // 
            this.btnPartManager.Location = new System.Drawing.Point(15, 95);
            this.btnPartManager.Name = "btnPartManager";
            this.btnPartManager.Size = new System.Drawing.Size(124, 23);
            this.btnPartManager.TabIndex = 7;
            this.btnPartManager.Text = "Part manager";
            this.btnPartManager.UseVisualStyleBackColor = true;
            this.btnPartManager.Click += new System.EventHandler(this.btnPartManager_Click);
            // 
            // btnOperationManager
            // 
            this.btnOperationManager.Location = new System.Drawing.Point(15, 124);
            this.btnOperationManager.Name = "btnOperationManager";
            this.btnOperationManager.Size = new System.Drawing.Size(124, 23);
            this.btnOperationManager.TabIndex = 8;
            this.btnOperationManager.Text = "Operations manager";
            this.btnOperationManager.UseVisualStyleBackColor = true;
            this.btnOperationManager.Click += new System.EventHandler(this.btnOperationManager_Click);
            // 
            // btnStockManager
            // 
            this.btnStockManager.Location = new System.Drawing.Point(15, 153);
            this.btnStockManager.Name = "btnStockManager";
            this.btnStockManager.Size = new System.Drawing.Size(124, 23);
            this.btnStockManager.TabIndex = 9;
            this.btnStockManager.Text = "Stock manager";
            this.btnStockManager.UseVisualStyleBackColor = true;
            this.btnStockManager.Click += new System.EventHandler(this.btnStockManager_Click);
            // 
            // Managers
            // 
            this.Managers.Controls.Add(this.GeneralSettings);
            this.Managers.Controls.Add(this.tabPage1);
            this.Managers.Controls.Add(this.tabPage2);
            this.Managers.Controls.Add(this.tabPage3);
            this.Managers.Location = new System.Drawing.Point(162, 10);
            this.Managers.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.Managers.MinimumSize = new System.Drawing.Size(1181, 771);
            this.Managers.Name = "Managers";
            this.Managers.SelectedIndex = 0;
            this.Managers.Size = new System.Drawing.Size(1310, 840);
            this.Managers.TabIndex = 10;
            // 
            // GeneralSettings
            // 
            this.GeneralSettings.Controls.Add(this.rdbIPAdres2);
            this.GeneralSettings.Controls.Add(this.rdbIPAdres1);
            this.GeneralSettings.Controls.Add(this.txtIPAdres);
            this.GeneralSettings.Controls.Add(this.txtIPExtern);
            this.GeneralSettings.Controls.Add(this.txtIPIntern);
            this.GeneralSettings.Location = new System.Drawing.Point(4, 22);
            this.GeneralSettings.Name = "GeneralSettings";
            this.GeneralSettings.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralSettings.Size = new System.Drawing.Size(1302, 814);
            this.GeneralSettings.TabIndex = 3;
            this.GeneralSettings.Text = "General settings";
            this.GeneralSettings.UseVisualStyleBackColor = true;
            // 
            // rdbIPAdres2
            // 
            this.rdbIPAdres2.AutoSize = true;
            this.rdbIPAdres2.Location = new System.Drawing.Point(6, 37);
            this.rdbIPAdres2.Name = "rdbIPAdres2";
            this.rdbIPAdres2.Size = new System.Drawing.Size(119, 17);
            this.rdbIPAdres2.TabIndex = 4;
            this.rdbIPAdres2.Text = "External connection";
            this.rdbIPAdres2.UseVisualStyleBackColor = true;
            // 
            // rdbIPAdres1
            // 
            this.rdbIPAdres1.AutoSize = true;
            this.rdbIPAdres1.Location = new System.Drawing.Point(6, 8);
            this.rdbIPAdres1.Name = "rdbIPAdres1";
            this.rdbIPAdres1.Size = new System.Drawing.Size(116, 17);
            this.rdbIPAdres1.TabIndex = 3;
            this.rdbIPAdres1.Text = "Internal connection";
            this.rdbIPAdres1.UseVisualStyleBackColor = true;
            // 
            // txtIPAdres
            // 
            this.txtIPAdres.Location = new System.Drawing.Point(145, 123);
            this.txtIPAdres.Name = "txtIPAdres";
            this.txtIPAdres.ReadOnly = true;
            this.txtIPAdres.Size = new System.Drawing.Size(108, 20);
            this.txtIPAdres.TabIndex = 2;
            // 
            // txtIPExtern
            // 
            this.txtIPExtern.Location = new System.Drawing.Point(145, 36);
            this.txtIPExtern.Name = "txtIPExtern";
            this.txtIPExtern.Size = new System.Drawing.Size(109, 20);
            this.txtIPExtern.TabIndex = 1;
            this.txtIPExtern.Text = "84.87.205.42";
            // 
            // txtIPIntern
            // 
            this.txtIPIntern.Location = new System.Drawing.Point(145, 7);
            this.txtIPIntern.Name = "txtIPIntern";
            this.txtIPIntern.Size = new System.Drawing.Size(109, 20);
            this.txtIPIntern.TabIndex = 0;
            this.txtIPIntern.Text = "192.168.2.61";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLoadSuppliers);
            this.tabPage1.Controls.Add(this.dgvSuppliers);
            this.tabPage1.Controls.Add(this.btnNewSupplier);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1302, 814);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Suppliers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLoadSuppliers
            // 
            this.btnLoadSuppliers.Location = new System.Drawing.Point(6, 5);
            this.btnLoadSuppliers.Name = "btnLoadSuppliers";
            this.btnLoadSuppliers.Size = new System.Drawing.Size(124, 23);
            this.btnLoadSuppliers.TabIndex = 14;
            this.btnLoadSuppliers.Text = "Load suppliers";
            this.btnLoadSuppliers.UseVisualStyleBackColor = true;
            this.btnLoadSuppliers.Click += new System.EventHandler(this.btnLoadSuppliers_Click);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToOrderColumns = true;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new System.Drawing.Point(137, 7);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.Size = new System.Drawing.Size(1144, 696);
            this.dgvSuppliers.TabIndex = 13;
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.Location = new System.Drawing.Point(6, 34);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Size = new System.Drawing.Size(124, 23);
            this.btnNewSupplier.TabIndex = 12;
            this.btnNewSupplier.Text = "New supplier";
            this.btnNewSupplier.UseVisualStyleBackColor = true;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLoadMaterials);
            this.tabPage2.Controls.Add(this.dgvMaterials);
            this.tabPage2.Controls.Add(this.btnNewMaterial);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1302, 814);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Materials";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoadMaterials
            // 
            this.btnLoadMaterials.Location = new System.Drawing.Point(6, 6);
            this.btnLoadMaterials.Name = "btnLoadMaterials";
            this.btnLoadMaterials.Size = new System.Drawing.Size(124, 23);
            this.btnLoadMaterials.TabIndex = 13;
            this.btnLoadMaterials.Text = "Load materials";
            this.btnLoadMaterials.UseVisualStyleBackColor = true;
            this.btnLoadMaterials.Click += new System.EventHandler(this.btnLoadMaterials_Click);
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.AllowUserToAddRows = false;
            this.dgvMaterials.AllowUserToDeleteRows = false;
            this.dgvMaterials.AllowUserToOrderColumns = true;
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterials.Location = new System.Drawing.Point(136, 6);
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.Size = new System.Drawing.Size(1144, 696);
            this.dgvMaterials.TabIndex = 12;
            // 
            // btnNewMaterial
            // 
            this.btnNewMaterial.Location = new System.Drawing.Point(6, 35);
            this.btnNewMaterial.Name = "btnNewMaterial";
            this.btnNewMaterial.Size = new System.Drawing.Size(124, 23);
            this.btnNewMaterial.TabIndex = 11;
            this.btnNewMaterial.Text = "New material";
            this.btnNewMaterial.UseVisualStyleBackColor = true;
            this.btnNewMaterial.Click += new System.EventHandler(this.btnNewMaterial_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvUnits);
            this.tabPage3.Controls.Add(this.btnLoadUnits);
            this.tabPage3.Controls.Add(this.btnAddUnit);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1302, 814);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Units";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvUnits
            // 
            this.dgvUnits.AllowUserToAddRows = false;
            this.dgvUnits.AllowUserToDeleteRows = false;
            this.dgvUnits.AllowUserToOrderColumns = true;
            this.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnits.Location = new System.Drawing.Point(136, 6);
            this.dgvUnits.Name = "dgvUnits";
            this.dgvUnits.Size = new System.Drawing.Size(1144, 696);
            this.dgvUnits.TabIndex = 13;
            // 
            // btnLoadUnits
            // 
            this.btnLoadUnits.Location = new System.Drawing.Point(6, 6);
            this.btnLoadUnits.Name = "btnLoadUnits";
            this.btnLoadUnits.Size = new System.Drawing.Size(124, 23);
            this.btnLoadUnits.TabIndex = 5;
            this.btnLoadUnits.Text = "Load units";
            this.btnLoadUnits.UseVisualStyleBackColor = true;
            this.btnLoadUnits.Click += new System.EventHandler(this.btnLoadUnits_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.Managers);
            this.Controls.Add(this.btnStockManager);
            this.Controls.Add(this.btnOperationManager);
            this.Controls.Add(this.btnPartManager);
            this.Controls.Add(this.btnAssemblyManager);
            this.Controls.Add(this.btnProjectManager);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "Navigation";
            this.Text = "Welcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Navigation_Load);
            this.Managers.ResumeLayout(false);
            this.GeneralSettings.ResumeLayout(false);
            this.GeneralSettings.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.Button btnProjectManager;
        private System.Windows.Forms.Button btnAssemblyManager;
        private System.Windows.Forms.Button btnPartManager;
        private System.Windows.Forms.Button btnOperationManager;
        private System.Windows.Forms.Button btnStockManager;
        private System.Windows.Forms.TabControl Managers;
        private System.Windows.Forms.Button btnNewMaterial;
        private System.Windows.Forms.TabPage GeneralSettings;
        private System.Windows.Forms.TextBox txtIPAdres;
        private System.Windows.Forms.TextBox txtIPExtern;
        private System.Windows.Forms.TextBox txtIPIntern;
        private System.Windows.Forms.RadioButton rdbIPAdres2;
        private System.Windows.Forms.RadioButton rdbIPAdres1;
        private System.Windows.Forms.Button btnNewSupplier;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLoadSuppliers;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLoadMaterials;
        private System.Windows.Forms.DataGridView dgvMaterials;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvUnits;
        private System.Windows.Forms.Button btnLoadUnits;
    }
}


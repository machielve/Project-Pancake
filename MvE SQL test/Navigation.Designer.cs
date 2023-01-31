
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
            this.btnStockManager = new System.Windows.Forms.Button();
            this.Managers = new System.Windows.Forms.TabControl();
            this.GeneralSettings = new System.Windows.Forms.TabPage();
            this.rdbIPAdres2 = new System.Windows.Forms.RadioButton();
            this.rdbIPAdres1 = new System.Windows.Forms.RadioButton();
            this.txtIPAdres = new System.Windows.Forms.TextBox();
            this.txtIPExtern = new System.Windows.Forms.TextBox();
            this.txtIPIntern = new System.Windows.Forms.TextBox();
            this.tabOperations = new System.Windows.Forms.TabPage();
            this.dgvOperations = new System.Windows.Forms.DataGridView();
            this.btnLoadOperations = new System.Windows.Forms.Button();
            this.btnNewOperation = new System.Windows.Forms.Button();
            this.tabMaterials = new System.Windows.Forms.TabPage();
            this.btnLoadMaterials = new System.Windows.Forms.Button();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.btnNewMaterial = new System.Windows.Forms.Button();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.btnLoadSuppliers = new System.Windows.Forms.Button();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.btnNewSupplier = new System.Windows.Forms.Button();
            this.tabUnits = new System.Windows.Forms.TabPage();
            this.dgvUnits = new System.Windows.Forms.DataGridView();
            this.btnLoadUnits = new System.Windows.Forms.Button();
            this.btnJobOrderManager = new System.Windows.Forms.Button();
            this.Managers.SuspendLayout();
            this.GeneralSettings.SuspendLayout();
            this.tabOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperations)).BeginInit();
            this.tabMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            this.tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.tabUnits.SuspendLayout();
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
            this.btnAssemblyManager.Location = new System.Drawing.Point(15, 95);
            this.btnAssemblyManager.Name = "btnAssemblyManager";
            this.btnAssemblyManager.Size = new System.Drawing.Size(124, 23);
            this.btnAssemblyManager.TabIndex = 6;
            this.btnAssemblyManager.Text = "Assembly manager";
            this.btnAssemblyManager.UseVisualStyleBackColor = true;
            this.btnAssemblyManager.Click += new System.EventHandler(this.btnAssemblyManager_Click);
            // 
            // btnPartManager
            // 
            this.btnPartManager.Location = new System.Drawing.Point(15, 124);
            this.btnPartManager.Name = "btnPartManager";
            this.btnPartManager.Size = new System.Drawing.Size(124, 23);
            this.btnPartManager.TabIndex = 7;
            this.btnPartManager.Text = "Part manager";
            this.btnPartManager.UseVisualStyleBackColor = true;
            this.btnPartManager.Click += new System.EventHandler(this.btnPartManager_Click);
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
            this.Managers.Controls.Add(this.tabOperations);
            this.Managers.Controls.Add(this.tabMaterials);
            this.Managers.Controls.Add(this.tabSuppliers);
            this.Managers.Controls.Add(this.tabUnits);
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
            // tabOperations
            // 
            this.tabOperations.Controls.Add(this.dgvOperations);
            this.tabOperations.Controls.Add(this.btnLoadOperations);
            this.tabOperations.Controls.Add(this.btnNewOperation);
            this.tabOperations.Location = new System.Drawing.Point(4, 22);
            this.tabOperations.Name = "tabOperations";
            this.tabOperations.Padding = new System.Windows.Forms.Padding(3);
            this.tabOperations.Size = new System.Drawing.Size(1302, 814);
            this.tabOperations.TabIndex = 7;
            this.tabOperations.Text = "Operations";
            this.tabOperations.UseVisualStyleBackColor = true;
            // 
            // dgvOperations
            // 
            this.dgvOperations.AllowUserToAddRows = false;
            this.dgvOperations.AllowUserToDeleteRows = false;
            this.dgvOperations.AllowUserToOrderColumns = true;
            this.dgvOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperations.Location = new System.Drawing.Point(136, 6);
            this.dgvOperations.Name = "dgvOperations";
            this.dgvOperations.Size = new System.Drawing.Size(1144, 696);
            this.dgvOperations.TabIndex = 16;
            // 
            // btnLoadOperations
            // 
            this.btnLoadOperations.Location = new System.Drawing.Point(6, 6);
            this.btnLoadOperations.Name = "btnLoadOperations";
            this.btnLoadOperations.Size = new System.Drawing.Size(124, 23);
            this.btnLoadOperations.TabIndex = 15;
            this.btnLoadOperations.Text = "Load operations";
            this.btnLoadOperations.UseVisualStyleBackColor = true;
            this.btnLoadOperations.Click += new System.EventHandler(this.btnLoadOperations_Click);
            // 
            // btnNewOperation
            // 
            this.btnNewOperation.Location = new System.Drawing.Point(6, 35);
            this.btnNewOperation.Name = "btnNewOperation";
            this.btnNewOperation.Size = new System.Drawing.Size(124, 23);
            this.btnNewOperation.TabIndex = 14;
            this.btnNewOperation.Text = "New operation";
            this.btnNewOperation.UseVisualStyleBackColor = true;
            this.btnNewOperation.Click += new System.EventHandler(this.btnNewOperation_Click);
            // 
            // tabMaterials
            // 
            this.tabMaterials.Controls.Add(this.btnLoadMaterials);
            this.tabMaterials.Controls.Add(this.dgvMaterials);
            this.tabMaterials.Controls.Add(this.btnNewMaterial);
            this.tabMaterials.Location = new System.Drawing.Point(4, 22);
            this.tabMaterials.Name = "tabMaterials";
            this.tabMaterials.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterials.Size = new System.Drawing.Size(1302, 814);
            this.tabMaterials.TabIndex = 5;
            this.tabMaterials.Text = "Materials";
            this.tabMaterials.UseVisualStyleBackColor = true;
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
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.btnLoadSuppliers);
            this.tabSuppliers.Controls.Add(this.dgvSuppliers);
            this.tabSuppliers.Controls.Add(this.btnNewSupplier);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuppliers.Size = new System.Drawing.Size(1302, 814);
            this.tabSuppliers.TabIndex = 4;
            this.tabSuppliers.Text = "Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
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
            // tabUnits
            // 
            this.tabUnits.Controls.Add(this.dgvUnits);
            this.tabUnits.Controls.Add(this.btnLoadUnits);
            this.tabUnits.Controls.Add(this.btnAddUnit);
            this.tabUnits.Location = new System.Drawing.Point(4, 22);
            this.tabUnits.Name = "tabUnits";
            this.tabUnits.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnits.Size = new System.Drawing.Size(1302, 814);
            this.tabUnits.TabIndex = 6;
            this.tabUnits.Text = "Units";
            this.tabUnits.UseVisualStyleBackColor = true;
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
            // btnJobOrderManager
            // 
            this.btnJobOrderManager.Location = new System.Drawing.Point(15, 66);
            this.btnJobOrderManager.Name = "btnJobOrderManager";
            this.btnJobOrderManager.Size = new System.Drawing.Size(124, 23);
            this.btnJobOrderManager.TabIndex = 11;
            this.btnJobOrderManager.Text = "Job order manager";
            this.btnJobOrderManager.UseVisualStyleBackColor = true;
            this.btnJobOrderManager.Click += new System.EventHandler(this.btnJobOrderManager_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.btnJobOrderManager);
            this.Controls.Add(this.Managers);
            this.Controls.Add(this.btnStockManager);
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
            this.tabOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperations)).EndInit();
            this.tabMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            this.tabSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.tabUnits.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.Button btnLoadSuppliers;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.TabPage tabMaterials;
        private System.Windows.Forms.Button btnLoadMaterials;
        private System.Windows.Forms.DataGridView dgvMaterials;
        private System.Windows.Forms.TabPage tabUnits;
        private System.Windows.Forms.DataGridView dgvUnits;
        private System.Windows.Forms.Button btnLoadUnits;
        private System.Windows.Forms.TabPage tabOperations;
        private System.Windows.Forms.DataGridView dgvOperations;
        private System.Windows.Forms.Button btnLoadOperations;
        private System.Windows.Forms.Button btnNewOperation;
        private System.Windows.Forms.Button btnJobOrderManager;
    }
}


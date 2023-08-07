
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAddUnit = new System.Windows.Forms.Button();
            this.BtnProjectManager = new System.Windows.Forms.Button();
            this.BtnAssemblyManager = new System.Windows.Forms.Button();
            this.BtnPartManager = new System.Windows.Forms.Button();
            this.BtnStockManager = new System.Windows.Forms.Button();
            this.Managers = new System.Windows.Forms.TabControl();
            this.GeneralSettings = new System.Windows.Forms.TabPage();
            this.ConnectedBox = new System.Windows.Forms.CheckBox();
            this.BtnConnectSQL = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatabse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.RdbIPAdres2 = new System.Windows.Forms.RadioButton();
            this.RdbIPAdres1 = new System.Windows.Forms.RadioButton();
            this.txtIPAdres = new System.Windows.Forms.TextBox();
            this.txtIPExtern = new System.Windows.Forms.TextBox();
            this.txtIPIntern = new System.Windows.Forms.TextBox();
            this.tabOperations = new System.Windows.Forms.TabPage();
            this.DgvOperations = new System.Windows.Forms.DataGridView();
            this.BtnLoadOperations = new System.Windows.Forms.Button();
            this.BtnNewOperation = new System.Windows.Forms.Button();
            this.tabMaterials = new System.Windows.Forms.TabPage();
            this.BtnLoadMaterials = new System.Windows.Forms.Button();
            this.DgvMaterials = new System.Windows.Forms.DataGridView();
            this.BtnNewMaterial = new System.Windows.Forms.Button();
            this.tabRelations = new System.Windows.Forms.TabPage();
            this.BtnLoadRelations = new System.Windows.Forms.Button();
            this.DgvRelations = new System.Windows.Forms.DataGridView();
            this.BtnNewRelation = new System.Windows.Forms.Button();
            this.tabUnits = new System.Windows.Forms.TabPage();
            this.DgvUnits = new System.Windows.Forms.DataGridView();
            this.BtnLoadUnits = new System.Windows.Forms.Button();
            this.BtnJobOrderManager = new System.Windows.Forms.Button();
            this.Managers.SuspendLayout();
            this.GeneralSettings.SuspendLayout();
            this.tabOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOperations)).BeginInit();
            this.tabMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaterials)).BeginInit();
            this.tabRelations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRelations)).BeginInit();
            this.tabUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUnits)).BeginInit();
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
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(15, 756);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(124, 23);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // BtnAddUnit
            // 
            this.BtnAddUnit.Location = new System.Drawing.Point(6, 35);
            this.BtnAddUnit.Name = "BtnAddUnit";
            this.BtnAddUnit.Size = new System.Drawing.Size(124, 23);
            this.BtnAddUnit.TabIndex = 4;
            this.BtnAddUnit.Text = "New unit";
            this.BtnAddUnit.UseVisualStyleBackColor = true;
            this.BtnAddUnit.Click += new System.EventHandler(this.BtnAddUnit_Click);
            // 
            // BtnProjectManager
            // 
            this.BtnProjectManager.Location = new System.Drawing.Point(15, 37);
            this.BtnProjectManager.Name = "BtnProjectManager";
            this.BtnProjectManager.Size = new System.Drawing.Size(124, 23);
            this.BtnProjectManager.TabIndex = 5;
            this.BtnProjectManager.Text = "Project manager";
            this.BtnProjectManager.UseVisualStyleBackColor = true;
            this.BtnProjectManager.Click += new System.EventHandler(this.BtnProjectManager_Click);
            // 
            // BtnAssemblyManager
            // 
            this.BtnAssemblyManager.Location = new System.Drawing.Point(15, 95);
            this.BtnAssemblyManager.Name = "BtnAssemblyManager";
            this.BtnAssemblyManager.Size = new System.Drawing.Size(124, 23);
            this.BtnAssemblyManager.TabIndex = 6;
            this.BtnAssemblyManager.Text = "Assembly manager";
            this.BtnAssemblyManager.UseVisualStyleBackColor = true;
            this.BtnAssemblyManager.Click += new System.EventHandler(this.BtnAssemblyManager_Click);
            // 
            // BtnPartManager
            // 
            this.BtnPartManager.Location = new System.Drawing.Point(15, 124);
            this.BtnPartManager.Name = "BtnPartManager";
            this.BtnPartManager.Size = new System.Drawing.Size(124, 23);
            this.BtnPartManager.TabIndex = 7;
            this.BtnPartManager.Text = "Part manager";
            this.BtnPartManager.UseVisualStyleBackColor = true;
            this.BtnPartManager.Click += new System.EventHandler(this.BtnPartManager_Click);
            // 
            // BtnStockManager
            // 
            this.BtnStockManager.Location = new System.Drawing.Point(15, 153);
            this.BtnStockManager.Name = "BtnStockManager";
            this.BtnStockManager.Size = new System.Drawing.Size(124, 23);
            this.BtnStockManager.TabIndex = 9;
            this.BtnStockManager.Text = "Stock manager";
            this.BtnStockManager.UseVisualStyleBackColor = true;
            this.BtnStockManager.Click += new System.EventHandler(this.BtnStockManager_Click);
            // 
            // Managers
            // 
            this.Managers.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Managers.Controls.Add(this.GeneralSettings);
            this.Managers.Controls.Add(this.tabOperations);
            this.Managers.Controls.Add(this.tabMaterials);
            this.Managers.Controls.Add(this.tabRelations);
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
            this.GeneralSettings.Controls.Add(this.ConnectedBox);
            this.GeneralSettings.Controls.Add(this.BtnConnectSQL);
            this.GeneralSettings.Controls.Add(this.label5);
            this.GeneralSettings.Controls.Add(this.txtDatabse);
            this.GeneralSettings.Controls.Add(this.label4);
            this.GeneralSettings.Controls.Add(this.label3);
            this.GeneralSettings.Controls.Add(this.txtPassword);
            this.GeneralSettings.Controls.Add(this.label2);
            this.GeneralSettings.Controls.Add(this.txtUserName);
            this.GeneralSettings.Controls.Add(this.RdbIPAdres2);
            this.GeneralSettings.Controls.Add(this.RdbIPAdres1);
            this.GeneralSettings.Controls.Add(this.txtIPAdres);
            this.GeneralSettings.Controls.Add(this.txtIPExtern);
            this.GeneralSettings.Controls.Add(this.txtIPIntern);
            this.GeneralSettings.Location = new System.Drawing.Point(4, 25);
            this.GeneralSettings.Name = "GeneralSettings";
            this.GeneralSettings.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralSettings.Size = new System.Drawing.Size(1302, 811);
            this.GeneralSettings.TabIndex = 3;
            this.GeneralSettings.Text = "General settings";
            this.GeneralSettings.UseVisualStyleBackColor = true;
            // 
            // ConnectedBox
            // 
            this.ConnectedBox.AutoCheck = false;
            this.ConnectedBox.AutoSize = true;
            this.ConnectedBox.Location = new System.Drawing.Point(145, 211);
            this.ConnectedBox.Name = "ConnectedBox";
            this.ConnectedBox.Size = new System.Drawing.Size(78, 17);
            this.ConnectedBox.TabIndex = 13;
            this.ConnectedBox.Text = "Connected";
            this.ConnectedBox.UseVisualStyleBackColor = true;
            // 
            // BtnConnectSQL
            // 
            this.BtnConnectSQL.Location = new System.Drawing.Point(70, 181);
            this.BtnConnectSQL.Name = "BtnConnectSQL";
            this.BtnConnectSQL.Size = new System.Drawing.Size(184, 23);
            this.BtnConnectSQL.TabIndex = 12;
            this.BtnConnectSQL.Text = "Connect";
            this.BtnConnectSQL.UseVisualStyleBackColor = true;
            this.BtnConnectSQL.Click += new System.EventHandler(this.BtnConnectSQL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Database";
            // 
            // txtDatabse
            // 
            this.txtDatabse.Location = new System.Drawing.Point(145, 94);
            this.txtDatabse.Name = "txtDatabse";
            this.txtDatabse.Size = new System.Drawing.Size(109, 20);
            this.txtDatabse.TabIndex = 10;
            this.txtDatabse.Text = "Victoriam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(145, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(109, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "Welkom#2017";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(145, 123);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(109, 20);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Text = "machiel";
            // 
            // RdbIPAdres2
            // 
            this.RdbIPAdres2.AutoSize = true;
            this.RdbIPAdres2.Location = new System.Drawing.Point(6, 37);
            this.RdbIPAdres2.Name = "RdbIPAdres2";
            this.RdbIPAdres2.Size = new System.Drawing.Size(119, 17);
            this.RdbIPAdres2.TabIndex = 4;
            this.RdbIPAdres2.Text = "External connection";
            this.RdbIPAdres2.UseVisualStyleBackColor = true;
            this.RdbIPAdres2.Click += new System.EventHandler(this.RdbIPAdres2_CheckedChanged);
            // 
            // RdbIPAdres1
            // 
            this.RdbIPAdres1.AutoSize = true;
            this.RdbIPAdres1.Location = new System.Drawing.Point(6, 8);
            this.RdbIPAdres1.Name = "RdbIPAdres1";
            this.RdbIPAdres1.Size = new System.Drawing.Size(116, 17);
            this.RdbIPAdres1.TabIndex = 3;
            this.RdbIPAdres1.Text = "Internal connection";
            this.RdbIPAdres1.UseVisualStyleBackColor = true;
            this.RdbIPAdres1.Click += new System.EventHandler(this.RdbIPAdres1_CheckedChanged);
            // 
            // txtIPAdres
            // 
            this.txtIPAdres.Location = new System.Drawing.Point(145, 65);
            this.txtIPAdres.Name = "txtIPAdres";
            this.txtIPAdres.ReadOnly = true;
            this.txtIPAdres.Size = new System.Drawing.Size(109, 20);
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
            this.tabOperations.Controls.Add(this.DgvOperations);
            this.tabOperations.Controls.Add(this.BtnLoadOperations);
            this.tabOperations.Controls.Add(this.BtnNewOperation);
            this.tabOperations.Location = new System.Drawing.Point(4, 25);
            this.tabOperations.Name = "tabOperations";
            this.tabOperations.Padding = new System.Windows.Forms.Padding(3);
            this.tabOperations.Size = new System.Drawing.Size(1302, 811);
            this.tabOperations.TabIndex = 7;
            this.tabOperations.Text = "Operations";
            this.tabOperations.UseVisualStyleBackColor = true;
            // 
            // DgvOperations
            // 
            this.DgvOperations.AllowUserToAddRows = false;
            this.DgvOperations.AllowUserToDeleteRows = false;
            this.DgvOperations.AllowUserToOrderColumns = true;
            this.DgvOperations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOperations.Location = new System.Drawing.Point(136, 6);
            this.DgvOperations.Name = "DgvOperations";
            this.DgvOperations.Size = new System.Drawing.Size(1144, 696);
            this.DgvOperations.TabIndex = 16;
            // 
            // BtnLoadOperations
            // 
            this.BtnLoadOperations.Location = new System.Drawing.Point(6, 6);
            this.BtnLoadOperations.Name = "BtnLoadOperations";
            this.BtnLoadOperations.Size = new System.Drawing.Size(124, 23);
            this.BtnLoadOperations.TabIndex = 15;
            this.BtnLoadOperations.Text = "Load operations";
            this.BtnLoadOperations.UseVisualStyleBackColor = true;
            this.BtnLoadOperations.Click += new System.EventHandler(this.BtnLoadOperations_Click);
            // 
            // BtnNewOperation
            // 
            this.BtnNewOperation.Location = new System.Drawing.Point(6, 35);
            this.BtnNewOperation.Name = "BtnNewOperation";
            this.BtnNewOperation.Size = new System.Drawing.Size(124, 23);
            this.BtnNewOperation.TabIndex = 14;
            this.BtnNewOperation.Text = "New operation";
            this.BtnNewOperation.UseVisualStyleBackColor = true;
            this.BtnNewOperation.Click += new System.EventHandler(this.BtnNewOperation_Click);
            // 
            // tabMaterials
            // 
            this.tabMaterials.Controls.Add(this.BtnLoadMaterials);
            this.tabMaterials.Controls.Add(this.DgvMaterials);
            this.tabMaterials.Controls.Add(this.BtnNewMaterial);
            this.tabMaterials.Location = new System.Drawing.Point(4, 25);
            this.tabMaterials.Name = "tabMaterials";
            this.tabMaterials.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterials.Size = new System.Drawing.Size(1302, 811);
            this.tabMaterials.TabIndex = 5;
            this.tabMaterials.Text = "Materials";
            this.tabMaterials.UseVisualStyleBackColor = true;
            // 
            // BtnLoadMaterials
            // 
            this.BtnLoadMaterials.Location = new System.Drawing.Point(6, 6);
            this.BtnLoadMaterials.Name = "BtnLoadMaterials";
            this.BtnLoadMaterials.Size = new System.Drawing.Size(124, 23);
            this.BtnLoadMaterials.TabIndex = 13;
            this.BtnLoadMaterials.Text = "Load materials";
            this.BtnLoadMaterials.UseVisualStyleBackColor = true;
            this.BtnLoadMaterials.Click += new System.EventHandler(this.BtnLoadMaterials_Click);
            // 
            // DgvMaterials
            // 
            this.DgvMaterials.AllowUserToAddRows = false;
            this.DgvMaterials.AllowUserToDeleteRows = false;
            this.DgvMaterials.AllowUserToOrderColumns = true;
            this.DgvMaterials.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMaterials.Location = new System.Drawing.Point(136, 6);
            this.DgvMaterials.Name = "DgvMaterials";
            this.DgvMaterials.Size = new System.Drawing.Size(1144, 696);
            this.DgvMaterials.TabIndex = 12;
            // 
            // BtnNewMaterial
            // 
            this.BtnNewMaterial.Location = new System.Drawing.Point(6, 35);
            this.BtnNewMaterial.Name = "BtnNewMaterial";
            this.BtnNewMaterial.Size = new System.Drawing.Size(124, 23);
            this.BtnNewMaterial.TabIndex = 11;
            this.BtnNewMaterial.Text = "New material";
            this.BtnNewMaterial.UseVisualStyleBackColor = true;
            this.BtnNewMaterial.Click += new System.EventHandler(this.BtnNewMaterial_Click);
            // 
            // tabRelations
            // 
            this.tabRelations.Controls.Add(this.BtnLoadRelations);
            this.tabRelations.Controls.Add(this.DgvRelations);
            this.tabRelations.Controls.Add(this.BtnNewRelation);
            this.tabRelations.Location = new System.Drawing.Point(4, 25);
            this.tabRelations.Name = "tabRelations";
            this.tabRelations.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelations.Size = new System.Drawing.Size(1302, 811);
            this.tabRelations.TabIndex = 4;
            this.tabRelations.Text = "Relations";
            this.tabRelations.UseVisualStyleBackColor = true;
            // 
            // BtnLoadRelations
            // 
            this.BtnLoadRelations.Location = new System.Drawing.Point(6, 5);
            this.BtnLoadRelations.Name = "BtnLoadRelations";
            this.BtnLoadRelations.Size = new System.Drawing.Size(124, 23);
            this.BtnLoadRelations.TabIndex = 14;
            this.BtnLoadRelations.Text = "Load relations";
            this.BtnLoadRelations.UseVisualStyleBackColor = true;
            this.BtnLoadRelations.Click += new System.EventHandler(this.BtnLoadRelations_Click);
            // 
            // DgvRelations
            // 
            this.DgvRelations.AllowUserToAddRows = false;
            this.DgvRelations.AllowUserToDeleteRows = false;
            this.DgvRelations.AllowUserToOrderColumns = true;
            this.DgvRelations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRelations.Location = new System.Drawing.Point(137, 7);
            this.DgvRelations.Name = "DgvRelations";
            this.DgvRelations.Size = new System.Drawing.Size(1144, 696);
            this.DgvRelations.TabIndex = 13;
            // 
            // BtnNewRelation
            // 
            this.BtnNewRelation.Location = new System.Drawing.Point(6, 34);
            this.BtnNewRelation.Name = "BtnNewRelation";
            this.BtnNewRelation.Size = new System.Drawing.Size(124, 23);
            this.BtnNewRelation.TabIndex = 12;
            this.BtnNewRelation.Text = "New relation";
            this.BtnNewRelation.UseVisualStyleBackColor = true;
            this.BtnNewRelation.Click += new System.EventHandler(this.BtnNewRelation_Click);
            // 
            // tabUnits
            // 
            this.tabUnits.Controls.Add(this.DgvUnits);
            this.tabUnits.Controls.Add(this.BtnLoadUnits);
            this.tabUnits.Controls.Add(this.BtnAddUnit);
            this.tabUnits.Location = new System.Drawing.Point(4, 25);
            this.tabUnits.Name = "tabUnits";
            this.tabUnits.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnits.Size = new System.Drawing.Size(1302, 811);
            this.tabUnits.TabIndex = 6;
            this.tabUnits.Text = "Units";
            this.tabUnits.UseVisualStyleBackColor = true;
            // 
            // DgvUnits
            // 
            this.DgvUnits.AllowUserToAddRows = false;
            this.DgvUnits.AllowUserToDeleteRows = false;
            this.DgvUnits.AllowUserToOrderColumns = true;
            this.DgvUnits.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUnits.Location = new System.Drawing.Point(136, 6);
            this.DgvUnits.Name = "DgvUnits";
            this.DgvUnits.Size = new System.Drawing.Size(1144, 696);
            this.DgvUnits.TabIndex = 13;
            // 
            // BtnLoadUnits
            // 
            this.BtnLoadUnits.Location = new System.Drawing.Point(6, 6);
            this.BtnLoadUnits.Name = "BtnLoadUnits";
            this.BtnLoadUnits.Size = new System.Drawing.Size(124, 23);
            this.BtnLoadUnits.TabIndex = 5;
            this.BtnLoadUnits.Text = "Load units";
            this.BtnLoadUnits.UseVisualStyleBackColor = true;
            this.BtnLoadUnits.Click += new System.EventHandler(this.BtnLoadUnits_Click);
            // 
            // BtnJobOrderManager
            // 
            this.BtnJobOrderManager.Location = new System.Drawing.Point(15, 66);
            this.BtnJobOrderManager.Name = "BtnJobOrderManager";
            this.BtnJobOrderManager.Size = new System.Drawing.Size(124, 23);
            this.BtnJobOrderManager.TabIndex = 11;
            this.BtnJobOrderManager.Text = "Job order manager";
            this.BtnJobOrderManager.UseVisualStyleBackColor = true;
            this.BtnJobOrderManager.Click += new System.EventHandler(this.BtnJobOrderManager_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.BtnJobOrderManager);
            this.Controls.Add(this.Managers);
            this.Controls.Add(this.BtnStockManager);
            this.Controls.Add(this.BtnPartManager);
            this.Controls.Add(this.BtnAssemblyManager);
            this.Controls.Add(this.BtnProjectManager);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label1);
            this.Name = "Navigation";
            this.Text = "Welcome to Zebra ERP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Navigation_Load);
            this.Managers.ResumeLayout(false);
            this.GeneralSettings.ResumeLayout(false);
            this.GeneralSettings.PerformLayout();
            this.tabOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOperations)).EndInit();
            this.tabMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaterials)).EndInit();
            this.tabRelations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRelations)).EndInit();
            this.tabUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAddUnit;
        private System.Windows.Forms.Button BtnProjectManager;
        private System.Windows.Forms.Button BtnAssemblyManager;
        private System.Windows.Forms.Button BtnPartManager;
        private System.Windows.Forms.Button BtnStockManager;
        private System.Windows.Forms.TabControl Managers;
        private System.Windows.Forms.Button BtnNewMaterial;
        private System.Windows.Forms.TabPage GeneralSettings;
        private System.Windows.Forms.TextBox txtIPAdres;
        private System.Windows.Forms.TextBox txtIPExtern;
        private System.Windows.Forms.TextBox txtIPIntern;
        private System.Windows.Forms.RadioButton RdbIPAdres2;
        private System.Windows.Forms.RadioButton RdbIPAdres1;
        private System.Windows.Forms.Button BtnNewRelation;
        private System.Windows.Forms.TabPage tabRelations;
        private System.Windows.Forms.Button BtnLoadRelations;
        private System.Windows.Forms.DataGridView DgvRelations;
        private System.Windows.Forms.TabPage tabMaterials;
        private System.Windows.Forms.Button BtnLoadMaterials;
        private System.Windows.Forms.DataGridView DgvMaterials;
        private System.Windows.Forms.TabPage tabUnits;
        private System.Windows.Forms.DataGridView DgvUnits;
        private System.Windows.Forms.Button BtnLoadUnits;
        private System.Windows.Forms.TabPage tabOperations;
        private System.Windows.Forms.DataGridView DgvOperations;
        private System.Windows.Forms.Button BtnLoadOperations;
        private System.Windows.Forms.Button BtnNewOperation;
        private System.Windows.Forms.Button BtnJobOrderManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatabse;
        private System.Windows.Forms.Button BtnConnectSQL;
        private System.Windows.Forms.CheckBox ConnectedBox;
    }
}



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
            this.tabProject = new System.Windows.Forms.TabPage();
            this.tabAssembly = new System.Windows.Forms.TabPage();
            this.tabPart = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNewSupplier = new System.Windows.Forms.Button();
            this.Managers.SuspendLayout();
            this.GeneralSettings.SuspendLayout();
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
            this.btnAddUnit.Location = new System.Drawing.Point(15, 646);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(124, 23);
            this.btnAddUnit.TabIndex = 4;
            this.btnAddUnit.Text = "Unit manager";
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
            this.Managers.Controls.Add(this.tabProject);
            this.Managers.Controls.Add(this.tabAssembly);
            this.Managers.Controls.Add(this.tabPart);
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
            // tabProject
            // 
            this.tabProject.Location = new System.Drawing.Point(4, 22);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabProject.Size = new System.Drawing.Size(1302, 814);
            this.tabProject.TabIndex = 0;
            this.tabProject.Text = "Project manager";
            this.tabProject.UseVisualStyleBackColor = true;
            // 
            // tabAssembly
            // 
            this.tabAssembly.Location = new System.Drawing.Point(4, 22);
            this.tabAssembly.Name = "tabAssembly";
            this.tabAssembly.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssembly.Size = new System.Drawing.Size(1302, 814);
            this.tabAssembly.TabIndex = 1;
            this.tabAssembly.Text = "Assembly manager";
            this.tabAssembly.UseVisualStyleBackColor = true;
            // 
            // tabPart
            // 
            this.tabPart.Location = new System.Drawing.Point(4, 22);
            this.tabPart.Name = "tabPart";
            this.tabPart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPart.Size = new System.Drawing.Size(1302, 814);
            this.tabPart.TabIndex = 2;
            this.tabPart.Text = "Part manager";
            this.tabPart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Material manager";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.Location = new System.Drawing.Point(15, 588);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Size = new System.Drawing.Size(124, 23);
            this.btnNewSupplier.TabIndex = 12;
            this.btnNewSupplier.Text = "New supplier";
            this.btnNewSupplier.UseVisualStyleBackColor = true;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.btnNewSupplier);
            this.Controls.Add(this.Managers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStockManager);
            this.Controls.Add(this.btnOperationManager);
            this.Controls.Add(this.btnPartManager);
            this.Controls.Add(this.btnAssemblyManager);
            this.Controls.Add(this.btnProjectManager);
            this.Controls.Add(this.btnAddUnit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "Navigation";
            this.Text = "Welcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Navigation_Load);
            this.Managers.ResumeLayout(false);
            this.GeneralSettings.ResumeLayout(false);
            this.GeneralSettings.PerformLayout();
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
        private System.Windows.Forms.TabPage tabProject;
        private System.Windows.Forms.TabPage tabAssembly;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPart;
        private System.Windows.Forms.TabPage GeneralSettings;
        private System.Windows.Forms.TextBox txtIPAdres;
        private System.Windows.Forms.TextBox txtIPExtern;
        private System.Windows.Forms.TextBox txtIPIntern;
        private System.Windows.Forms.RadioButton rdbIPAdres2;
        private System.Windows.Forms.RadioButton rdbIPAdres1;
        private System.Windows.Forms.Button btnNewSupplier;
    }
}


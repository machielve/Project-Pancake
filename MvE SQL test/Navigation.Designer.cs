
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
            this.btnExit.Location = new System.Drawing.Point(15, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Location = new System.Drawing.Point(15, 350);
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
            this.btnStockManager.Text = "Stock managerr";
            this.btnStockManager.UseVisualStyleBackColor = true;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 549);
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
    }
}


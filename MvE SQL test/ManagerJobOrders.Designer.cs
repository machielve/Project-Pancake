
namespace MvE_SQL_test
{
    partial class ManagerJobOrders
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
            this.BtnFinnish = new System.Windows.Forms.Button();
            this.DgvJobOrders = new System.Windows.Forms.DataGridView();
            this.BtnLoadJobOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJobOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(12, 707);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(133, 23);
            this.BtnFinnish.TabIndex = 8;
            this.BtnFinnish.Text = "Finnish";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // DgvJobOrders
            // 
            this.DgvJobOrders.AllowUserToAddRows = false;
            this.DgvJobOrders.AllowUserToDeleteRows = false;
            this.DgvJobOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJobOrders.Location = new System.Drawing.Point(165, 38);
            this.DgvJobOrders.Name = "DgvJobOrders";
            this.DgvJobOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvJobOrders.Size = new System.Drawing.Size(1310, 409);
            this.DgvJobOrders.TabIndex = 9;
            // 
            // BtnLoadJobOrders
            // 
            this.BtnLoadJobOrders.Location = new System.Drawing.Point(12, 38);
            this.BtnLoadJobOrders.Name = "BtnLoadJobOrders";
            this.BtnLoadJobOrders.Size = new System.Drawing.Size(133, 23);
            this.BtnLoadJobOrders.TabIndex = 10;
            this.BtnLoadJobOrders.Text = "Load job orders";
            this.BtnLoadJobOrders.UseVisualStyleBackColor = true;
            this.BtnLoadJobOrders.Click += new System.EventHandler(this.BtnLoadJobOrders_Click);
            // 
            // ManagerJobOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.BtnLoadJobOrders);
            this.Controls.Add(this.DgvJobOrders);
            this.Controls.Add(this.BtnFinnish);
            this.Name = "ManagerJobOrders";
            this.Text = "Job order manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerJobOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvJobOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFinnish;
        private System.Windows.Forms.DataGridView DgvJobOrders;
        private System.Windows.Forms.Button BtnLoadJobOrders;
    }
}
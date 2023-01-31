
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
            this.btnFinnish = new System.Windows.Forms.Button();
            this.dgvJobOrders = new System.Windows.Forms.DataGridView();
            this.btnLoadJobOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(12, 707);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(133, 23);
            this.btnFinnish.TabIndex = 8;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // dgvJobOrders
            // 
            this.dgvJobOrders.AllowUserToAddRows = false;
            this.dgvJobOrders.AllowUserToDeleteRows = false;
            this.dgvJobOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobOrders.Location = new System.Drawing.Point(165, 38);
            this.dgvJobOrders.Name = "dgvJobOrders";
            this.dgvJobOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvJobOrders.Size = new System.Drawing.Size(1310, 409);
            this.dgvJobOrders.TabIndex = 9;
            // 
            // btnLoadJobOrders
            // 
            this.btnLoadJobOrders.Location = new System.Drawing.Point(12, 38);
            this.btnLoadJobOrders.Name = "btnLoadJobOrders";
            this.btnLoadJobOrders.Size = new System.Drawing.Size(133, 23);
            this.btnLoadJobOrders.TabIndex = 10;
            this.btnLoadJobOrders.Text = "Load job orders";
            this.btnLoadJobOrders.UseVisualStyleBackColor = true;
            // 
            // ManagerJobOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.btnLoadJobOrders);
            this.Controls.Add(this.dgvJobOrders);
            this.Controls.Add(this.btnFinnish);
            this.Name = "ManagerJobOrders";
            this.Text = "Job order manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.DataGridView dgvJobOrders;
        private System.Windows.Forms.Button btnLoadJobOrders;
    }
}
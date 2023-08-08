
namespace MvE_SQL_test
{
    partial class ManagerStock
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
            this.BtnLoadStock = new System.Windows.Forms.Button();
            this.DgvStock = new System.Windows.Forms.DataGridView();
            this.BtnFinnish = new System.Windows.Forms.Button();
            this.DgvStockIn = new System.Windows.Forms.DataGridView();
            this.DgvStockOut = new System.Windows.Forms.DataGridView();
            this.BtnStockIn = new System.Windows.Forms.Button();
            this.BtnStockOut = new System.Windows.Forms.Button();
            this.BtnReceiveStock = new System.Windows.Forms.Button();
            this.BtnCreatePart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockOut)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadStock
            // 
            this.BtnLoadStock.Location = new System.Drawing.Point(12, 38);
            this.BtnLoadStock.Name = "BtnLoadStock";
            this.BtnLoadStock.Size = new System.Drawing.Size(133, 23);
            this.BtnLoadStock.TabIndex = 5;
            this.BtnLoadStock.Text = "Load all stock";
            this.BtnLoadStock.UseVisualStyleBackColor = true;
            this.BtnLoadStock.Click += new System.EventHandler(this.BtnLoadStock_Click);
            // 
            // DgvStock
            // 
            this.DgvStock.AllowUserToAddRows = false;
            this.DgvStock.AllowUserToDeleteRows = false;
            this.DgvStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStock.Location = new System.Drawing.Point(165, 38);
            this.DgvStock.Name = "DgvStock";
            this.DgvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvStock.Size = new System.Drawing.Size(1310, 250);
            this.DgvStock.TabIndex = 6;
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(12, 776);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(133, 23);
            this.BtnFinnish.TabIndex = 9;
            this.BtnFinnish.Text = "Finnish";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // DgvStockIn
            // 
            this.DgvStockIn.AllowUserToAddRows = false;
            this.DgvStockIn.AllowUserToDeleteRows = false;
            this.DgvStockIn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStockIn.Location = new System.Drawing.Point(165, 340);
            this.DgvStockIn.Name = "DgvStockIn";
            this.DgvStockIn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvStockIn.Size = new System.Drawing.Size(1310, 150);
            this.DgvStockIn.TabIndex = 10;
            // 
            // DgvStockOut
            // 
            this.DgvStockOut.AllowUserToAddRows = false;
            this.DgvStockOut.AllowUserToDeleteRows = false;
            this.DgvStockOut.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvStockOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStockOut.Location = new System.Drawing.Point(165, 550);
            this.DgvStockOut.Name = "DgvStockOut";
            this.DgvStockOut.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvStockOut.Size = new System.Drawing.Size(1310, 150);
            this.DgvStockOut.TabIndex = 11;
            // 
            // BtnStockIn
            // 
            this.BtnStockIn.Location = new System.Drawing.Point(12, 340);
            this.BtnStockIn.Name = "BtnStockIn";
            this.BtnStockIn.Size = new System.Drawing.Size(133, 23);
            this.BtnStockIn.TabIndex = 12;
            this.BtnStockIn.Text = "Buy stock";
            this.BtnStockIn.UseVisualStyleBackColor = true;
            this.BtnStockIn.Click += new System.EventHandler(this.BtnStockIn_Click);
            // 
            // BtnStockOut
            // 
            this.BtnStockOut.Location = new System.Drawing.Point(12, 550);
            this.BtnStockOut.Name = "BtnStockOut";
            this.BtnStockOut.Size = new System.Drawing.Size(133, 23);
            this.BtnStockOut.TabIndex = 13;
            this.BtnStockOut.Text = "Remove stock";
            this.BtnStockOut.UseVisualStyleBackColor = true;
            // 
            // BtnReceiveStock
            // 
            this.BtnReceiveStock.Location = new System.Drawing.Point(12, 369);
            this.BtnReceiveStock.Name = "BtnReceiveStock";
            this.BtnReceiveStock.Size = new System.Drawing.Size(133, 23);
            this.BtnReceiveStock.TabIndex = 14;
            this.BtnReceiveStock.Text = "Receive purchase";
            this.BtnReceiveStock.UseVisualStyleBackColor = true;
            this.BtnReceiveStock.Click += new System.EventHandler(this.BtnReceiveStock_Click);
            // 
            // BtnCreatePart
            // 
            this.BtnCreatePart.Location = new System.Drawing.Point(12, 398);
            this.BtnCreatePart.Name = "BtnCreatePart";
            this.BtnCreatePart.Size = new System.Drawing.Size(133, 23);
            this.BtnCreatePart.TabIndex = 15;
            this.BtnCreatePart.Text = "Make part";
            this.BtnCreatePart.UseVisualStyleBackColor = true;
            // 
            // ManagerStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 811);
            this.Controls.Add(this.BtnCreatePart);
            this.Controls.Add(this.BtnReceiveStock);
            this.Controls.Add(this.BtnStockOut);
            this.Controls.Add(this.BtnStockIn);
            this.Controls.Add(this.DgvStockOut);
            this.Controls.Add(this.DgvStockIn);
            this.Controls.Add(this.BtnFinnish);
            this.Controls.Add(this.DgvStock);
            this.Controls.Add(this.BtnLoadStock);
            this.Name = "ManagerStock";
            this.Text = "Stock manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadStock;
        private System.Windows.Forms.DataGridView DgvStock;
        private System.Windows.Forms.Button BtnFinnish;
        private System.Windows.Forms.DataGridView DgvStockIn;
        private System.Windows.Forms.DataGridView DgvStockOut;
        private System.Windows.Forms.Button BtnStockIn;
        private System.Windows.Forms.Button BtnStockOut;
        private System.Windows.Forms.Button BtnReceiveStock;
        private System.Windows.Forms.Button BtnCreatePart;
    }
}

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
            this.btnLoadStock = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnFinnish = new System.Windows.Forms.Button();
            this.dgvStockIn = new System.Windows.Forms.DataGridView();
            this.dgvStockOut = new System.Windows.Forms.DataGridView();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.btnReceiveStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadStock
            // 
            this.btnLoadStock.Location = new System.Drawing.Point(12, 38);
            this.btnLoadStock.Name = "btnLoadStock";
            this.btnLoadStock.Size = new System.Drawing.Size(133, 23);
            this.btnLoadStock.TabIndex = 5;
            this.btnLoadStock.Text = "Load all stock";
            this.btnLoadStock.UseVisualStyleBackColor = true;
            this.btnLoadStock.Click += new System.EventHandler(this.btnLoadStock_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(165, 38);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvStock.Size = new System.Drawing.Size(1310, 250);
            this.dgvStock.TabIndex = 6;
            // 
            // btnFinnish
            // 
            this.btnFinnish.Location = new System.Drawing.Point(12, 776);
            this.btnFinnish.Name = "btnFinnish";
            this.btnFinnish.Size = new System.Drawing.Size(133, 23);
            this.btnFinnish.TabIndex = 9;
            this.btnFinnish.Text = "Finnish";
            this.btnFinnish.UseVisualStyleBackColor = true;
            this.btnFinnish.Click += new System.EventHandler(this.btnFinnish_Click);
            // 
            // dgvStockIn
            // 
            this.dgvStockIn.AllowUserToAddRows = false;
            this.dgvStockIn.AllowUserToDeleteRows = false;
            this.dgvStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockIn.Location = new System.Drawing.Point(165, 340);
            this.dgvStockIn.Name = "dgvStockIn";
            this.dgvStockIn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvStockIn.Size = new System.Drawing.Size(1310, 150);
            this.dgvStockIn.TabIndex = 10;
            // 
            // dgvStockOut
            // 
            this.dgvStockOut.AllowUserToAddRows = false;
            this.dgvStockOut.AllowUserToDeleteRows = false;
            this.dgvStockOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockOut.Location = new System.Drawing.Point(165, 550);
            this.dgvStockOut.Name = "dgvStockOut";
            this.dgvStockOut.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvStockOut.Size = new System.Drawing.Size(1310, 150);
            this.dgvStockOut.TabIndex = 11;
            // 
            // btnStockIn
            // 
            this.btnStockIn.Location = new System.Drawing.Point(12, 340);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(133, 23);
            this.btnStockIn.TabIndex = 12;
            this.btnStockIn.Text = "Buy stock";
            this.btnStockIn.UseVisualStyleBackColor = true;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnStockOut
            // 
            this.btnStockOut.Location = new System.Drawing.Point(12, 550);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(133, 23);
            this.btnStockOut.TabIndex = 13;
            this.btnStockOut.Text = "Remove stock";
            this.btnStockOut.UseVisualStyleBackColor = true;
            // 
            // btnReceiveStock
            // 
            this.btnReceiveStock.Location = new System.Drawing.Point(12, 369);
            this.btnReceiveStock.Name = "btnReceiveStock";
            this.btnReceiveStock.Size = new System.Drawing.Size(133, 23);
            this.btnReceiveStock.TabIndex = 14;
            this.btnReceiveStock.Text = "Receive purchase";
            this.btnReceiveStock.UseVisualStyleBackColor = true;
            this.btnReceiveStock.Click += new System.EventHandler(this.btnReceiveStock_Click);
            // 
            // ManagerStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 811);
            this.Controls.Add(this.btnReceiveStock);
            this.Controls.Add(this.btnStockOut);
            this.Controls.Add(this.btnStockIn);
            this.Controls.Add(this.dgvStockOut);
            this.Controls.Add(this.dgvStockIn);
            this.Controls.Add(this.btnFinnish);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.btnLoadStock);
            this.Name = "ManagerStock";
            this.Text = "Stock manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadStock;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnFinnish;
        private System.Windows.Forms.DataGridView dgvStockIn;
        private System.Windows.Forms.DataGridView dgvStockOut;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnStockOut;
        private System.Windows.Forms.Button btnReceiveStock;
    }
}
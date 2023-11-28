
namespace Project_pancake
{
    partial class NewProject
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
            this.BtnNewProject = new System.Windows.Forms.Button();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjectMemo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnFinnish
            // 
            this.BtnFinnish.Location = new System.Drawing.Point(15, 180);
            this.BtnFinnish.Name = "BtnFinnish";
            this.BtnFinnish.Size = new System.Drawing.Size(146, 23);
            this.BtnFinnish.TabIndex = 1;
            this.BtnFinnish.Text = "Finnish";
            this.BtnFinnish.UseVisualStyleBackColor = true;
            this.BtnFinnish.Click += new System.EventHandler(this.BtnFinnish_Click);
            // 
            // BtnNewProject
            // 
            this.BtnNewProject.Location = new System.Drawing.Point(108, 151);
            this.BtnNewProject.Name = "BtnNewProject";
            this.BtnNewProject.Size = new System.Drawing.Size(234, 23);
            this.BtnNewProject.TabIndex = 6;
            this.BtnNewProject.Text = "Add new project";
            this.BtnNewProject.UseVisualStyleBackColor = true;
            this.BtnNewProject.Click += new System.EventHandler(this.BtnNewProject_Click);
            // 
            // txtProjectID
            // 
            this.txtProjectID.Location = new System.Drawing.Point(108, 46);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.ReadOnly = true;
            this.txtProjectID.Size = new System.Drawing.Size(234, 20);
            this.txtProjectID.TabIndex = 7;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(108, 20);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(234, 20);
            this.txtProjectName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Project ID";
            // 
            // txtProjectMemo
            // 
            this.txtProjectMemo.Location = new System.Drawing.Point(108, 73);
            this.txtProjectMemo.Multiline = true;
            this.txtProjectMemo.Name = "txtProjectMemo";
            this.txtProjectMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProjectMemo.Size = new System.Drawing.Size(234, 60);
            this.txtProjectMemo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Memo";
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProjectMemo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.BtnNewProject);
            this.Controls.Add(this.BtnFinnish);
            this.Name = "NewProject";
            this.Text = "New project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFinnish;
        private System.Windows.Forms.Button BtnNewProject;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjectMemo;
        private System.Windows.Forms.Label label3;
    }
}
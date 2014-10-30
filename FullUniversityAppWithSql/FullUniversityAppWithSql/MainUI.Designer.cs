namespace FullUniversityAppWithSql
{
    partial class MainUI
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
            this.DepartmentUiButton = new System.Windows.Forms.Button();
            this.studentUiButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepartmentUiButton
            // 
            this.DepartmentUiButton.Location = new System.Drawing.Point(160, 25);
            this.DepartmentUiButton.Name = "DepartmentUiButton";
            this.DepartmentUiButton.Size = new System.Drawing.Size(125, 39);
            this.DepartmentUiButton.TabIndex = 1;
            this.DepartmentUiButton.Text = "Department UI";
            this.DepartmentUiButton.UseVisualStyleBackColor = true;
            this.DepartmentUiButton.Click += new System.EventHandler(this.DepartmentUiButton_Click);
            // 
            // studentUiButton
            // 
            this.studentUiButton.Location = new System.Drawing.Point(25, 25);
            this.studentUiButton.Name = "studentUiButton";
            this.studentUiButton.Size = new System.Drawing.Size(125, 39);
            this.studentUiButton.TabIndex = 0;
            this.studentUiButton.Text = "Student UI";
            this.studentUiButton.UseVisualStyleBackColor = true;
            this.studentUiButton.Click += new System.EventHandler(this.studentUiButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DepartmentUiButton);
            this.groupBox1.Controls.Add(this.studentUiButton);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "University App";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 116);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DepartmentUiButton;
        private System.Windows.Forms.Button studentUiButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
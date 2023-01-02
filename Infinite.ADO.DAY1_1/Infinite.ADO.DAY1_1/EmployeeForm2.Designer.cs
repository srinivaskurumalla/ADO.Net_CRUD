namespace Infinite.ADO.DAY1_1
{
    partial class EmployeeForm2
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
            this.EmpGv = new System.Windows.Forms.DataGridView();
            this.EmpLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGv)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpGv
            // 
            this.EmpGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGv.Location = new System.Drawing.Point(0, 0);
            this.EmpGv.Name = "EmpGv";
            this.EmpGv.RowHeadersWidth = 62;
            this.EmpGv.RowTemplate.Height = 28;
            this.EmpGv.Size = new System.Drawing.Size(753, 317);
            this.EmpGv.TabIndex = 0;
            // 
            // EmpLbl
            // 
            this.EmpLbl.AutoSize = true;
            this.EmpLbl.Location = new System.Drawing.Point(201, 359);
            this.EmpLbl.Name = "EmpLbl";
            this.EmpLbl.Size = new System.Drawing.Size(0, 12);
            this.EmpLbl.TabIndex = 1;
            // 
            // EmployeeForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmpLbl);
            this.Controls.Add(this.EmpGv);
            this.Name = "EmployeeForm2";
            this.Text = "EmployeeForm2";
            this.Load += new System.EventHandler(this.EmployeeForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmpGv;
        private System.Windows.Forms.Label EmpLbl;
    }
}
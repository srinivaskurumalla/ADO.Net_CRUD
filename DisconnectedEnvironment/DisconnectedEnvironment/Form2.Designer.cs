namespace DisconnectedEnvironment
{
    partial class Form2
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
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.TxtProductId = new System.Windows.Forms.TextBox();
            this.lblPId = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.TxtUnitsInStock = new System.Windows.Forms.TextBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.TxtQtyPerUnit = new System.Windows.Forms.TextBox();
            this.TxtUnitPrice = new System.Windows.Forms.TextBox();
            this.lbl6Stock = new System.Windows.Forms.Label();
            this.lbl5UnitPrice = new System.Windows.Forms.Label();
            this.Qtylbl4 = new System.Windows.Forms.Label();
            this.Categorylbl3 = new System.Windows.Forms.Label();
            this.Idlbl2 = new System.Windows.Forms.Label();
            this.Namelbl1 = new System.Windows.Forms.Label();
            this.LblMsg = new System.Windows.Forms.Label();
            this.CbCategoryId = new System.Windows.Forms.ComboBox();
            this.GvProduct = new System.Windows.Forms.DataGridView();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.CbSupplierId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(486, 314);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(103, 37);
            this.UpdateBtn.TabIndex = 39;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.Location = new System.Drawing.Point(486, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 32);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReset.Location = new System.Drawing.Point(486, 187);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 41);
            this.btnReset.TabIndex = 37;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Location = new System.Drawing.Point(486, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 38);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TxtProductId
            // 
            this.TxtProductId.Location = new System.Drawing.Point(291, 59);
            this.TxtProductId.Name = "TxtProductId";
            this.TxtProductId.Size = new System.Drawing.Size(142, 26);
            this.TxtProductId.TabIndex = 1;
            // 
            // lblPId
            // 
            this.lblPId.AutoSize = true;
            this.lblPId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPId.Location = new System.Drawing.Point(104, 62);
            this.lblPId.Name = "lblPId";
            this.lblPId.Size = new System.Drawing.Size(85, 20);
            this.lblPId.TabIndex = 34;
            this.lblPId.Text = "Product ID";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Location = new System.Drawing.Point(486, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 37);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TxtUnitsInStock
            // 
            this.TxtUnitsInStock.Location = new System.Drawing.Point(291, 365);
            this.TxtUnitsInStock.Name = "TxtUnitsInStock";
            this.TxtUnitsInStock.Size = new System.Drawing.Size(142, 26);
            this.TxtUnitsInStock.TabIndex = 7;
            // 
            // TxtProductName
            // 
            this.TxtProductName.Location = new System.Drawing.Point(291, 105);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(142, 26);
            this.TxtProductName.TabIndex = 2;
            // 
            // TxtQtyPerUnit
            // 
            this.TxtQtyPerUnit.Location = new System.Drawing.Point(291, 258);
            this.TxtQtyPerUnit.Name = "TxtQtyPerUnit";
            this.TxtQtyPerUnit.Size = new System.Drawing.Size(142, 26);
            this.TxtQtyPerUnit.TabIndex = 5;
            // 
            // TxtUnitPrice
            // 
            this.TxtUnitPrice.Location = new System.Drawing.Point(291, 308);
            this.TxtUnitPrice.Name = "TxtUnitPrice";
            this.TxtUnitPrice.Size = new System.Drawing.Size(142, 26);
            this.TxtUnitPrice.TabIndex = 6;
            // 
            // lbl6Stock
            // 
            this.lbl6Stock.AutoSize = true;
            this.lbl6Stock.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl6Stock.Location = new System.Drawing.Point(104, 371);
            this.lbl6Stock.Name = "lbl6Stock";
            this.lbl6Stock.Size = new System.Drawing.Size(109, 20);
            this.lbl6Stock.TabIndex = 26;
            this.lbl6Stock.Text = "Units In Stock";
            // 
            // lbl5UnitPrice
            // 
            this.lbl5UnitPrice.AutoSize = true;
            this.lbl5UnitPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl5UnitPrice.Location = new System.Drawing.Point(104, 314);
            this.lbl5UnitPrice.Name = "lbl5UnitPrice";
            this.lbl5UnitPrice.Size = new System.Drawing.Size(77, 20);
            this.lbl5UnitPrice.TabIndex = 25;
            this.lbl5UnitPrice.Text = "Unit Price";
            // 
            // Qtylbl4
            // 
            this.Qtylbl4.AutoSize = true;
            this.Qtylbl4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Qtylbl4.Location = new System.Drawing.Point(104, 264);
            this.Qtylbl4.Name = "Qtylbl4";
            this.Qtylbl4.Size = new System.Drawing.Size(129, 20);
            this.Qtylbl4.TabIndex = 24;
            this.Qtylbl4.Text = "Quantity Per Unit";
            // 
            // Categorylbl3
            // 
            this.Categorylbl3.AutoSize = true;
            this.Categorylbl3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Categorylbl3.Location = new System.Drawing.Point(104, 208);
            this.Categorylbl3.Name = "Categorylbl3";
            this.Categorylbl3.Size = new System.Drawing.Size(91, 20);
            this.Categorylbl3.TabIndex = 23;
            this.Categorylbl3.Text = "Category Id";
            // 
            // Idlbl2
            // 
            this.Idlbl2.AutoSize = true;
            this.Idlbl2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Idlbl2.Location = new System.Drawing.Point(104, 155);
            this.Idlbl2.Name = "Idlbl2";
            this.Idlbl2.Size = new System.Drawing.Size(85, 20);
            this.Idlbl2.TabIndex = 22;
            this.Idlbl2.Text = "Supplier Id";
            // 
            // Namelbl1
            // 
            this.Namelbl1.AutoSize = true;
            this.Namelbl1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Namelbl1.Location = new System.Drawing.Point(104, 108);
            this.Namelbl1.Name = "Namelbl1";
            this.Namelbl1.Size = new System.Drawing.Size(106, 20);
            this.Namelbl1.TabIndex = 21;
            this.Namelbl1.Text = "ProductName";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(134, 491);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(0, 20);
            this.LblMsg.TabIndex = 41;
            // 
            // CbCategoryId
            // 
            this.CbCategoryId.FormattingEnabled = true;
            this.CbCategoryId.Location = new System.Drawing.Point(291, 208);
            this.CbCategoryId.Name = "CbCategoryId";
            this.CbCategoryId.Size = new System.Drawing.Size(142, 28);
            this.CbCategoryId.TabIndex = 42;
            // 
            // GvProduct
            // 
            this.GvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvProduct.Location = new System.Drawing.Point(671, 62);
            this.GvProduct.Name = "GvProduct";
            this.GvProduct.RowHeadersWidth = 62;
            this.GvProduct.RowTemplate.Height = 28;
            this.GvProduct.Size = new System.Drawing.Size(956, 391);
            this.GvProduct.TabIndex = 43;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnRefresh.Location = new System.Drawing.Point(486, 371);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(103, 33);
            this.BtnRefresh.TabIndex = 44;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // CbSupplierId
            // 
            this.CbSupplierId.FormattingEnabled = true;
            this.CbSupplierId.Location = new System.Drawing.Point(291, 155);
            this.CbSupplierId.Name = "CbSupplierId";
            this.CbSupplierId.Size = new System.Drawing.Size(142, 28);
            this.CbSupplierId.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 41;
            // 
            // LblHeading
            // 
            this.LblHeading.AutoSize = true;
            this.LblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblHeading.Location = new System.Drawing.Point(158, 13);
            this.LblHeading.Name = "LblHeading";
            this.LblHeading.Size = new System.Drawing.Size(364, 36);
            this.LblHeading.TabIndex = 45;
            this.LblHeading.Text = "DISCONNECTED DEMO";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1696, 576);
            this.Controls.Add(this.LblHeading);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.GvProduct);
            this.Controls.Add(this.CbSupplierId);
            this.Controls.Add(this.CbCategoryId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.TxtProductId);
            this.Controls.Add(this.lblPId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TxtUnitsInStock);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.TxtQtyPerUnit);
            this.Controls.Add(this.TxtUnitPrice);
            this.Controls.Add(this.lbl6Stock);
            this.Controls.Add(this.lbl5UnitPrice);
            this.Controls.Add(this.Qtylbl4);
            this.Controls.Add(this.Categorylbl3);
            this.Controls.Add(this.Idlbl2);
            this.Controls.Add(this.Namelbl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox TxtProductId;
        private System.Windows.Forms.Label lblPId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox TxtUnitsInStock;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.TextBox TxtQtyPerUnit;
        private System.Windows.Forms.TextBox TxtUnitPrice;
        private System.Windows.Forms.Label lbl6Stock;
        private System.Windows.Forms.Label lbl5UnitPrice;
        private System.Windows.Forms.Label Qtylbl4;
        private System.Windows.Forms.Label Categorylbl3;
        private System.Windows.Forms.Label Idlbl2;
        private System.Windows.Forms.Label Namelbl1;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.ComboBox CbCategoryId;
        private System.Windows.Forms.DataGridView GvProduct;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.ComboBox CbSupplierId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblHeading;
    }
}
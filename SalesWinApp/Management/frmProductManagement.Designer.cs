namespace SalesWinApp.Management
{
    partial class frmProductManagement
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
            txtSearch = new TextBox();
            lbSearch = new Label();
            btnClose = new Button();
            dgvProductList = new DataGridView();
            btnDelete = new Button();
            btnNew = new Button();
            txtUnitPrice = new TextBox();
            lbUnitPrice = new Label();
            txtWeight = new TextBox();
            lbWeight = new Label();
            txtCategory = new TextBox();
            lbCategory = new Label();
            txtProductName = new TextBox();
            lbProductName = new Label();
            txtProductID = new TextBox();
            lbProductId = new Label();
            txtUnitInStock = new TextBox();
            lbUnitInStock = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(428, 102);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 23);
            txtSearch.TabIndex = 52;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(380, 105);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(42, 15);
            lbSearch.TabIndex = 51;
            lbSearch.Text = "Search";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(328, 383);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 50;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvProductList
            // 
            dgvProductList.AllowUserToAddRows = false;
            dgvProductList.AllowUserToDeleteRows = false;
            dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(11, 131);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.RowTemplate.Height = 25;
            dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.Size = new Size(542, 246);
            dgvProductList.TabIndex = 49;
            dgvProductList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(247, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(166, 383);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 47;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Location = new Point(404, 41);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(149, 23);
            txtUnitPrice.TabIndex = 46;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(315, 44);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(58, 15);
            lbUnitPrice.TabIndex = 45;
            lbUnitPrice.Text = "Unit Price";
            // 
            // txtWeight
            // 
            txtWeight.Enabled = false;
            txtWeight.Location = new Point(404, 12);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(149, 23);
            txtWeight.TabIndex = 44;
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(315, 15);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(45, 15);
            lbWeight.TabIndex = 43;
            lbWeight.Text = "Weight";
            // 
            // txtCategory
            // 
            txtCategory.Enabled = false;
            txtCategory.Location = new Point(112, 70);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(149, 23);
            txtCategory.TabIndex = 42;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new Point(11, 73);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(55, 15);
            lbCategory.TabIndex = 41;
            lbCategory.Text = "Category";
            // 
            // txtProductName
            // 
            txtProductName.Enabled = false;
            txtProductName.Location = new Point(112, 41);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(149, 23);
            txtProductName.TabIndex = 40;
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(11, 44);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(82, 15);
            lbProductName.TabIndex = 39;
            lbProductName.Text = "Product name";
            // 
            // txtProductID
            // 
            txtProductID.Enabled = false;
            txtProductID.Location = new Point(112, 12);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(149, 23);
            txtProductID.TabIndex = 38;
            // 
            // lbProductId
            // 
            lbProductId.AutoSize = true;
            lbProductId.Location = new Point(11, 15);
            lbProductId.Name = "lbProductId";
            lbProductId.Size = new Size(63, 15);
            lbProductId.TabIndex = 37;
            lbProductId.Text = "Product ID";
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Enabled = false;
            txtUnitInStock.Location = new Point(404, 70);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(149, 23);
            txtUnitInStock.TabIndex = 54;
            // 
            // lbUnitInStock
            // 
            lbUnitInStock.AutoSize = true;
            lbUnitInStock.Location = new Point(315, 73);
            lbUnitInStock.Name = "lbUnitInStock";
            lbUnitInStock.Size = new Size(74, 15);
            lbUnitInStock.TabIndex = 53;
            lbUnitInStock.Text = "Unit In Stock";
            // 
            // frmProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 414);
            Controls.Add(txtUnitInStock);
            Controls.Add(lbUnitInStock);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Controls.Add(btnClose);
            Controls.Add(dgvProductList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(txtUnitPrice);
            Controls.Add(lbUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(lbWeight);
            Controls.Add(txtCategory);
            Controls.Add(lbCategory);
            Controls.Add(txtProductName);
            Controls.Add(lbProductName);
            Controls.Add(txtProductID);
            Controls.Add(lbProductId);
            Name = "frmProductManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Management";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCountryFilter;
        private ComboBox cbCityFilter;
        private Label lbCountryFilter;
        private Label lbCityFilter;
        private TextBox txtSearch;
        private Label lbSearch;
        private Button btnClose;
        private DataGridView dgvProductList;
        private Button btnDelete;
        private Button btnNew;
        private TextBox txtUnitPrice;
        private Label lbUnitPrice;
        private TextBox txtWeight;
        private Label lbWeight;
        private TextBox txtCategory;
        private Label lbCategory;
        private TextBox txtProductName;
        private Label lbProductName;
        private TextBox txtProductID;
        private Label lbProductId;
        private TextBox txtUnitInStock;
        private Label lbUnitInStock;
    }
}
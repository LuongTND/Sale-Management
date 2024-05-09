namespace SalesWinApp.Management
{
    partial class frmOrderManagement
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
            dgvOrderList = new DataGridView();
            btnDelete = new Button();
            btnNew = new Button();
            txtShippedDate = new TextBox();
            lbShippedDate = new Label();
            txtRequirredDate = new TextBox();
            lbRequirredDate = new Label();
            txtOrderDate = new TextBox();
            lbOrderDate = new Label();
            txtOrderID = new TextBox();
            lbOrderID = new Label();
            txtMemberID = new TextBox();
            lbMemberID = new Label();
            txtFreight = new TextBox();
            lbFreight = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
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
            // dgvOrderList
            // 
            dgvOrderList.AllowUserToAddRows = false;
            dgvOrderList.AllowUserToDeleteRows = false;
            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(11, 131);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.RowTemplate.Height = 25;
            dgvOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderList.Size = new Size(542, 246);
            dgvOrderList.TabIndex = 49;
            dgvOrderList.CellDoubleClick += dgvMemberList_CellDoubleClick;
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
            // txtShippedDate
            // 
            txtShippedDate.Enabled = false;
            txtShippedDate.Location = new Point(404, 41);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(149, 23);
            txtShippedDate.TabIndex = 46;
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(315, 44);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(77, 15);
            lbShippedDate.TabIndex = 45;
            lbShippedDate.Text = "Shipped Date";
            // 
            // txtRequirredDate
            // 
            txtRequirredDate.Enabled = false;
            txtRequirredDate.Location = new Point(404, 12);
            txtRequirredDate.Name = "txtRequirredDate";
            txtRequirredDate.Size = new Size(149, 23);
            txtRequirredDate.TabIndex = 44;
            // 
            // lbRequirredDate
            // 
            lbRequirredDate.AutoSize = true;
            lbRequirredDate.Location = new Point(315, 15);
            lbRequirredDate.Name = "lbRequirredDate";
            lbRequirredDate.Size = new Size(85, 15);
            lbRequirredDate.TabIndex = 43;
            lbRequirredDate.Text = "Requirred Date";
            // 
            // txtOrderDate
            // 
            txtOrderDate.Enabled = false;
            txtOrderDate.Location = new Point(112, 70);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(149, 23);
            txtOrderDate.TabIndex = 42;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(11, 73);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(64, 15);
            lbOrderDate.TabIndex = 41;
            lbOrderDate.Text = "Order Date";
            // 
            // txtOrderID
            // 
            txtOrderID.Enabled = false;
            txtOrderID.Location = new Point(112, 12);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(149, 23);
            txtOrderID.TabIndex = 40;
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(11, 15);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(51, 15);
            lbOrderID.TabIndex = 39;
            lbOrderID.Text = "Order ID";
            // 
            // txtMemberID
            // 
            txtMemberID.Enabled = false;
            txtMemberID.Location = new Point(112, 41);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(149, 23);
            txtMemberID.TabIndex = 38;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(11, 44);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(66, 15);
            lbMemberID.TabIndex = 37;
            lbMemberID.Text = "Member ID";
            // 
            // txtFreight
            // 
            txtFreight.Enabled = false;
            txtFreight.Location = new Point(404, 70);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(149, 23);
            txtFreight.TabIndex = 54;
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(315, 73);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(44, 15);
            lbFreight.TabIndex = 53;
            lbFreight.Text = "Freight";
            // 
            // frmOrderManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 414);
            Controls.Add(txtFreight);
            Controls.Add(lbFreight);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Controls.Add(btnClose);
            Controls.Add(dgvOrderList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(txtShippedDate);
            Controls.Add(lbShippedDate);
            Controls.Add(txtRequirredDate);
            Controls.Add(lbRequirredDate);
            Controls.Add(txtOrderDate);
            Controls.Add(lbOrderDate);
            Controls.Add(txtOrderID);
            Controls.Add(lbOrderID);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Name = "frmOrderManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Management";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
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
        private DataGridView dgvOrderList;
        private Button btnDelete;
        private Button btnNew;
        private TextBox txtShippedDate;
        private Label lbShippedDate;
        private TextBox txtRequirredDate;
        private Label lbRequirredDate;
        private TextBox txtOrderDate;
        private Label lbOrderDate;
        private TextBox txtOrderID;
        private Label lbOrderID;
        private TextBox txtMemberID;
        private Label lbMemberID;
        private TextBox txtFreight;
        private Label lbFreight;
    }
}
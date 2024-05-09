namespace SalesWinApp.Detail
{
    partial class frmProductDetail
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
            cbCategory = new ComboBox();
            lbCategory = new Label();
            txtProductName = new TextBox();
            lbProductName = new Label();
            txtProductID = new TextBox();
            lbProductId = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtWeight = new TextBox();
            lbWeight = new Label();
            lbUnitPrice = new Label();
            lbUnitsInStock = new Label();
            txtUnitPrice = new MaskedTextBox();
            txtUnitsInStock = new MaskedTextBox();
            SuspendLayout();
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(107, 70);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(187, 23);
            cbCategory.TabIndex = 57;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new Point(8, 73);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(55, 15);
            lbCategory.TabIndex = 49;
            lbCategory.Text = "Category";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(107, 41);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(187, 23);
            txtProductName.TabIndex = 54;
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(10, 44);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(84, 15);
            lbProductName.TabIndex = 56;
            lbProductName.Text = "Product Name";
            // 
            // txtProductID
            // 
            txtProductID.Enabled = false;
            txtProductID.Location = new Point(107, 12);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(187, 23);
            txtProductID.TabIndex = 53;
            // 
            // lbProductId
            // 
            lbProductId.AutoSize = true;
            lbProductId.Location = new Point(10, 15);
            lbProductId.Name = "lbProductId";
            lbProductId.Size = new Size(63, 15);
            lbProductId.TabIndex = 52;
            lbProductId.Text = "Product ID";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(219, 198);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 51;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(107, 198);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 59;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(107, 99);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(187, 23);
            txtWeight.TabIndex = 60;
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(10, 102);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(45, 15);
            lbWeight.TabIndex = 61;
            lbWeight.Text = "Weight";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(10, 131);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(58, 15);
            lbUnitPrice.TabIndex = 63;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(10, 160);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(49, 15);
            lbUnitsInStock.TabIndex = 65;
            lbUnitsInStock.Text = "In Stock";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(107, 128);
            txtUnitPrice.Mask = "000000";
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.RightToLeft = RightToLeft.No;
            txtUnitPrice.Size = new Size(187, 23);
            txtUnitPrice.TabIndex = 66;
            txtUnitPrice.ValidatingType = typeof(int);
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(107, 157);
            txtUnitsInStock.Mask = "00000";
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.RightToLeft = RightToLeft.No;
            txtUnitsInStock.Size = new Size(187, 23);
            txtUnitsInStock.TabIndex = 67;
            txtUnitsInStock.ValidatingType = typeof(int);
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 235);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(lbWeight);
            Controls.Add(cbCategory);
            Controls.Add(lbCategory);
            Controls.Add(txtProductName);
            Controls.Add(lbProductName);
            Controls.Add(txtProductID);
            Controls.Add(lbProductId);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmProductDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            Load += frmMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label lbPassword;
        private ComboBox cbCategory;
        private Label lbCategory;
        private Label lbCity;
        private TextBox txtProductName;
        private Label lbProductName;
        private TextBox txtCompanyName;
        private Label lbCompanyName;
        private TextBox txtProductID;
        private Label lbProductId;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtWeight;
        private Label lbWeight;
        private Label lbUnitPrice;
        private Label lbUnitsInStock;
        private MaskedTextBox txtUnitPrice;
        private MaskedTextBox txtUnitsInStock;
    }
}
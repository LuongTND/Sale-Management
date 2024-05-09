namespace SalesWinApp.Detail
{
    partial class frmOrderDetailsDetail
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
            lbUnitPrice = new Label();
            lbDiscount = new Label();
            cbProduct = new Label();
            lbQuantity = new Label();
            txtOrderID = new TextBox();
            lbOrderId = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtQuantity = new MaskedTextBox();
            txtUnitPrice = new MaskedTextBox();
            txtDiscount = new MaskedTextBox();
            cbProducts = new ComboBox();
            SuspendLayout();
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(10, 101);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(58, 15);
            lbUnitPrice.TabIndex = 59;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Location = new Point(8, 130);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(54, 15);
            lbDiscount.TabIndex = 49;
            lbDiscount.Text = "Discount";
            // 
            // cbProduct
            // 
            cbProduct.AutoSize = true;
            cbProduct.Location = new Point(10, 44);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(49, 15);
            cbProduct.TabIndex = 56;
            cbProduct.Text = "Product";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(10, 72);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(53, 15);
            lbQuantity.TabIndex = 54;
            lbQuantity.Text = "Quantity";
            // 
            // txtOrderID
            // 
            txtOrderID.Enabled = false;
            txtOrderID.Location = new Point(107, 12);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(187, 23);
            txtOrderID.TabIndex = 53;
            // 
            // lbOrderId
            // 
            lbOrderId.AutoSize = true;
            lbOrderId.Location = new Point(10, 15);
            lbOrderId.Name = "lbOrderId";
            lbOrderId.Size = new Size(51, 15);
            lbOrderId.TabIndex = 52;
            lbOrderId.Text = "Order ID";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(219, 156);
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
            btnSave.Location = new Point(107, 156);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 59;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(107, 69);
            txtQuantity.Mask = "000";
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(187, 23);
            txtQuantity.TabIndex = 60;
            txtQuantity.ValidatingType = typeof(int);
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Location = new Point(107, 98);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.RightToLeft = RightToLeft.No;
            txtUnitPrice.Size = new Size(187, 23);
            txtUnitPrice.TabIndex = 61;
            txtUnitPrice.ValidatingType = typeof(int);
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(107, 127);
            txtDiscount.Mask = "0000";
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(187, 23);
            txtDiscount.TabIndex = 62;
            txtDiscount.ValidatingType = typeof(int);
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(107, 41);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(187, 23);
            cbProducts.TabIndex = 63;
            cbProducts.SelectedValueChanged += cbProducts_SelectedValueChanged;
            // 
            // frmOrderDetailsDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 190);
            Controls.Add(cbProducts);
            Controls.Add(txtDiscount);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtQuantity);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbDiscount);
            Controls.Add(cbProduct);
            Controls.Add(lbQuantity);
            Controls.Add(txtOrderID);
            Controls.Add(lbOrderId);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmOrderDetailsDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Details";
            Load += frmMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbUnitPrice;
        private Label lbDiscount;
        private TextBox txtProductId;
        private Label cbProduct;
        private Label lbQuantity;
        private TextBox txtOrderID;
        private Label lbOrderId;
        private Button btnCancel;
        private Button btnSave;
        private MaskedTextBox txtQuantity;
        private MaskedTextBox txtUnitPrice;
        private MaskedTextBox txtDiscount;
        private ComboBox cbProducts;
    }
}
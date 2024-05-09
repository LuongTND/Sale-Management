namespace SalesWinApp.Management
{
    partial class frmOrderDetail
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
            btnClose = new Button();
            dgvOrderDetailList = new DataGridView();
            btnDelete = new Button();
            btnNew = new Button();
            lbShippedDate = new Label();
            lbRequirredDate = new Label();
            lbOrderDate = new Label();
            txtOrderID = new TextBox();
            lbOrderID = new Label();
            lbMemberID = new Label();
            lbFreight = new Label();
            txtFreight = new MaskedTextBox();
            txtOrderDate = new MaskedTextBox();
            txtRequiredDate = new MaskedTextBox();
            txtShippedDate = new MaskedTextBox();
            btnSave = new Button();
            cbMember = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailList).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(478, 383);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 50;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvOrderDetailList
            // 
            dgvOrderDetailList.AllowUserToAddRows = false;
            dgvOrderDetailList.AllowUserToDeleteRows = false;
            dgvOrderDetailList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetailList.Location = new Point(11, 99);
            dgvOrderDetailList.Name = "dgvOrderDetailList";
            dgvOrderDetailList.ReadOnly = true;
            dgvOrderDetailList.RowTemplate.Height = 25;
            dgvOrderDetailList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetailList.Size = new Size(542, 278);
            dgvOrderDetailList.TabIndex = 49;
            dgvOrderDetailList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(92, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(11, 383);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 47;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
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
            // lbRequirredDate
            // 
            lbRequirredDate.AutoSize = true;
            lbRequirredDate.Location = new Point(315, 15);
            lbRequirredDate.Name = "lbRequirredDate";
            lbRequirredDate.Size = new Size(85, 15);
            lbRequirredDate.TabIndex = 43;
            lbRequirredDate.Text = "Requirred Date";
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
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(11, 44);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(52, 15);
            lbMemberID.TabIndex = 37;
            lbMemberID.Text = "Member";
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
            // txtFreight
            // 
            txtFreight.Location = new Point(404, 70);
            txtFreight.Mask = "000000000";
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(149, 23);
            txtFreight.TabIndex = 58;
            txtFreight.ValidatingType = typeof(int);
            // 
            // txtOrderDate
            // 
            txtOrderDate.Enabled = false;
            txtOrderDate.Location = new Point(112, 70);
            txtOrderDate.Mask = "00/00/0000 90:00";
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(149, 23);
            txtOrderDate.TabIndex = 59;
            txtOrderDate.ValidatingType = typeof(DateTime);
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(404, 12);
            txtRequiredDate.Mask = "00/00/0000 90:00";
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new Size(149, 23);
            txtRequiredDate.TabIndex = 60;
            txtRequiredDate.ValidatingType = typeof(DateTime);
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(404, 41);
            txtShippedDate.Mask = "00/00/0000 90:00";
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(149, 23);
            txtShippedDate.TabIndex = 61;
            txtShippedDate.ValidatingType = typeof(DateTime);
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(397, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 62;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbMember
            // 
            cbMember.FormattingEnabled = true;
            cbMember.Location = new Point(112, 41);
            cbMember.Name = "cbMember";
            cbMember.Size = new Size(149, 23);
            cbMember.TabIndex = 63;
            // 
            // frmOrderDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 414);
            Controls.Add(cbMember);
            Controls.Add(btnSave);
            Controls.Add(txtShippedDate);
            Controls.Add(txtRequiredDate);
            Controls.Add(txtOrderDate);
            Controls.Add(txtFreight);
            Controls.Add(lbFreight);
            Controls.Add(btnClose);
            Controls.Add(dgvOrderDetailList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(lbShippedDate);
            Controls.Add(lbRequirredDate);
            Controls.Add(lbOrderDate);
            Controls.Add(txtOrderID);
            Controls.Add(lbOrderID);
            Controls.Add(lbMemberID);
            Name = "frmOrderDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Management";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCountryFilter;
        private ComboBox cbCityFilter;
        private Label lbCountryFilter;
        private Label lbCityFilter;
        private Button btnClose;
        private DataGridView dgvOrderDetailList;
        private Button btnDelete;
        private Button btnNew;
        private Label lbShippedDate;
        private Label lbRequirredDate;
        private Label lbOrderDate;
        private TextBox txtOrderID;
        private Label lbOrderID;
        private Label lbMemberID;
        private Label lbFreight;
        private MaskedTextBox txtFreight;
        private MaskedTextBox txtOrderDate;
        private MaskedTextBox txtRequiredDate;
        private MaskedTextBox txtShippedDate;
        private Button btnSave;
        private ComboBox cbMember;
    }
}
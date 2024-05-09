namespace SalesWinApp.Management
{
    partial class frmMemberManagement
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
            dgvMemberList = new DataGridView();
            btnDelete = new Button();
            btnNew = new Button();
            txtCountry = new TextBox();
            lbCountry = new Label();
            txtCity = new TextBox();
            lbCity = new Label();
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtCompanyName = new TextBox();
            lbCompanyName = new Label();
            txtMemberID = new TextBox();
            lbMemberId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
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
            // dgvMemberList
            // 
            dgvMemberList.AllowUserToAddRows = false;
            dgvMemberList.AllowUserToDeleteRows = false;
            dgvMemberList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(11, 131);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowTemplate.Height = 25;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(542, 246);
            dgvMemberList.TabIndex = 49;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
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
            // txtCountry
            // 
            txtCountry.Enabled = false;
            txtCountry.Location = new Point(404, 41);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(149, 23);
            txtCountry.TabIndex = 46;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(315, 44);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 45;
            lbCountry.Text = "Country";
            // 
            // txtCity
            // 
            txtCity.Enabled = false;
            txtCity.Location = new Point(404, 12);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(149, 23);
            txtCity.TabIndex = 44;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(315, 15);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 43;
            lbCity.Text = "City";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(112, 41);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(149, 23);
            txtEmail.TabIndex = 42;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(11, 44);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 41;
            lbEmail.Text = "Email";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Enabled = false;
            txtCompanyName.Location = new Point(112, 70);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(149, 23);
            txtCompanyName.TabIndex = 40;
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(11, 73);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(92, 15);
            lbCompanyName.TabIndex = 39;
            lbCompanyName.Text = "Company name";
            // 
            // txtMemberID
            // 
            txtMemberID.Enabled = false;
            txtMemberID.Location = new Point(112, 12);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(149, 23);
            txtMemberID.TabIndex = 38;
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(11, 15);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(66, 15);
            lbMemberId.TabIndex = 37;
            lbMemberId.Text = "Member ID";
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 414);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Controls.Add(btnClose);
            Controls.Add(dgvMemberList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtCompanyName);
            Controls.Add(lbCompanyName);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberId);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
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
        private DataGridView dgvMemberList;
        private Button btnDelete;
        private Button btnNew;
        private TextBox txtCountry;
        private Label lbCountry;
        private TextBox txtCity;
        private Label lbCity;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtCompanyName;
        private Label lbCompanyName;
        private TextBox txtMemberID;
        private Label lbMemberId;
    }
}
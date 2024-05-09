namespace SalesWinApp.Detail
{
    partial class frmMemberDetail
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
            txtPassword = new TextBox();
            lbPassword = new Label();
            cbCountry = new ComboBox();
            cbCity = new ComboBox();
            lbCountry = new Label();
            lbCity = new Label();
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtCompanyName = new TextBox();
            lbCompanyName = new Label();
            txtMemberID = new TextBox();
            lbMemberId = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(107, 69);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(187, 23);
            txtPassword.TabIndex = 55;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(10, 72);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 59;
            lbPassword.Text = "Password";
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(107, 127);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(187, 23);
            cbCountry.TabIndex = 57;
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(107, 156);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(187, 23);
            cbCity.TabIndex = 58;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(8, 130);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 49;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(10, 159);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 58;
            lbCity.Text = "City";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(107, 41);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 23);
            txtEmail.TabIndex = 54;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(10, 44);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 56;
            lbEmail.Text = "Email";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(107, 98);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(187, 23);
            txtCompanyName.TabIndex = 56;
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(8, 101);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(92, 15);
            lbCompanyName.TabIndex = 54;
            lbCompanyName.Text = "Company name";
            // 
            // txtMemberID
            // 
            txtMemberID.Enabled = false;
            txtMemberID.Location = new Point(107, 12);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(187, 23);
            txtMemberID.TabIndex = 53;
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(10, 15);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(66, 15);
            lbMemberId.TabIndex = 52;
            lbMemberId.Text = "Member ID";
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
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 235);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(cbCountry);
            Controls.Add(cbCity);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtCompanyName);
            Controls.Add(lbCompanyName);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberId);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmMemberDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member";
            Load += frmMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label lbPassword;
        private ComboBox cbCountry;
        private ComboBox cbCity;
        private Label lbCountry;
        private Label lbCity;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtCompanyName;
        private Label lbCompanyName;
        private TextBox txtMemberID;
        private Label lbMemberId;
        private Button btnCancel;
        private Button btnSave;
    }
}
using DataAccess.Repository.Implement;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessObject;
using SalesWinApp.Detail;

namespace SalesWinApp.Management
{
    public partial class frmMemberManagement : Form
    {
        public bool IsAdmin { get; set; }
        public int? AccountId { get; set; }
        public IRepository<MemberObject> memberRepository = new MemberRepository();
        public BindingSource source = new BindingSource();

        public frmMemberManagement()
        {
            InitializeComponent();
        }

        void LoadList()
        {
            source.DataSource = memberRepository.GetAll().ToList();
            txtMemberID.DataBindings.Clear();
            txtCompanyName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtCountry.DataBindings.Clear();

            txtMemberID.DataBindings.Add("Text", source, "MemberId");
            txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
            txtEmail.DataBindings.Add("Text", source, "Email");
            txtCity.DataBindings.Add("Text", source, "City");
            txtCountry.DataBindings.Add("Text", source, "Country");

            dgvMemberList.DataSource = source;
            dgvMemberList.Columns[5].Visible = false;
            dgvMemberList.Columns[6].Visible = false;

            btnDelete.Enabled = source.Count > 0;

            if (!IsAdmin)
            {
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail memberDetail = new frmMemberDetail();
            memberDetail.ShowDialog();
            LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(txtMemberID.Text);
                memberRepository.Delete(id);
                MessageBox.Show($"Delete id {id} success", "Delete");
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete fail");
            }
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AccountId != null)
            {
                if (Convert.ToInt32(txtMemberID.Text) != AccountId)
                {
                    MessageBox.Show("You cannot update this member", "Update member");
                    return;
                }
            }

            frmMemberDetail frmMemberDetail = new frmMemberDetail()
            {
                memberId = Convert.ToInt32(txtMemberID.Text)
            };
            frmMemberDetail.ShowDialog();
            LoadList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var key = txtSearch.Text;

            source.DataSource = memberRepository.GetByConditions(m =>
                (m.MemberId.ToString() +
                m.CompanyName +
                m.Country +
                m.City +
                m.Email).Contains(key)
            ).ToList();
        }
    }
}

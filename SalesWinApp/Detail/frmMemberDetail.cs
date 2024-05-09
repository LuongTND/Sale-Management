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

namespace SalesWinApp.Detail
{
    public partial class frmMemberDetail : Form
    {
        IRepository<MemberObject> _memberRepo = new MemberRepository();
        public int? memberId { get; set; }

        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            if (!(memberId == null))
            {
                var memberInfo = _memberRepo.GetById((int)memberId);
                txtMemberID.Text = memberInfo.MemberId.ToString();
                txtCompanyName.Text = memberInfo.CompanyName;
                txtEmail.Text = memberInfo.Email;
                txtPassword.Text = memberInfo.Password;
                cbCity.Text = memberInfo.City;
                cbCountry.Text = memberInfo.Country;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject()
                {
                    MemberId = memberId == null ? 0 : Convert.ToInt32(txtMemberID.Text),
                    CompanyName = txtCompanyName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = cbCity.Text,
                    Country = cbCountry.Text
                };

                if (memberId == null)
                {
                    _memberRepo.Create(member);
                }
                else
                {
                    _memberRepo.Update(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

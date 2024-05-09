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
    public partial class frmOrderManagement : Form
    {
        public bool IsAdmin { get; set; }
        public int? AccountId { get; set; }
        public IRepository<OrderObject> orderRepository = new OrderRepository();
        public BindingSource source = new BindingSource();

        public frmOrderManagement()
        {
            InitializeComponent();
        }

        void LoadList()
        {
            if(AccountId != null)
            {
                source.DataSource = orderRepository.GetByConditions(o => o.MemberId == AccountId).ToList();
            }
            else
            {
                source.DataSource = orderRepository.GetAll().ToList();
            }

            txtMemberID.DataBindings.Clear();
            txtOrderID.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtRequirredDate.DataBindings.Clear();
            txtShippedDate.DataBindings.Clear();
            txtFreight.DataBindings.Clear();

            txtMemberID.DataBindings.Add("Text", source, "MemberId");
            txtOrderID.DataBindings.Add("Text", source, "OrderId");
            txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
            txtRequirredDate.DataBindings.Add("Text", source, "RequiredDate");
            txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
            txtFreight.DataBindings.Add("Text", source, "Freight");

            dgvOrderList.DataSource = source;
            dgvOrderList.Columns[6].Visible = false;            
            dgvOrderList.Columns[7].Visible = false;

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
            frmOrderDetail orderDetail = new frmOrderDetail()
            {
                IsAdmin = IsAdmin
            };
            orderDetail.ShowDialog();
            LoadList();
            source.Position = source.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(txtOrderID.Text);
                orderRepository.Delete(id);
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
            frmOrderDetail orderDetail = new frmOrderDetail()
            {
                orderId = Convert.ToInt32(txtOrderID.Text),
                IsAdmin = IsAdmin
            };
            orderDetail.ShowDialog();
            LoadList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var key = txtSearch.Text;

            source.DataSource = orderRepository.GetByConditions(m =>
                (m.OrderId.ToString() +
                m.MemberId.ToString() +
                m.OrderDate +
                m.RequiredDate +
                m.ShippedDate +
                m.Freight).Contains(key)
            ).ToList();
        }
    }
}

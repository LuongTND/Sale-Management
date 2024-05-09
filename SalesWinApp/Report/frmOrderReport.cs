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
    public partial class frmOrderReport : Form
    {
        public bool IsAdmin { get; set; }
        public int? AccountId { get; set; }
        public IRepository<OrderObject> orderRepository = new OrderRepository();
        public BindingSource source = new BindingSource();

        public frmOrderReport()
        {
            InitializeComponent();
        }

        void LoadList()
        {
            if (AccountId != null)
            {
                source.DataSource = orderRepository.GetByConditions(o =>
                                        o.MemberId == AccountId &&
                                        o.OrderDate >= txtStartDate.Value &&
                                        o.OrderDate <= txtEndDate.Value.AddDays(1))
                                        .ToList();
            }
            else
            {
                source.DataSource = orderRepository.GetByConditions(o =>
                                        o.OrderDate >= txtStartDate.Value &&
                                        o.OrderDate <= txtEndDate.Value.AddDays(1)
                                        ).ToList();
            }

            txtMemberID.DataBindings.Clear();
            txtOrderID.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtRequirredDate.DataBindings.Clear();
            txtShippedDate.DataBindings.Clear();
            txtFreight.DataBindings.Clear();

            txtMemberID.DataBindings.Add("Text", source, "Member");
            txtOrderID.DataBindings.Add("Text", source, "OrderId");
            txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
            txtRequirredDate.DataBindings.Add("Text", source, "RequiredDate");
            txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
            txtFreight.DataBindings.Add("Text", source, "Freight");

            dgvOrderList.DataSource = source;
            dgvOrderList.Columns[6].Visible = false;
            dgvOrderList.Columns[7].Visible = false;

            if(source.Count > 0)
            {
                GetOrderDetailData();
            }
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetOrderDetailData()
        {
            var selectedRow = dgvOrderList.SelectedRows[0];
            var selectedOrder = selectedRow.DataBoundItem as OrderObject;
            var orderDetails = new BindingList<OrderDetailsObject>(selectedOrder.Details.ToList());

            dgvOrderDetailList.DataSource = orderDetails;
            dgvOrderDetailList.Columns[5].Visible = false;
            dgvOrderDetailList.Columns[0].Visible = false;
            dgvOrderDetailList.Columns[1].Visible = false;

            dgvOrderDetailList.Columns[6].DisplayIndex = 0;
        }

        private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetOrderDetailData();
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}

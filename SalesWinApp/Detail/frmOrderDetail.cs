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
using Castle.Core.Internal;

namespace SalesWinApp.Management
{
    public partial class frmOrderDetail : Form
    {
        public bool IsAdmin { get; set; }
        public int? orderId { get; set; }
        public IRepository<OrderObject> orderRepository = new OrderRepository();
        public IRepository<OrderDetailsObject> orderDetailRepository = new OrderDetailsRepository();
        public IRepository<MemberObject> memberRepository = new MemberRepository();
        public List<OrderDetailsObject> source = new List<OrderDetailsObject>();

        public frmOrderDetail()
        {
            InitializeComponent();
        }

        void LoadList()
        {
            var members = memberRepository.GetAll().ToList();
            cbMember.Items.AddRange(members.ToArray());

            if (orderId != null && source.Count() == 0)
            {
                var order = orderRepository.GetById(orderId ?? 0);
                txtOrderID.Text = order.OrderId.ToString();
                cbMember.Text = order.Member.ToString();
                txtOrderDate.Text = order.OrderDate.ToString("dd/MM/yyyy HH:mm");
                txtRequiredDate.Text = order.RequiredDate?.ToString("dd/MM/yyyy HH:mm");
                txtShippedDate.Text = order.ShippedDate?.ToString("dd/MM/yyyy HH:mm");
                txtFreight.Text = order.Freight.ToString();

                source = orderDetailRepository.GetByConditions(od => od.OrderId == orderId).ToList();
            }
            else
            {
                txtOrderDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            }

            var bindingSource = new BindingList<OrderDetailsObject>(source);
            dgvOrderDetailList.DataSource = bindingSource;
            dgvOrderDetailList.Columns[5].Visible = false;
            dgvOrderDetailList.Columns[0].Visible = false;
            dgvOrderDetailList.Columns[1].Visible = false;

            dgvOrderDetailList.Columns[6].DisplayIndex = 0;

            btnDelete.Enabled = source.Count() > 0;

            if (!IsAdmin)
            {
                cbMember.Enabled = false;
                txtRequiredDate.Enabled = false;
                txtShippedDate.Enabled = false;
                txtFreight.Enabled = false;
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmOrderDetailsDetail detail = new frmOrderDetailsDetail()
            {
                orderId = orderId ?? 0,
                orderListSource = source
            };
            detail.ShowDialog(this);
            LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderId != null)
                {
                    var productId = Convert.ToInt32(dgvOrderDetailList.SelectedCells[1].Value);
                    var orderDetail = ((IOrderDetailsRepository)orderDetailRepository).GetByKey((int)orderId, productId);
                    ((IOrderDetailsRepository)orderDetailRepository).DeleteByEntity(orderDetail);
                }
                else
                {
                    var productId = Convert.ToInt32(dgvOrderDetailList.SelectedCells[1].Value);
                    var orderDetail = source.SingleOrDefault(o => o.ProductId == productId);
                    source.Remove(orderDetail);
                }

                MessageBox.Show("Delete order detail success", "Delete");
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete fail");
            }
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsAdmin)
            {
                frmOrderDetailsDetail detail = new frmOrderDetailsDetail()
                {
                    orderId = orderId ?? 0,
                    productId = Convert.ToInt32(dgvOrderDetailList.SelectedCells[0].Value),
                    orderListSource = source
                };
                detail.ShowDialog();
                LoadList();
            }   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var convertRequiredDate = DateTime.TryParseExact(txtRequiredDate.Text, "dd/MM/yyyy HH:mm", null,
                                                                    System.Globalization.DateTimeStyles.None, out var requiredDate);
                var convertShippedDate = DateTime.TryParseExact(txtShippedDate.Text, "dd/MM/yyyy HH:mm", null,
                                                                    System.Globalization.DateTimeStyles.None, out var shippedDate);

                var order = new OrderObject()
                {
                    OrderId = orderId == null ? 0 : Convert.ToInt32(txtOrderID.Text),
                    MemberId = ((MemberObject)cbMember.SelectedItem).MemberId,
                    OrderDate = DateTime.ParseExact(txtOrderDate.Text, "dd/MM/yyyy HH:mm", null),
                    RequiredDate = convertRequiredDate ? requiredDate : null,
                    ShippedDate = convertShippedDate ? shippedDate : null,
                    Freight = txtFreight.Text.IsNullOrEmpty() ? null : Convert.ToInt32(txtFreight.Text)
                };

                if (orderId == null)
                {
                    orderId = orderRepository.Create(order);

                    foreach (var orderDetail in source)
                    {
                        orderDetail.OrderId = (int)orderId;
                        orderDetailRepository.Create(orderDetail);
                    }
                }
                else
                {
                    orderRepository.Update(order);

                    foreach (var orderDetail in source)
                    {
                        var orderDetailInDatabase = ((IOrderDetailsRepository)orderDetailRepository)
                                                        .GetByKey(orderDetail.OrderId, orderDetail.ProductId);

                        if (orderDetailInDatabase != null)
                        {
                            orderDetailRepository.Update(orderDetail);
                        }
                        else
                        {
                            orderDetailRepository.Create(orderDetail);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
            }
        }
    }
}

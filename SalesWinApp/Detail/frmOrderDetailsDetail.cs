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
using SalesWinApp.Management;

namespace SalesWinApp.Detail
{
    public partial class frmOrderDetailsDetail : Form
    {
        IRepository<OrderDetailsObject> _orderDetailRepo = new OrderDetailsRepository();
        IRepository<ProductObject> _productRepo = new ProductRepository();
        public int orderId { get; set; }
        public int? productId { get; set; }
        public List<OrderDetailsObject> orderListSource;

        public frmOrderDetailsDetail()
        {
            InitializeComponent();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            var products = _productRepo.GetByConditions(p => p.UnitslnStock > 0).ToList();
            foreach (var product in products)
            {
                cbProducts.Items.Add(product);
                cbProducts.DisplayMember = "ProductName";
            }

            if (!(productId == null))
            {
                var entity = orderListSource.SingleOrDefault(o => o.ProductId == productId);
                txtOrderID.Text = entity.OrderId.ToString();
                cbProducts.Text = entity.ProductObject.ProductName.ToString();
                txtQuantity.Text = entity.Quantity.ToString();
                txtUnitPrice.Text = entity.UnitPrice.ToString();
                txtDiscount.Text = entity.Discount.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var discount = float.Parse(txtDiscount.Text);

                if (discount > 100)
                {
                    throw new Exception("Discount is invalid");
                }

                var orderDetail = new OrderDetailsObject()
                {
                    OrderId = orderId,
                    ProductId = (cbProducts.SelectedItem as ProductObject).ProductId,
                    ProductObject = cbProducts.SelectedItem as ProductObject,
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    Discount = discount
                };

                var entity = orderListSource.SingleOrDefault(o => o.ProductId == orderDetail.ProductId);

                if (productId == null)
                {
                    if(entity != null)
                    {
                        throw new Exception("This product was exist in order");
                    }

                    orderListSource.Add(orderDetail);
                }
                else
                {
                    var index = orderListSource.IndexOf(entity);
                    orderListSource[index] = orderDetail;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Details");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedProduct = cbProducts.SelectedItem as ProductObject;
            txtUnitPrice.Text = selectedProduct.UnitPrice.ToString();
        }
    }
}

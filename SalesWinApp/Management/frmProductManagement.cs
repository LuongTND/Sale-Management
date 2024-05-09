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
    public partial class frmProductManagement : Form
    {
        public IRepository<ProductObject> productRepository = new ProductRepository();
        public BindingSource source = new BindingSource();

        public frmProductManagement()
        {
            InitializeComponent();
        }

        void LoadList()
        {
            source.DataSource = productRepository.GetAll().ToList();
            txtProductID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtCategory.DataBindings.Clear();
            txtWeight.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtUnitInStock.DataBindings.Clear();

            txtProductID.DataBindings.Add("Text", source, "ProductId");
            txtProductName.DataBindings.Add("Text", source, "ProductName");
            txtCategory.DataBindings.Add("Text", source, "Category.CategoryName");
            txtWeight.DataBindings.Add("Text", source, "Weight");
            txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
            txtUnitInStock.DataBindings.Add("Text", source, "UnitslnStock");

            dgvProductList.DataSource = source;
            dgvProductList.Columns[1].Visible = false;
            dgvProductList.Columns[7].Visible = false;

            btnDelete.Enabled = source.Count > 0;
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductDetail productDetail = new frmProductDetail();
            productDetail.ShowDialog();
            LoadList();
            source.Position = source.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(txtProductID.Text);
                productRepository.Delete(id);
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
            frmProductDetail frmProductDetail = new frmProductDetail()
            {
                productId = Convert.ToInt32(txtProductID.Text)
            };
            frmProductDetail.ShowDialog();
            LoadList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var key = txtSearch.Text;

            source.DataSource = productRepository.GetByConditions(m =>
                (m.ProductId.ToString() +
                m.ProductName +
                m.Category.CategoryName +
                m.Weight +
                m.UnitPrice +
                m.UnitslnStock).Contains(key)
            ).ToList();
        }
    }
}

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
    public partial class frmProductDetail : Form
    {
        IRepository<ProductObject> _productRepo = new ProductRepository();
        IRepository<CategoryObject> _categoryRepo = new CategoryRepository();
        public int? productId { get; set; }

        public frmProductDetail()
        {
            InitializeComponent();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            var categories = _categoryRepo.GetAll();

            foreach (var category in categories)
            {
                cbCategory.Items.Add(category);
            }

            if (!(productId == null))
            {
                var entity = _productRepo.GetById((int)productId);
                txtProductID.Text = entity.ProductId.ToString();
                txtProductName.Text = entity.ProductName;
                txtWeight.Text = entity.Weight;
                cbCategory.Text = entity.Category.CategoryName;
                txtUnitPrice.Text = entity.UnitPrice.ToString();
                txtUnitsInStock.Text = entity.UnitslnStock.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var entity = new ProductObject()
                {
                    ProductId = productId == null ? 0 : Convert.ToInt32(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    CategoryId = Convert.ToInt32((cbCategory.SelectedItem as CategoryObject).CategoryId),
                    Weight = txtWeight.Text,
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    UnitslnStock = Convert.ToInt16(txtUnitsInStock.Text)
                };

                if (productId == null)
                {
                    _productRepo.Create(entity);
                }
                else
                {
                    _productRepo.Update(entity);
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

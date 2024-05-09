using SalesWinApp.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        internal bool IsAdmin = false;
        internal int? AccountId { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tsmiProducts.Enabled = IsAdmin;
        }

        private void tsmiMembers_Click(object sender, EventArgs e)
        {
            frmMemberManagement memberManagement = new frmMemberManagement()
            {
                IsAdmin = IsAdmin,
                AccountId = AccountId
            };
            memberManagement.MdiParent = this;
            memberManagement.Show();
        }

        private void tsmiProducts_Click(object sender, EventArgs e)
        {
            frmProductManagement productManagement = new frmProductManagement();
            productManagement.MdiParent = this;
            productManagement.Show();
        }

        private void tsmiOrders_Click(object sender, EventArgs e)
        {
            frmOrderManagement orderManagement = new frmOrderManagement()
            {
                IsAdmin = IsAdmin,
                AccountId = AccountId
            };
            orderManagement.MdiParent = this;
            orderManagement.Show();
        }

        private void tsmiSales_Click(object sender, EventArgs e)
        {
            frmOrderReport orderReport = new frmOrderReport()
            {
                IsAdmin = IsAdmin,
                AccountId = AccountId
            };
            orderReport.MdiParent = this;
            orderReport.Show();
        }
    }
}

using BussinessObject;
using DataAccess;
using DataAccess.Repository;
using DataAccess.Repository.Implement;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        IRepository<MemberObject> _memberRepo = new MemberRepository(); 

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var config = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", true, true)
                            .Build();

            var email = txtEmail.Text;
            var password = txtPassword.Text;

            if (email == config["AdminAccount:email"] 
                && password == config["AdminAccount:password"])
            {
                Hide();

                frmMain main = new frmMain()
                {
                    IsAdmin = true
                };

                main.ShowDialog();
                return;
            }

            var member = _memberRepo.GetByConditions(m =>
                            m.Email == email && m.Password == password);


            if (member.Count() > 0) 
            {
                Hide();

                frmMain main = new frmMain()
                {
                    IsAdmin = false,
                    AccountId = member.First().MemberId
                };

                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email or Password is wrong", "Danger");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

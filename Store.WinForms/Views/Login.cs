using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using Store.Services;

namespace Store.WinForms.Views
{
    public partial class Login : Form
    {
        private readonly IUserService _userService;

        public Login(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var user = _userService.Get(username, password);

            if (user != null)
            {
                MessageBox.Show("Customer Found");
                Hide();
                //CustomerRegistration = Unity.UnityContainer.Resolve<CustomerRegistration>;
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
            //var user = _userService.GetById(1);


            //if (user != null)
            //{
            //    MessageBox.Show("Customer Found");
            //}



        }
    }
}

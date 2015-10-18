using System;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using Store.Services;

namespace Store.WinForms.Views
{
    public partial class Login : Form
    {
        private readonly IUserService _userService;

        public Login()
        {
            InitializeComponent();
        }

        public Login(IUserService userService) : this()
        {
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
                
                var form = Unity.UnityContainer.Resolve<ProductMaintenance>();
                form.Show();

            }
            else
            {
                MessageBox.Show("Username or Password is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

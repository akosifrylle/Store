using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.Common;
using Store.Services;

namespace Store.WinForms.Views
{
    public partial class CustomerRegistration : Form
    {
        private readonly IUserService _customerService;

        public CustomerRegistration(IUserService customerService)
        {
            InitializeComponent();
            this._customerService = customerService;
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var user = new User()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                RegisteredDate = DateTime.Now
            };

            this._customerService.Add(user);
        }

    }
}

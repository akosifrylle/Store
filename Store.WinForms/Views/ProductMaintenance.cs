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
    public partial class ProductMaintenance : Form
    {
        private readonly IProductService _productService;

        public ProductMaintenance()
        {
            InitializeComponent();
        }

        public ProductMaintenance(IProductService productService) : this()
        {
            _productService = productService;

            dgvProducts.DataSource = _productService.GetProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product1 = new Product()
            {
                Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                Description = "Very slow iphone fucking shit",
                Price = 240.25m,
                Stock = 100
            };

            var product2 = new Product()
            {
                Name = "Iphone6s",
                Description = "Super good",
                Price = 240.25m,
                Stock = 100
            };

            var products = new List<Product>();

            products.Add(product1);
            products.Add(product2);

            _productService.AddProducts(products);;
        }
    }
}

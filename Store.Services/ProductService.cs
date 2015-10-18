using System.Collections.Generic;
using Store.Common;
using Store.Data;
using Store.NHibernate;

namespace Store.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductDao _productDao;

        public ProductService(IProductDao productDao)
        {
            _productDao = productDao;
        }

        public Product AddProduct(Product product)
        {
            return _productDao.Add(product);
        }

        public void AddStock(int id, int quantity)
        {
            _productDao.AddStock(id, quantity);
        }

        public void DeleteProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Product> GetProducts()
        {
            return _productDao.GetList();
        }

        public void AddProducts(IList<Product> products)
        {
            _productDao.Add(products);
        }
    }
}

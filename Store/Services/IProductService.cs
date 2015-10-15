using System.Collections.Generic;
using Store.Common;
using Store.Common;

namespace Store.Services
{
    public interface IProductService
    {
        Product AddProduct(Product product);
        void AddProducts(IList<Product> products);
        void AddStock(int id, int quantity);
        void DeleteProduct(int id);
        Product GetProductById(int id);
        IList<Product> GetProducts();
    }
}

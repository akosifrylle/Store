using System.Collections.Generic;
using Store.Entities;

namespace Store.Services
{
    public interface IProductService
    {
        Product AddProduct(Product product);
        void AddStock(int id, int quantity);
        void DeleteProduct(int id);
        Product GetProductById(int id);
        IList<Product> GetProducts();
    }
}

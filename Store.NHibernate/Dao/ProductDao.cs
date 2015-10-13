using System.Collections.Generic;
using Store.Data;
using Store.Entities;

namespace Store.NHibernate.Dao
{
    public class ProductDao : IProductDao
    {
        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product Add(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public void AddStock(int id, int quantity)
        {
            throw new System.NotImplementedException();
        }

        public IList<Product> GetList()
        {
            throw new System.NotImplementedException();
        }
    }
}
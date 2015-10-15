using System.Collections.Generic;
using AutoMapper;
using Store.Common;
using Store.Data;
using Store.NHibernate.Repo;

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
            var productRepo = Mapper.Map<ProductRepo>(product);

            using (var session = NHibernateHelper.OpenSession())
            {
                session.BeginTransaction();

                session.Save(productRepo);
                session.Transaction.Commit();
            }

            return product;
        }

        public void Add(IList<Product> products)
        {
            var productsRepo = Mapper.Map<IList<ProductRepo>>(products);
            using (var session = NHibernateHelper.OpenSession())
            {
                session.BeginTransaction();

                session.Save(productsRepo);
                session.Transaction.Commit();
            }
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
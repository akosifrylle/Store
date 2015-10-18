using System;
using System.Collections;
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
            using (var session = NHibernateHelper.OpenSession())
            {
                return Mapper.Map<Product>(session.Get<ProductRepo>(id));
            }
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
                foreach (var product in productsRepo)
                {
                    try
                    {
                        session.Save(product);
                        session.Transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        session.Transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Delete(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var product = session.Get<ProductRepo>(id);

                if (product != null)
                {
                    session.BeginTransaction();
                    session.Delete(product);
                }
            }
        }

        public void AddStock(int id, int quantity)
        {
            throw new System.NotImplementedException();
        }

        public IList<Product> GetList()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return Mapper.Map<IList<Product>>(session.QueryOver<ProductRepo>().List());
            }
        }
    }
}
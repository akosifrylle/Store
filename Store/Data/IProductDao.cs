using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Common;
using Store.Common;

namespace Store.Data
{
    public interface IProductDao
    {
        Product GetById(int id);
        Product Add(Product product);
        void Delete(int id);
        void AddStock(int id, int quantity);
        IList<Product> GetList();
    }
}

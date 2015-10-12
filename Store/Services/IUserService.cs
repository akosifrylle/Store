using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Entities;

namespace Store.Services
{
    public interface IUserService
    {
        User Add(User customer);
        void Delete(User customer);
        User Get(string username, string password);
        User GetById(int id);
    }
}

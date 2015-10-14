using System;
using Store.Data;
using Store.Common;

namespace Store.Services
{
    public class UserService : IUserService
    {
        private readonly IUserDao _userDao;

        public UserService(IUserDao customerDao)
        {
            _userDao = customerDao;
        }

        public UserService() { }

        public User Add(User user)
        {
            return _userDao.Add(user);
        }

        public void Delete(User user)
        {
            _userDao.Delete(user);
            throw new NotImplementedException();
        }

        public User Get(string username, string password)
        {
            return _userDao.Get(username, password);
        }

        public User GetById(int id)
        {
            return _userDao.GetById(id);
        }
    }
}

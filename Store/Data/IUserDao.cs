using Store.Entities;

namespace Store.Data
{
    public interface IUserDao
    {
        User Add(User user);
        void Delete(User user);
        User Get(string username, string password);
        User GetById(int id);
    }
}

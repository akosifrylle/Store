using System;
using System.Linq;
using AutoMapper;
using Store.Data;
using Store.Entities;
using Store.NHibernate.Repo;

namespace Store.NHibernate.Dao
{
    public class UserDao : IUserDao
    {
        public User Add(User user)
        {
            var userRepo = Mapper.Map<UserRepo>(user);
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(userRepo);
                    transaction.Commit();
                }
            }
            return Mapper.Map<User>(userRepo);
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }


        public User Get(string username, string password)
        {
            
            using (var session = NHibernateHelper.OpenSession())
            {
                //Using QueryOver
                var user = session.QueryOver<UserRepo>()
                    .Where(u => u.Username == username && u.Password == password).List().FirstOrDefault();

                //Using HQL
                //var user = session.CreateQuery("from User u where u.FirstName=:un")
                    //.SetString("un", "Frylle").List<UserRepo>();
                return Mapper.Map<User>(user);
            }
        }

        public User GetById(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return Mapper.Map<User>(session.Get<UserRepo>(id));
            }
        }
    }
}

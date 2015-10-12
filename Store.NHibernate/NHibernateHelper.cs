using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using Store.NHibernate.Repo;

namespace Store.NHibernate
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory();

                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                    //.ConnectionString(@"Server=.\SQLExpress;Initial Catalog=NhibernateSample;User=sa;Password=sql")
                    .ConnectionString(c => c.FromConnectionStringWithKey("store-db"))
                    .ShowSql()
                )
                .Mappings(
                    m => m.FluentMappings.AddFromAssemblyOf<UserMap>()
                )
                .BuildSessionFactory();
            //var mappingAssembly = Assembly.Load("Store.NHibernate.SqlServer");

        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}

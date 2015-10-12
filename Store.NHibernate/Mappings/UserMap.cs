using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Store.NHibernate.Repo;

namespace Store.NHibernate
{
    public class UserMap : ClassMap<UserRepo>
    {
        public UserMap()
        {
            Table("[User]");
            Id(x => x.Id)
                .GeneratedBy.Identity();
            Map(x => x.FirstName).Length(50)
                .Not.Nullable();
            Map(x => x.LastName).Length(50)
                .Not.Nullable();
            Map(x => x.Username).Length(50)
                .Not.Nullable();
            Map(x => x.Password).Length(50)
                .Not.Nullable();
            Map(x => x.RegisteredDate).CustomType("date")
                .Not.Nullable();
        }
    }
}

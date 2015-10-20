using FluentNHibernate.Mapping;
using Store.NHibernate.Repo;

namespace Store.NHibernate.Mappings
{
    public class OrderMap : ClassMap<OrderRepo>
    {
        public OrderMap()
        {
            Id(x => x.Id)
                .GeneratedBy.Identity();
            Map(x => x.OrderDate)
                .CustomType("datetime").Not.Nullable();
            References(x => x.User)
                .Column("UserId")
                .Cascade.All();
        }
    }
}

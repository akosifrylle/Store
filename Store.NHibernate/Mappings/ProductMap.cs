using FluentNHibernate.Mapping;
using Store.NHibernate.Repo;

namespace Store.NHibernate.Mappings
{
    public class ProductMap : ClassMap<ProductRepo>
    {
        public ProductMap()
        {
            Table("Product");
            Id(x => x.Id)
                .GeneratedBy.Identity();
            Map(x => x.Name)
                .Length(20).Not.Nullable();
            Map(x => x.Description)
                .Length(50).Nullable();
            Map(x => x.Price)
                .CustomType("decimal").Precision(18).Scale(2);
            Map(x => x.Stock)
                .CustomType("int");
        }
    }
}
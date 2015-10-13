namespace Store.NHibernate.Repo
{
    public class ProductRepo
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual int Stock { get; set; }
    }
}

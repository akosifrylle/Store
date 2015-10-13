using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Store.Entities;
using Store.NHibernate.Repo;

namespace Store.NHibernate
{
    public class NHRepoAutoMapperProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<User, UserRepo>();
            Mapper.CreateMap<UserRepo, User>();
            Mapper.CreateMap<Product, ProductRepo>();
            Mapper.CreateMap<ProductRepo, Product>();
        }
    }
}

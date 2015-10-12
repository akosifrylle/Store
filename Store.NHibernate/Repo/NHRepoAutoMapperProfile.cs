using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Store.Entities;

namespace Store.NHibernate.Repo
{
    public class NHRepoAutoMapperProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<User, UserRepo>();
            Mapper.CreateMap<UserRepo, User>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Store.NHibernate.Repo;

namespace Store.NHibernate
{
    public static class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(config => 
            {
                config.AddProfile<NHRepoAutoMapperProfile>();
            });
        }
    }
}

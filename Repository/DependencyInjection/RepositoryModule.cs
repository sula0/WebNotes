﻿using Ninject.Modules;
using Repository.Common;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Common;
using AutoMapper;
using Ninject;
using Repository.Mapping;

namespace Repository.DependencyInjection
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<INoteRepository>().To<NoteRepository>();
            Bind<ICategoryRepository>().To<CategoryRepository>();
            Bind<IUnitOfWork>().To<UnitOfWork>();

            Mapper.Initialize(cfg =>
            {
                cfg.ConstructServicesUsing(t => Kernel.Get(t));

                cfg.AddProfile<NoteMapperProfile>();
                cfg.AddProfile<CategoryMapperProfile>();
            });
        }
    }
}

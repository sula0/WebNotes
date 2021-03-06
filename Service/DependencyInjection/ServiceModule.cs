﻿using Ninject.Modules;
using Service;
using Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DependencyInjection
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<INoteService>().To<NoteService>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using System.Reflection;

namespace BlogApp.Admin.Modules
{
    public class DAOModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("BlogApp.Dapper.DAO"))
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
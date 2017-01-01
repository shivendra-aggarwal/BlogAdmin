using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using BlogApp.DAO.BlogContext;
using System.Data.Entity;
using BlogApp.DAO.UnitOfWork.Interface;
using BlogApp.DAO.UnitOfWork;

namespace BlogApp.Admin.Modules
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new DAOModule());

            builder.RegisterType(typeof(BlogContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();
        }
    }
}
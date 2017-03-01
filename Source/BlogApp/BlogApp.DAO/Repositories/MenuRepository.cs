using BlogApp.DAO.Interfaces;
using BlogApp.Model.FeatureManagement;
using BlogApp.Model.MenuManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAO.Repositories
{
    public class MenuRepository : GenericRepository<Menu>, IMenuRepository
    {
        public MenuRepository(DbContext blogContext)
            : base(blogContext)
        {

        }
    }
}

using BlogApp.DAO.Interfaces;
using BlogApp.Model.MenuManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Dapper.DAO.Repositories
{
    public class MenuRepository : GenericRepository<Menu>, IMenuRepository
    {
        public MenuRepository() 
            : base("Menu")
        {
        }
    }
}

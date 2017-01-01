using BlogApp.DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAO.Repositories
{
    public class BlogAppContext : DbContext, IBlogAppContext
    {
        public BlogAppContext()
            : base("")
        {

        }
    }
}

using BlogApp.DAO.Interfaces;
using BlogApp.Model.FeatureManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAO.Repositories
{
    public class FeatureTypeRepository : GenericRepository<FeatureType>, IFeatureTypeRepository
    {
        public FeatureTypeRepository(DbContext blogContext)
            : base(blogContext)
        {

        }
    }
}

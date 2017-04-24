using BlogApp.DAO.Interfaces;
using BlogApp.Model.FeatureManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Dapper.DAO.Repositories
{
    public class FeatureRepository : GenericRepository<Feature>, IFeatureRepository
    {
        public FeatureRepository()
            : base("Feature")
        {

        }
    }
}

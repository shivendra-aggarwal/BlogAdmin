using BlogApp.Common.Database;
using BlogApp.Model.FeatureManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAO.Configurations
{
    public class FeatureConfiguration : EntityTypeConfiguration<Feature>
    {
        public FeatureConfiguration()
        {
            ToTable(Table.Feature, DBSchema.FEATURE);

            HasKey(t => t.Identifier);
        }
    }
}

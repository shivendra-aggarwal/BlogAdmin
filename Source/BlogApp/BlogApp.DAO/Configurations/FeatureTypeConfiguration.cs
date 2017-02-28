using BlogApp.Common.Database;
using BlogApp.Model.FeatureManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAO.Configurations
{
    public class FeatureTypeConfiguration : EntityTypeConfiguration<FeatureType>
    {
        public FeatureTypeConfiguration()
        {
            ToTable(Table.FeatureType, DBSchema.FEATURE);

            HasKey(t => t.Identifier);

            Property(t => t.FeatureTypeName).
                HasMaxLength(200).
                IsRequired().
                HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute("IX_FeatureName", 2) { IsUnique = true }));
        }
    }
}

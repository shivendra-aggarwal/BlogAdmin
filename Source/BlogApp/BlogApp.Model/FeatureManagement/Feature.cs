using BlogApp.Model.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Model.FeatureManagement
{
    public class Feature : AuditableEntity
    {
        public string FeatureName { get; set; }

        public string FeatureDescription { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime? CompletedOn { get; set; }

        public DateTime? StartedOn { get; set; }

        public bool IsActive { get; set; }

        public string DocUrl { get; set; }

        public string ImageUrl { get; set; }

        public int FeatureTypeId { get; set; }

        public int ProjectId { get; set; }

        public FeatureType FeatureType { get; set; }

        
    }
}

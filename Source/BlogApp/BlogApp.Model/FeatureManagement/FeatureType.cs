using BlogApp.Model.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Model.FeatureManagement
{
    public class FeatureType : BaseEntity
    {
        public string FeatureName { get; set; }
    }
}

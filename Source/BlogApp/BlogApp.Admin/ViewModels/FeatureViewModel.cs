using BlogApp.Model.FeatureManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BlogApp.Admin.ViewModels
{
    public class FeatureViewModel : AbstractViewModel<Feature, FeatureViewModel>
    {

        #region Properties
        [DisplayName("Feature Name")]
        public string FeatureName { get; set; }

        [DisplayName("Details")]
        public string FeatureDescription { get; set; }

        [DisplayName("Completed")]
        public bool IsCompleted { get; set; }

        [DisplayName("Completed On")]
        public DateTime? CompletedOn { get; set; }

        [DisplayName("Started On")]
        public DateTime? StartedOn { get; set; }

        [DisplayName("Active")]
        public bool IsActive { get; set; }

        [DisplayName("Feature Type")]
        public string FeatureTypeName { get; set; }

        [DisplayName("Project")]
        public string ProjectTitle { get; set; }
        #endregion


    }
}
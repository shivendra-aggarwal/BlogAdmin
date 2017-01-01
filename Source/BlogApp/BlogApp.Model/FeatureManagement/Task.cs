using BlogApp.Model.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Model.FeatureManagement
{
    public class Task : AuditableEntity
    {
        public string TaskName { get; set; }

        public string TaskDescription { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime? CompletedOn { get; set; }

        public DateTime? StartedOn { get; set; }

        public int FeatureId { get; set; }

        public int TaskTypeId { get; set; }
    }
}

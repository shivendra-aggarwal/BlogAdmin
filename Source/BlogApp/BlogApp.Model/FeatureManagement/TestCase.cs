using BlogApp.Model.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Model.FeatureManagement
{
    public class TestCase : AuditableEntity
    {
        public string TestCaseName { get; set; }

        public string TestCaseDescription { get; set; }

        public int TaskId { get; set; }

        public int TestCaseStatusId { get; set; }
    }
}

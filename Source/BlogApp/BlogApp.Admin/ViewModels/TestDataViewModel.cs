using BlogApp.Model.TestData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BlogApp.Admin.ViewModels
{
    public class TestDataViewModel : AbstractViewModel<Table, TestDataViewModel>
    {
        #region Properties

        [DisplayName("Module Names")]
        public string Name { get; set; }

        #endregion
    }
}
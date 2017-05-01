using BlogApp.Admin.CommonControllers;
using BlogApp.Admin.ViewModels;
using BlogApp.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Admin.Controllers
{
    public class TestDataController : BaseController
    {
        ITestDataService _testDataService;

        public TestDataController(ITestDataService testDataService)
            :base("Test Data")
        {
            _testDataService = testDataService;
        }

        public ActionResult GetModules()
        {
            return View(TestDataViewModel.GetListOfViewModel(_testDataService.GetAllSystemTables().ToArray()));

        }
    }
}

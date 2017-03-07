using BlogApp.Admin.CommonControllers;
using BlogApp.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        IMenuService _menuService;
        public DashboardController(IMenuService menuService)
            : base("Dashboard")
        {
            _menuService = menuService;
        }

        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }


        //[ChildActionOnly]
        //public ActionResult GetMenus()
        //{
        //    return PartialView(_menuService.GetAll());
        //}
    }
}
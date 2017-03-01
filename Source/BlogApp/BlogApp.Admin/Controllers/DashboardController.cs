using BlogApp.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Admin.Controllers
{
    public class DashboardController : Controller
    {
        IMenuService _menuService;

        public DashboardController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        // GET: Dashboard
        public ActionResult Index()
        {
            return View(_menuService.GetAll());
        }
    }
}
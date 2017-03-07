using BlogApp.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Admin.Controllers
{
    public class MenuController : Controller
    {
        IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        // GET: Dashboard
        [ChildActionOnly]
        public ActionResult GetMenus()
        {
            return PartialView(_menuService.GetAll());
        }
    }
}
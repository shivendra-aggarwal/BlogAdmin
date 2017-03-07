using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Admin.CommonControllers
{
    public class BaseController : Controller
    {
        public BaseController(string controllerName)
        {
            ViewBag.Title = controllerName;
        }
    }
}
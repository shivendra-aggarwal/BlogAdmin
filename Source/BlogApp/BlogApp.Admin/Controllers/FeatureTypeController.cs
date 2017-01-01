using BlogApp.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Admin.Controllers
{
    public class FeatureTypeController : Controller
    {
        IFeatureTypeService _featureTypeService;

        public FeatureTypeController(IFeatureTypeService featureTypeService)
        {
            _featureTypeService = featureTypeService;
        }

        // GET: FeatureType
        public ActionResult Index()
        {
            return View(_featureTypeService.GetAll());
        }
    }
}
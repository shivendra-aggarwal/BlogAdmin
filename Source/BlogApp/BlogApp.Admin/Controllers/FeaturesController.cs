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
    public class FeaturesController : BaseController
    {
        IFeatureService _featureService;

        public FeaturesController(IFeatureService featureService)
            : base("Feature")
        {
            _featureService = featureService;
        }

        // GET: FeatureType
        public ActionResult Index()
        {
            return View(FeatureViewModel.GetListOfViewModel(_featureService.GetAll().ToArray()));
        }
    }
}
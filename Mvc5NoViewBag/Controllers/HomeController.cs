using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc5NoViewBag.Models;

namespace Mvc5NoViewBag.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            BasePageViewModel model = new BasePageViewModel("Home Page");
            return View(model);
        }

        public ActionResult About()
        {
            AboutPageViewModel model = new AboutPageViewModel();
            return View(model);
        }

        public ActionResult Contact()
        {
            ContactPageViewModel model = new ContactPageViewModel();
            return View(model);
        }
    }
}
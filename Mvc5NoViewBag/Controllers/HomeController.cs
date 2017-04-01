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
            return View();
        }

        public ActionResult About()
        {
            AboutPageViewModel model = new AboutPageViewModel
            {
                Message = "Your application description page."
            };
            return View(model);
        }

        public ActionResult Contact()
        {
            ContactPageViewModel model = new ContactPageViewModel
            {
                Message = "Your contact page."
            };
            return View(model);
        }
    }
}
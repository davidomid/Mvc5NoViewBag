using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5NoViewBag.Controllers
{
    public class BaseController : Controller
    {
        [Obsolete("If you use the ViewBag, you deserve to be stabbed.", true)]
        public new object ViewBag { get; set; }
    }
}
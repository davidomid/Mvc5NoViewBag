using System;
using System.Web.Mvc;

namespace Mvc5NoViewBag.Models
{
    public abstract class BaseWebViewPage<T> : WebViewPage<T>
    {
        [Obsolete("Thought you could get away with using this in a Razor view? Nice try, sucker :)", true)]
        public new dynamic ViewBag { get; set; }
    }

    public abstract class BaseWebViewPage : BaseWebViewPage<dynamic>
    {

    }
}
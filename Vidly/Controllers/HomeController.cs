using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        [OutputCache]
        public ActionResult Index()
        {
            return View();
        }

    }
}
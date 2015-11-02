using createguid.de.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace createguid.de.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();
            model.Guid = Guid.NewGuid();
            return View(model);
        }
    }
}
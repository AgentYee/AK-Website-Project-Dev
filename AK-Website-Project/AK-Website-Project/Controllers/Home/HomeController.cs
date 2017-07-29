using AK_Website_Project.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AK_Website_Project.Controllers.Home
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HomeViewModel HomeViewM = new HomeViewModel();
            return View();
        }
    }
}
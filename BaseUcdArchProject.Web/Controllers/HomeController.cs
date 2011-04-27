using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UCDArch.Web.Attributes;
using BaseUcdArchProject.Core;

namespace BaseUcdArchProject.Web.Controllers
{
    [HandleTransactionsManually]
    public class HomeController : ApplicationController
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            var o = Repository.OfType<Order>().GetAll();


            return View();
        }
    }
}

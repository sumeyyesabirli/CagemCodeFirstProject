using CagemCodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CagemCodeFirstProject.Controllers
{
    public class ErrorPageController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Page404()
        {
            return View();
        }
    }
}
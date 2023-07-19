using CagemCodeFirstProject.DAL.Context;
using CagemCodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CagemCodeFirstProject.Controllers
{
    public class ContactController : Controller
    {
        TravelContext travelContext = new TravelContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact p)
        {
            travelContext.Contacts.Add(p);
            p.MessageDate = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy"));
            travelContext.SaveChanges();

            return RedirectToAction("Index", "Default");
        }
    }
}
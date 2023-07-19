using CagemCodeFirstProject.DAL.Context;
using CagemCodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CagemCodeFirstProject.Controllers
{
   
     
     public class AdminIletisimController : Controller
     {
         TravelContext travelContext = new TravelContext();

         [HttpGet]
         public ActionResult Index()
         {
             var values = travelContext.FooterContacts.FirstOrDefault();
             return View(values);
         }

         [HttpPost]
         public ActionResult Index(FooterContact p)
         {
             var value = travelContext.FooterContacts.Find(p.FooterId);
             value.Phone = p.Phone;
             value.Mail = p.Mail;
             value.Address = p.Address;
             value.Icon = p.Icon;
             travelContext.SaveChanges();
             return RedirectToAction("Index");
         }
     }
   
}
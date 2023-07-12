﻿using CagemCodeFirstProject.DAL.Context;
using CagemCodeFirstProject.DAL.Entities;
using System.Linq;
using System.Web.Mvc;

namespace CagemCodeFirstProject.Controllers
{
    [Authorize]
    public class AdminGuidController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Guides.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddGuide(Guide guide)
        {
            travelContext.Guides.Add(guide);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteGuide(int id)
        {
            var value = travelContext.Guides.Find(id);
            travelContext.Guides.Remove(value);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateGuide(int id)
        {
            var value = travelContext.Guides.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateGuide(Guide guide)
        {
            var value = travelContext.Guides.Find(guide.GuideId);
            value.GuideName = guide.GuideName;
            value.GuideTitle = guide.GuideTitle;
            value.GuideImageUrl = guide.GuideImageUrl;
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}

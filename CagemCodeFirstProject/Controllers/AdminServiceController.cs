using CagemCodeFirstProject.DAL.Context;
using CagemCodeFirstProject.DAL.Entities;
using System.Linq;
using System.Web.Mvc;

namespace CagemCodeFirstProject.Controllers
{
    
    public class AdminServiceController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Services.ToList();
            return View(values);
        }

        public ActionResult DeleteAdminService(int id)
        {
            var value = travelContext.Services.Find(id);
            travelContext.Services.Remove(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddAdminService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdminService(Services p)
        {
            travelContext.Services.Add(p);            
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAdminService(int id)
        {
            var value = travelContext.Services.Find(id);

            return View("Index");
        }

        [HttpPost]
        public ActionResult UpdateAdminService(Services p)
        {
            var value = travelContext.Services.Find(p.ServicesId);
            value.Title = p.Title;
            value.Description = p.Description;
            value.Icon = p.Icon;
            travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
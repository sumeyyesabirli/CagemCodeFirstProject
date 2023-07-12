using CagemCodeFirstProject.DAL.Context;
using System.Web.Mvc;

namespace CagemCodeFirstProject.Controllers
{
    public class AdminController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
    }
}
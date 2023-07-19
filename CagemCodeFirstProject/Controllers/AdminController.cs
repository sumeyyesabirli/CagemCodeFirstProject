using CagemCodeFirstProject.DAL.Context;
using System.Web.Mvc;

namespace CagemCodeFirstProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}
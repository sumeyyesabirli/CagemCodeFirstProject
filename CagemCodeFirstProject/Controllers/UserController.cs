using CagemCodeFirstProject.DAL.Context;
using CagemCodeFirstProject.DAL.Entities;
using System.Web.Mvc;

namespace CagemCodeFirstProject.Controllers
{
    public class UserController : Controller
    {
        TravelContext travelContext = new TravelContext();

        public ActionResult Index(User user)
        {
            travelContext.Users.Add(user);
            travelContext.SaveChanges();
            return View();
        }
    }
}
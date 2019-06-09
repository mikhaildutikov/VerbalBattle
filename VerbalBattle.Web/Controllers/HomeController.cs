using System;
using System.Web.Mvc;
using VerbalBattle.Domain;

namespace VerbalBattle.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBattleRepository _repository;

        public HomeController(IBattleRepository repository)
        {
            if (repository == null) throw new ArgumentNullException("repository");

            _repository = repository;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View(_repository.Battles);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

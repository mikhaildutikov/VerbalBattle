using System;
using System.Linq;
using System.Web.Mvc;
using VerbalBattle.Domain;

namespace VerbalBattle.Web.Controllers
{
    public class BattleController : Controller
    {
        private readonly IBattleRepository _battleRepository;

        public BattleController(IBattleRepository battleRepository)
        {
            if (battleRepository == null) throw new ArgumentNullException("battleRepository");
            _battleRepository = battleRepository;
        }

        public ActionResult BattleDetails(Guid id)
        {
            // TODO: exceptions
            var battle = _battleRepository.Battles.Single(b => b.Id == id);

            return View(battle);
        }

        public ActionResult AddBattle()
        {
            // TODO: exceptions
            var battle = new Battle();

            battle.Id = Guid.NewGuid();
            
            _battleRepository.AddBattle(battle);
            _battleRepository.Save();

            return RedirectToAction("BattleDetails", "Battle", new { id = battle.Id });
        }
    }
}
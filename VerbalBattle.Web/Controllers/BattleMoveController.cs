using System;
using System.Linq;
using System.Web.Mvc;
using VerbalBattle.Domain;
using VerbalBattle.Web.Models;

namespace VerbalBattle.Web.Controllers
{
    public class BattleMoveController : Controller
    {
        private readonly IBattleRepository _repository;

        public BattleMoveController(IBattleRepository repository)
        {
            if (repository == null) throw new ArgumentNullException("repository");

            _repository = repository;
        }

        [HttpGet]
        public ActionResult AddMove(Guid battleId)
        {
            var model = new NewBattleMoveViewModel();
            model.BattleId = battleId;

            return View(model);
        }

        [HttpPost]
        public ActionResult AddMove(NewBattleMoveViewModel newMove)
        {
            if (ModelState.IsValid)
            {
                // TODO: exceptions
                var battle = _repository.Battles.Single(b => b.Id == newMove.BattleId);

                var battleMove = new BattleMove();
                battleMove.Order = battle.Verses.Count;
                battleMove.Text = newMove.Text;
                battleMove.Id = Guid.NewGuid();

                battle.Verses.Add(battleMove);

                _repository.Save();

                return RedirectToAction("BattleDetails", "Battle", new { id = battle.Id});
            }

            return View(newMove);
        }
    }
}
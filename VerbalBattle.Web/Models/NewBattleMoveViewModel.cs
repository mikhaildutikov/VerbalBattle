using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VerbalBattle.Web.Models
{
    public class NewBattleMoveViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public Guid BattleId { get; set; }

        [Required]
        public string Text { get; set; }
    }
}
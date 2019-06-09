using System;
using System.Collections.Generic;

namespace VerbalBattle.Domain
{
    public class Battle
    {
        public virtual Guid Id { get; set; }

        public virtual ICollection<BattleMove> Verses { get; set; }
    }
}
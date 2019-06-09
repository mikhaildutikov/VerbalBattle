using System;

namespace VerbalBattle.Domain
{
    public class BattleMove
    {
        public virtual Guid Id { get; set; }

        public virtual string Text { get; set; }

        public virtual int Order { get; set; }
    }
}
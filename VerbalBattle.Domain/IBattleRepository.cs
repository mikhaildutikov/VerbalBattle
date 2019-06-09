using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VerbalBattle.Domain
{
    public interface IBattleRepository
    {
        IQueryable<Battle> Battles { get; }
        void Save();
        void AddBattle(Battle newBattle);
    }
}

using System;
using System.Data.Entity;
using System.Linq;
using VerbalBattle.Domain;

namespace VerbalBattle.Web.Infrastructure
{
    public class BattleDbRepository : DbContext, IBattleRepository
    {
        public DbSet<Battle> Battles { get; set; }

        public BattleDbRepository() : base("DefaultConnection")
        {
        }

        void IBattleRepository.Save()
        {
            SaveChanges();
        }

        void IBattleRepository.AddBattle(Battle newBattle)
        {
            Battles.Add(newBattle);
        }

        IQueryable<Battle> IBattleRepository.Battles
        {
            get { return Battles; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fundamentos
{
    public class Mudkip : Pokemons
    {
        public Mudkip(int level, int healthPoints) : base("Mudkip", level, healthPoints)
        {
        }

        public override void Attack(Pokemons target)
        {
            int damage = 10;
            Console.WriteLine($"{Name} usa Water Gun e causa {damage} de dano!");
            target.HealthPoints -= damage;
        }
    }

}

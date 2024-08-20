using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fundamentos
{

    // Classe para outro tipo de Pokémon - Aron
    public class Aron : Pokemons
    {
        public Aron(int level, int healthPoints) : base("Aron", level, healthPoints)
        {
        }

        public override void Attack(Pokemons target)
        {
            int damage = 8;
            Console.WriteLine($"{Name} usa Metal Claw e causa {damage} de dano!");
            target.HealthPoints -= damage;
        }
    }
}

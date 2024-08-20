using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public abstract class Pokemons
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public int Experience { get; set; }
        public int ExperienceToNextLevel { get; set; }

        public Pokemons(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;
            Experience = 0;
            ExperienceToNextLevel = CalculateExperienceToNextLevel();
        }

        private int CalculateExperienceToNextLevel()
        {
            return Level * 10;
        }

        public void LevelUp()
        {
            Level++;
            Experience = 0;
            ExperienceToNextLevel = CalculateExperienceToNextLevel();
            Console.WriteLine($"{Name} subiu para o nível {Level}!");
        }

        public abstract void Attack(Pokemons target);

        public void GainExperience(int xp)
        {
            Experience += xp;
            Console.WriteLine($"{Name} ganhou {xp} XP!");

            if (Experience >= ExperienceToNextLevel)
            {
                LevelUp();
            }
        }

        // Método de batalha atualizado para continuar até que um Pokémon seja derrotado
        public void Battle(Pokemons opponent)
        {
            Console.WriteLine($"Uma batalha começou entre {Name} e {opponent.Name}!");

            // Loop para continuar a batalha até que a vida de um Pokémon chegue a zero
            while (HealthPoints > 0 && opponent.HealthPoints > 0)
            {
                Console.WriteLine($"{Name} ataca {opponent.Name}!");
                Attack(opponent); // O Pokémon ataca o oponente
                Console.WriteLine("===============================");

                // Verifica se o oponente foi derrotado
                if (opponent.HealthPoints <= 0)
                {
                    Console.WriteLine($"{opponent.Name} foi derrotado!");
                    GainExperience(20); // Exemplo: ganha 20 XP ao derrotar um oponente
                    break;
                }

                // O oponente ataca de volta
                Console.WriteLine($"{opponent.Name} ataca {Name}!");
                opponent.Attack(this);

                // Verifica se o Pokémon foi derrotado
                if (HealthPoints <= 0)
                {
                    Console.WriteLine($"{Name} foi derrotado!");
                    opponent.GainExperience(20); // O oponente ganha 20 XP
                }
            }

            // Determina quem venceu
            if (HealthPoints > 0)
            {
                Console.WriteLine($"{Name} venceu a batalha!");
            }
            else
            {
                Console.WriteLine($"{opponent.Name} venceu a batalha!");
            }
        }
    }
}

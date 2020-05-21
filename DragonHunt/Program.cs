using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace DragonHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            List<Character> characters = new List<Character>();
            Sorcerer sorcerer1 = new Sorcerer("Sorcerer1");
            Sorcerer sorcerer2 = new Sorcerer("Sorcerer2");

            Paladin paladin1 = new Paladin("Paladin1");
            Paladin paladin2 = new Paladin("Paladin2");

            Knight knight1 = new Knight("Knight1");
            Knight knight2 = new Knight("Knight2");

            characters.Add(sorcerer1);
            characters.Add(sorcerer2);
            characters.Add(paladin1);
            characters.Add(paladin2);
            characters.Add(knight1);
            characters.Add(knight2);

            Dragon dragon = new Dragon
            {
                Name = "Dragon",
                Level = 1,
                ExperiencePoints = 0,
                Strength = 20,
                Dexternity = 20,
                Intelligence = 20,
                MaximumHitPoints = 300,
                Damage = 50,
                Defense = 50
            };

            dragon.OnBreatheFire += v => characters.ForEach(k => k.TakeDamage(v));

            dragon.BreatheFire();

            paladin1.IncreaseExperience(50);
            MyExtensions.IncreaseExperience(paladin2, 50);

            var under1Level = characters.Where(v => v.Level > 1).Select(v => new { v.Name, v.Level});

            foreach (var item in under1Level)
            {
                Console.WriteLine($"Imię: {item.Name}, {item.Level}");
            }
        }
    }
}

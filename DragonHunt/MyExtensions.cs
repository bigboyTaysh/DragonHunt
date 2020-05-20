using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonHunt
{
    static class MyExtensions
    {
        public static void DrinkPotionOfFullHealing(this Character character)
        {
            character.HitPoints = character.MaximumHitPoints;
        }

        public static bool IsDead(this Character character)
        {
            if(character.HitPoints == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void IncreaseExperience(this Character character, int experience)
        {
            character.ExperiencePoints += experience;
            while ((character.Level * 100) <= character.ExperiencePoints)
            {
                character.LevelUp();
                Console.WriteLine($"{character.Name} lvl up!");
            }
            Console.WriteLine($"{character.Name} lvl {character.Level}");
        }
    }
}

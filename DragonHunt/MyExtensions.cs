using ClassLibrary;
using ClassLibrary.Interfaces;
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

        public static void RegenerateMana(this Sorcerer sorcerer, int mana)
        {
            if(sorcerer.ManaPoints + mana > sorcerer.MaximumManaPoints)
            {
                sorcerer.ManaPoints = sorcerer.MaximumManaPoints;
            }
            else
            {
                sorcerer.ManaPoints += mana;
            }
        }

        public static void SubtractDamage(this Character character, int damage)
        {
            character.Damage -= damage;
        }

        public static void SubtractDefense(this Character character, int defense)
        {
            character.Defense -= defense;
        }

        public static void Meditate(this IMagic magician)
        {
            magician.ManaPoints = magician.MaximumManaPoints;
        }
    }
}

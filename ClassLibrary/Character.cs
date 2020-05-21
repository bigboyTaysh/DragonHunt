using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Character : IComparable<Character>
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        public int Strength { get; set; }
        public int Dexternity { get; set; }
        public int Intelligence { get; set; }
        public int HitPoints { get; set; }
        public int MaximumHitPoints { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }

        private int _damageDealt;
        
        public Character()
        {

        }

        public Character(string name, int level, int experiencePoints, int strength,
            int dexternity, int intelligence, int maximumHitPoints, int damage, int defense)
        {
            Name = name;
            Level = level;
            ExperiencePoints = experiencePoints;
            Strength = strength;
            Dexternity = dexternity;
            Intelligence = intelligence;
            HitPoints = maximumHitPoints;
            MaximumHitPoints = maximumHitPoints;
            Damage = damage;
            Defense = defense;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Level: {Level}\n" +
                $"XP: {ExperiencePoints}\n" +
                $"STR: {Strength}\n" +
                $"DEX: {Dexternity}\n" +
                $"INT: {Intelligence}\n" +
                $"HP: {HitPoints}/{MaximumHitPoints}\n" +
                $"DMG: {Damage}\n" +
                $"DEF: {Defense}\n";
        }

        public virtual void AddDamage(int damage) 
        {
            Damage += damage;    
        }

        public virtual void AddDefense(int defense)
        {
            Defense += defense;
        }

        public virtual void TakeDamage(int damage)
        {
            if (damage > Defense)
            {
                HitPoints -= damage - Defense;
                if(HitPoints < 0)
                {
                    HitPoints = 0;
                }
            }
            else
            {
                Damage -= 1;
            }
        }

        public abstract void LevelUp();

        public int CompareTo(Character character)
        {
            return Level.CompareTo(character.Level);
        }
    }
}

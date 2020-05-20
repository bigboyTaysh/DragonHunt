using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Character : IComparable<Character>
    {
        public string Name;
        public int Level;
        public int ExperiencePoints;
        public int Strength;
        public int Dexternity;
        public int Intelligence;
        public int HitPoints;
        public int MaximumHitPoints;
        public int Damage;
        public int Defense;
        private int _damageDealt;

        protected Character(string name, int level, int experiencePoints, int strength,
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

        public virtual void SubtractDamage(int damage)
        {
            Damage -= damage;
        }

        public virtual void AddDefense(int defense)
        {
            Defense += defense;
        }

        public virtual void SubtractDefense(int defense)
        {
            Defense -= defense;
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

        public int CompareTo(Character other)
        {
            return Level.CompareTo(other.Level);
        }
    }
}

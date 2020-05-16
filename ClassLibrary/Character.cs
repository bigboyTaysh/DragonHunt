using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Character
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
        public int Defence;

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
            Defence = defense;
        }
    }
}

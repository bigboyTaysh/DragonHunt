using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Paladin : Character
    {
		private int _dodgeChance;

		public int DodgeChance
		{
			get { return _dodgeChance; }
			set { _dodgeChance = value; }
		}

		public Paladin(string name, int level = 1, int experiencePoints = 0, int strength = 5, int dexternity = 5,
			int intelligence = 10, int hitPoints = 15, int maximumHitPoints = 15, int damage = 50, int dodgeChance = 1) 
			: base(name, level, experiencePoints, strength, dexternity, intelligence, hitPoints, maximumHitPoints, damage)
		{
			DodgeChance = dodgeChance;
		}
	}
}

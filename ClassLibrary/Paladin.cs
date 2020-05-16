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

		public Paladin(string name, int level, int experiencePoints, int strength, int dexternity,
			int intelligence, int hitPoints, int maximumHitPoints, int damage, int dodgeChance) 
			: base(name, level, experiencePoints, strength, dexternity, intelligence, hitPoints, maximumHitPoints, damage)
		{
			DodgeChance = dodgeChance;
		}
	}
}

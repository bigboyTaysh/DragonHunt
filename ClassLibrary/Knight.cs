using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Knight : Character 
    {
		private int _attacksPerRound;
		public int AttacksPerRound
		{
			get { return _attacksPerRound; }
			set { _attacksPerRound = value; }
		}

		public Knight(string name, int level = 1, int experiencePoints = 0, int strength = 10,
			int dexternity = 5, int intelligence = 5, int hitPoints = 20, int maximumHitPoints = 20, int damage = 30, int defense = 30, int attacksPerRound = 1) 
			: base (name, level, experiencePoints, strength, dexternity, intelligence, hitPoints, maximumHitPoints, damage, defense)
		{
			AttacksPerRound = attacksPerRound;
		}
	}
}

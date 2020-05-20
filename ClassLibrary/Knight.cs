using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Knight : Character 
    {
		private int _attacksPerRound;
		public int AttacksPerRound
		{
			get { return _attacksPerRound; }
			set { _attacksPerRound = value; }
		}

		public Knight(string name, int level = 1, int experiencePoints = 0, int strength = 10,
			int dexternity = 5, int intelligence = 5, int maximumHitPoints = 20, int damage = 30, int defense = 30, int attacksPerRound = 1) 
			: base (name, level, experiencePoints, strength, dexternity, intelligence, maximumHitPoints, damage, defense)
		{
			AttacksPerRound = attacksPerRound;
		}

		public override string ToString()
		{
			return base.ToString() + 
				$"APR: {AttacksPerRound}";
		}

		public override void LevelUp()
		{
			Level += 1;
			Strength += 15;
			Dexternity += 5;
			Intelligence += 5;
			MaximumHitPoints += 30;
			HitPoints = MaximumHitPoints;
			Damage += 10;
			Defense += 30;
		}
	}
}

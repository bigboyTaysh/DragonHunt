using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Paladin : Character
    {
		private int _dodgeChance;

		public int DodgeChance
		{
			get { return _dodgeChance; }
			set { _dodgeChance = value; }
		}

		public Paladin(string name, int level = 1, int experiencePoints = 0, int strength = 5, int dexternity = 15,
			int intelligence = 5, int maximumHitPoints = 15, int damage = 50, int defense = 30, int dodgeChance = 10) 
			: base(name, level, experiencePoints, strength, dexternity, intelligence, maximumHitPoints, damage, defense)
		{
			DodgeChance = dodgeChance;
		}

		public override string ToString()
		{
			return base.ToString() + 
				$"DC: {DodgeChance}%\n";	
		}

		public override void TakeDamage(int damage)
		{
			Random random = new Random();
			if(random.Next(100) > DodgeChance)
			{
				if(Damage > Defense)
				{
					Damage -= Damage - Defense;
				}
				else
				{
					Damage -= 1;
				}
				
			}
			
		}

		public override void LevelUp()
		{
			Level += 1;
			Strength += 5;
			Dexternity += 15;
			Intelligence += 5;
			MaximumHitPoints += 15;
			Damage += 15;
			Defense += 15;
			DodgeChance += 2;
		}
	}
}

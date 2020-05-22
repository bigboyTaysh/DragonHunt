using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Paladin : Character
    {
		Random random;
		private int _dodgeChance;

		public int DodgeChance
		{
			get { return _dodgeChance; }
			set { _dodgeChance = value; }
		}

		public Paladin(string name, int level = 1, int experiencePoints = 0, int strength = 5, int dexternity = 15,
			int intelligence = 5, int maximumHitPoints = 100, int damage = 50, int defense = 30, int dodgeChance = 20) 
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
			random = new Random();

			if (random.Next(100) > DodgeChance)
			{
				if (damage > Defense)
				{
					HitPoints = HitPoints - (damage - Defense);
					if (HitPoints < 0)
					{
						HitPoints = 0;
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine($"{Name} - śmierć");
					}
				}
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine($"{Name}: unik!");
			}
		}

		public override void LevelUp()
		{
			Level += 1;
			Strength += 5;
			Dexternity += 15;
			Intelligence += 5;
			MaximumHitPoints += 30;
			Damage += 20;
			Defense += 15;
			DodgeChance += 5;
		}
	}
}

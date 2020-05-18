using ClassLibrary.Exceptions;
using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Sorcerer : Character, IMagic
    {
		private int _manaPoints;
		private int _maximumManaPoints;

		public int ManaPoints
		{
			get { return _manaPoints; }
			set { _manaPoints = value; }
		}

		public int MaximumManaPoints
		{
			get { return _maximumManaPoints; }
			set { _maximumManaPoints = value; }
		}

		public Sorcerer(string name, int level = 1, int experiencePoints = 0, int strength = 5, int dexternity = 5,
			int intelligence = 15, int maximumHitPoints = 15, int damage = 50, int defense = 30, int maximumManaPoints = 30) 
			: base(name, level, experiencePoints, strength, dexternity, intelligence, maximumHitPoints, damage, defense)
		{
			ManaPoints = maximumManaPoints;
			MaximumManaPoints = maximumManaPoints;
		}

		public override string ToString()
		{
			return base.ToString() + 
				$"MP: {ManaPoints}/{MaximumManaPoints}\n";
		}

		public override void LevelUp()
		{
			Level += 1;
			Strength += 5;
			Dexternity += 5;
			Intelligence += 10;
			MaximumHitPoints += 10;
			HitPoints = MaximumManaPoints;
			Damage += 30;
			Defense += 10;
			MaximumManaPoints += 30;
			ManaPoints = MaximumManaPoints;
		}

		public int CastSpell(int mana)
		{
			if(mana > ManaPoints)
			{
				throw new NoManaException("Za mało many");
			}

			ManaPoints -= mana;

			return Damage + mana;
		}
	}
}

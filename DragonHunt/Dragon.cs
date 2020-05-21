using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary.Interfaces;
using ClassLibrary.Exceptions;

namespace DragonHunt
{
    public delegate void DragonEventHandler(int damage);
    
    public partial class Dragon : Character, IMagic
    {
        private int _manaPoints;
        private int _maximumManaPoints;

        public event DragonEventHandler OnBreatheFire;

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

        public int CastSpell(int mana)
        {
            if (mana > ManaPoints)
            {
                throw new NoManaException("Za mało many");
            }

            ManaPoints -= mana;

            return Damage + mana;
        }
        public override void LevelUp()
        {
            Level += 1;
            Strength += 50;
            Dexternity += 50;
            Intelligence += 50;
            MaximumHitPoints += 100;
            Damage += 50;
            Defense += 50;
        }

        public void BreatheFire()
        {
            int damage = Level * Intelligence / 2;
            Console.WriteLine($"Smok {Name} zionie ogniem: {damage}");

            Sound();
            OnBreatheFire?.Invoke(damage);
        }

        partial void Sound();
    }
}

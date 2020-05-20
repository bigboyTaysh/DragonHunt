using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary.Interfaces;

namespace DragonHunt
{
    public class Dragon : Character, IMagic
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

        public int CastSpell(int mana)
        {
            throw new NotImplementedException();
        }
        public override void LevelUp()
        {
            throw new NotImplementedException();
        }
    }
}

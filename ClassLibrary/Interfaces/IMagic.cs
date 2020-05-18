using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
    public interface IMagic
    {
        int ManaPoints { get; set; }

		int MaximumManaPoints { get; set; }

		int CastSpell(int mana);
    }
}

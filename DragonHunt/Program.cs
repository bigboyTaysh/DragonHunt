using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace DragonHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorcerer sorcerer1 = new Sorcerer("Sorcerer 1");
            Sorcerer sorcerer2 = new Sorcerer("Sorcerer 2");

            Paladin paladin1 = new Paladin("Paladin 1");
            Paladin paladin2 = new Paladin("Paladin 2");

            Knight knight1 = new Knight("Knight 1");
            Knight knight2 = new Knight("Knight 2");
        }
    }
}

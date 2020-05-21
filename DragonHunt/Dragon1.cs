using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonHunt
{
    public partial class Dragon
    {
        partial void Sound()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ZCHHHHH");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

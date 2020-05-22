using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary.Exceptions;
using ClassLibrary.Interfaces;

namespace DragonHunt
{
    class Program
    {
        static List<Character> characters = new List<Character>();
        static List<Dragon> dragons = new List<Dragon>();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Sorcerer sorcerer1 = new Sorcerer("Sorcerer1");
            Sorcerer sorcerer2 = new Sorcerer("Sorcerer2");

            Paladin paladin1 = new Paladin("Paladin1");
            Paladin paladin2 = new Paladin("Paladin2");

            Knight knight1 = new Knight("Knight1");
            Knight knight2 = new Knight("Knight2");

            characters.Add(sorcerer1);
            characters.Add(sorcerer2);
            characters.Add(paladin1);
            characters.Add(paladin2);
            characters.Add(knight1);
            characters.Add(knight2);

            Dragon dragon = new Dragon
            {
                Name = "Dragon",
                Level = 1,
                ExperiencePoints = 0,
                Strength = 20,
                Dexternity = 20,
                Intelligence = 50,
                HitPoints = 1750,
                MaximumHitPoints = 1750,
                Damage = 50,
                Defense = 50
            };
            dragon.OnBreatheFire += v => characters.ForEach(c => 
            {
                if (!c.IsDead())
                {
                    c.TakeDamage(v);
                }
            });

            dragons.Add(dragon);

            //dragon.BreatheFire();

            //paladin1.IncreaseExperience(50);
            //MyExtensions.IncreaseExperience(paladin2, 50);

            //var under1Level = characters.Where(v => v.Level > 1).Select(v => new { v.Name, v.Level});

            /*
            foreach (var item in under1Level)
            {
                Console.WriteLine($"Imię: {item.Name}, {item.Level}");
            }
            */

            int round = 0;
            while(!characters.All(v => v.IsDead()) && !dragon.IsDead())
            {
                round++;
                Round(round, 0);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n-----------------------------END-----------------------------------");
            Console.WriteLine($"------------------------- Round: {round} --------------------------");

            Stats();

            if (characters.All(v => v.IsDead()))
            {
                Console.WriteLine($"------------------------- Smok wygrał ---------------------------------");
            }
            else
            {
                Console.WriteLine($"----------------------- Drużyna wygrała ---------------------------------");
            }
        }

        static void Round(int round, int sleep)
        {

            Stats();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"-------------------------------------------------------------------");
            Console.WriteLine($"------------------------- Round: {round} --------------------------");
            Console.WriteLine($"-------------------------------------------------------------------");

            Console.WriteLine();

            Thread.Sleep(sleep);

            characters.ForEach(c => 
            {
                dragons
                .ForEach(d => 
                {
                    if (!d.IsDead())
                    {
                        if (c is IMagic)
                        {
                            try
                            {
                                c.DamageDealtPerRound(((IMagic)c).CastSpell(10));
                                d.TakeDamage(((IMagic)c).CastSpell(10));
                            }
                            catch (NoManaException e)
                            {
                                Console.WriteLine($"{c.Name} nie ma many!");
                            }
                        }
                        else
                        {
                            if(c is Knight)
                            {
                                int knightDamage = 0;
                                for (int i = 1; i <= ((Knight)c).AttacksPerRound; i++)
                                {
                                    knightDamage += c.Damage;
                                    d.TakeDamage(c.Damage);
                                }
                                c.DamageDealtPerRound(knightDamage);
                            }
                            else
                            {
                                c.DamageDealtPerRound(c.Damage);
                                d.TakeDamage(c.Damage);
                            }
                        }
                    }
                });
            });

            Thread.Sleep(sleep);

            Console.WriteLine();


            dragons.ForEach(d => 
            {
                if (!d.IsDead())
                {
                    d.BreatheFire();
                }
            });

            Thread.Sleep(sleep);


            characters.ForEach(c => 
            {
                if (!c.IsDead())
                {
                    c.IncreaseExperience(200 / round);
                }
            });

            dragons.ForEach(d => 
            {
                if (!d.IsDead())
                {
                    d.IncreaseExperience(35);
                }
            });

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("#####################################################################");
            Console.WriteLine("#####################################################################");
            Console.WriteLine("#####################################################################");
        }

        static void Stats()
        {
            characters.ForEach(c =>
            {
                string info = c.ToString();
                Console.Write(info.Substring(0, 6));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(info.Substring(6, (info.IndexOf("Level", StringComparison.Ordinal)) - 6));

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(info.Substring((info.IndexOf("Level", StringComparison.Ordinal))), info.Length);
            });

            dragons.ForEach(d =>
            {
                string info = d.ToString();
                Console.Write(info.Substring(0, 6));

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(info.Substring(6, (info.IndexOf("Level", StringComparison.Ordinal)) - 6));

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(info.Substring((info.IndexOf("Level", StringComparison.Ordinal))), info.Length);
            });
        }
    }
}

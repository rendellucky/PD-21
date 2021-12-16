using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dop.Heroes.Batman;
using static Dop.Heroes.Flash;
using static Dop.Heroes.Green_light;
using static Dop.Heroes.Super_woman;
using static Dop.Heroes.Superman;

namespace Dop
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero1 hero1 = new Hero1 { Name = "Batman", Ability = "can throw shuriken" };
            hero1.Info();
            Hero2 hero2 = new Hero2 { Name = "Flash", Ability="is very fast" };
            hero2.Info();
            Hero3 hero3 = new Hero3 { Name = "Green light",Ability="has the super ring" };
            hero3.Info();
            Hero4 hero4 = new Hero4 { Name = "Super woman",Ability="has shield and sword" };
            hero4.Info();
            Hero5 hero5 = new Hero5 { Name = "Superman", Ability="can fly" };
            hero5.Info();

            Console.ReadKey();
        }
    }
}

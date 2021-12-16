using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop.Heroes
{
    class Flash
    {
        public class Hero2 : ISuperHero
        {
            private string name;
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            private string ability;
            public string Ability
            {
                get
                {
                    return ability;
                }
                set
                {
                    ability = value;
                }
            }
            public void Info()
            {
                Console.WriteLine($"{Name} {Ability}");
            }
        }
    }
}

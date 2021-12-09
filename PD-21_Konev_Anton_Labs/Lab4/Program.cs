using Lab4.Phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartphone = new SmartPhone();

            smartphone.Call();
            smartphone.Message();
            smartphone.Photo();
            smartphone.Videos();
            smartphone.Smart();
        }
    }
}

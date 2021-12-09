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
     public class DiscPhone
    {
        public  void Call()
        {
            Console.WriteLine("I can make calls");
        }
    }
    public class ButtonPhone: DiscPhone
    {
        public void Message()
        {
            Console.WriteLine("Lets send a message");
        }
    }
    public class WBPhone : ButtonPhone
    {
        public void Photo()
        {
            Console.WriteLine("You can watch photo");
        }
    }
    public class ColorPhone : WBPhone
    {
        public void Videos()
        {
            Console.WriteLine("You can watch videos with me");
        }
    }
    public class SmartPhone : ColorPhone
    {
        public void Smart()
        {
            Console.WriteLine("You can do everything!");
        }
    }
}

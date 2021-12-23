using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extra_Task2_Garage
{
    class Garage
    {
        List<Car> cars;
        public Garage()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car c)
        {
            this.cars.Add(c);
        }

        public void DeleteCar(Car c)
        {
            this.cars.Remove(c);
        }




        public void filterSpeed(int speed)
        {

            for (int i = 0; i < this.cars.Count; i++)
            {
                if (speed == cars[i].Maxspeed)
                {
                    Console.BackgroundColor = this.cars[i].Color;
                    Console.WriteLine(this.cars[i].ToString());
                }

            }

        }
        public void filterYear(int year)
        {
            ConsoleColor before = Console.BackgroundColor;

            for (int i = 0; i < this.cars.Count; i++)
            {
                if (year == cars[i].Year)
                {
                    Console.BackgroundColor = this.cars[i].Color;
                    Console.WriteLine(this.cars[i].ToString());
                }

            }
            Console.BackgroundColor = before;
        }
        public void filterName(string name)
        {
            ConsoleColor before = Console.BackgroundColor;
            for (int i = 0; i < this.cars.Count; i++)
            {
                if (name.ToUpper() == cars[i].Name)
                {
                    Console.BackgroundColor = this.cars[i].Color;
                    Console.WriteLine(this.cars[i].ToString());
                }

            }
            Console.BackgroundColor = before;
        }
        public void filterColor(ConsoleColor color)
        {
            ConsoleColor before = Console.BackgroundColor;
            for (int i = 0; i < this.cars.Count; i++)
            {
                if (color == cars[i].Color)
                {
                    Console.BackgroundColor = this.cars[i].Color;
                    Console.WriteLine(this.cars[i].ToString());
                }

            }
            Console.BackgroundColor = before;
        }
        public void ShowCars()
        {
            ConsoleColor before = Console.BackgroundColor;
            for (int i = 0; i < this.cars.Count; i++)
            {
                Console.BackgroundColor = this.cars[i].Color;
                Console.WriteLine(this.cars[i].ToString());
            }
            Console.BackgroundColor = before;
        }
    }
}
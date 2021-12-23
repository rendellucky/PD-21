using System;
using System.Collections.Generic;
using System.Text;

namespace Extra_Task2_Garage
{
    class Car
    {
        string name;
        public string Name
        {
            set
            {
                this.name = value.ToUpper();
            }
            get
            {
                return name;
            }
        }

        private short year;

        public short Year
        {
            get { return year; }
            set { year = value; }
        }

        private ConsoleColor color;

        public ConsoleColor Color
        {
            get { return color; }
            set { color = value; }
        }

        private short maxspeed;

        public short Maxspeed
        {
            get { return maxspeed; }
            set { maxspeed = value; }
        }

        public Car(string name, ConsoleColor color, short maxspeed, short year)
        {
            this.Name = name;
            this.Color = color;
            this.Maxspeed = maxspeed;
            this.Year = year;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Year: {this.Year}, maxspeed: {this.Maxspeed}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;   //Object Creation

            car = new Car("Blue");   
            Console.WriteLine(car.Describe());

            car = new Car("Red");
            Console.WriteLine(car.Describe());

        }
    }

    class Car   // Declaration of a Class
    {
        private string color;

        public Car(string color)   //Car method
        {
            this.color = color;
        }

        public string Describe()  //Describe method
        {
            return "This car is " + Color;
        }

        public string Color   //Color Method
        {
            get { return color; }
            set { color = value; }
        }
    }
}

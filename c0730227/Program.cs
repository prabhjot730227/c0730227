using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730227
{
    class Program
    {
        static void Main(string[] args)
        {
           var dog_and_cat = new Car();
            var bowling = new Car();
            Console.WriteLine("how many cars: {0}", Vehicle.howManyCars);
        }
    }
    class Vehicle
    {
        public static int howManyCars=0;
        public String Color = "Blue";
    }
    class Car : Vehicle
    {
        public String Color = "Red";
        public Car()
        {
            Vehicle.howManyCars++;
            Console.WriteLine("my color is " + Color);
        }
    }
}

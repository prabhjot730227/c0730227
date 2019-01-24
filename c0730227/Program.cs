using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730227
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Promote() {
            var rating = CalculateRating();
                if (rating == 0)
            {
                Console.WriteLine("Promoted to Level 1");

            }
            else
            {
                 Console.WriteLine("Promoted to Level 2");
            }
        }
        public int CalculateRating()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            
            //var dog_and_cat = new Car();
            // var bowling = new Car();
            // Console.WriteLine("how many cars: {0}", Vehicle.howManyCars);
            //Book myBook = new Book();
            //myBook.SetTitle("A Separate Peace");
            //Console.WriteLine("my color is " + Color);

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
    class BookCollection
        {

        }
        class Book : BookCollection
        {
            private String Title;
            public void SetTitle(String aTitle)
            {
                this.Title = aTitle;
            }
            public String GetTitle() { return this.Title; }
        }
    }


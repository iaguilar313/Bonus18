using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Motors Admin Console");
            Console.WriteLine("How many cars are you entering");

            int NumberOfCars;
            NumberOfCars = int.Parse(Console.ReadLine());

            Car[] CarNo = new Car[NumberOfCars];

            for (int i = 0; i < CarNo.Length; i++)
            {
                CarNo[i] = new Car();
            }

            for (int i = 0; i < CarNo.Length; i++)
            {
                Console.WriteLine("Enter Car's Make");
                CarNo[i].Make = Console.ReadLine();

                Console.WriteLine("Enter Car's Model");
                CarNo[i].Model = Console.ReadLine();

                Console.WriteLine("Enter Car's Year");
                CarNo[i].Year = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Car's Price");
                CarNo[i].Price = int.Parse(Console.ReadLine());


            }


            Console.WriteLine("********************************");
            Console.WriteLine("Make \tModel \tYear \tPrice"); 

            foreach(Car No in CarNo)
            {
                Console.WriteLine($"{No.Make}\t {No.Model}\t {No.Year}\t {No.Price} ");
            }

                
            


        }
    }
}

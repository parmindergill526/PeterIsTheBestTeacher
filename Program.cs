using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterWeek2ListArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<string>();

            dogs.Add("Bichon");
            dogs.Add("Poodle");
            dogs.Add("Retriever");

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog + " ");
            }
            Console.WriteLine(dogs[2]);
            Console.ReadLine();
        }
    }
}

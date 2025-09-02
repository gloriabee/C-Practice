using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{

    internal class Program
    {

        // End of Functions 

        static void Main(string[] args)
        {
            Animal dog = new Animal("Buddy", "Woof", 3);
            Animal cat = new Animal("Whiskers", "Meow");

            dog.PrintInfo();
            cat.PrintInfo();

            Console.WriteLine($"Total Animals: {Animal.numOfAnimals}");

            // Using struct 
            Dimensions cage = new Dimensions(2.5, 1.5);
            Console.WriteLine($"Cage area: {cage.Area()} square meters");

            Console.ReadKey();

        }
        

    }
}




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            Console.Write("Random number betwen 1 and 11: ");
            Console.WriteLine(randomNumber);

        }
    }
}

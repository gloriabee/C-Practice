using System;
using System.Collections.Generic;
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
            Console.WriteLine("Enter a number: ");
            string numInput = Console.ReadLine();
            int num = 0;

            bool success=int.TryParse(numInput, out num);
            if (success)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Failed to convert");
            }
               


        }
    }
}
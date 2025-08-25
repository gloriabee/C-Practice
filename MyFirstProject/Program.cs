using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to repeat?: ");
            string message = Console.ReadLine();

            Console.WriteLine("How many times do you want to say hi?");
            int times= Convert.ToInt32(Console.ReadLine());

            if (times <= 0)
            {
                Console.WriteLine("Sorry, please enter a value above 0");
            }
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(message);
            }

        }
    }
}
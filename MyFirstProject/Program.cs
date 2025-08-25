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
            Console.WriteLine("Hello, My name is Gloria");

            Console.Write("Enter your name:");
            string name=Console.ReadLine();

            Console.Write("Enter your age:");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine("Your name is " + name +" and your age is "+age);
            
           
        }
    }
}

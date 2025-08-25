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
            Console.Write("Enter the first number:");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Whats the value of "+num1 +" * "+num2);
            Console.Write("Enter your answer: ");
            int answer= Convert.ToInt32(Console.ReadLine());
            int result = num1 * num2;

            while (answer != result)
            {
                Console.WriteLine("Close but it was wrong!");
                Console.Write("Enter your answer: ");
                answer = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Well done!");
            



        }
    }
}
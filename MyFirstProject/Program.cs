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
            int[] numbers = new int[]
            {
                90,199,299,32,234,34 };
            Console.Write("Enter number to search: ");
            int search= Convert.ToInt32(Console.ReadLine());

            int position=Array.IndexOf(numbers, search);
           
            if(position>-1)
            {
                Console.WriteLine($"Number {search} has been found at position {position}");
            }
            else
            {
                Console.WriteLine("Not found");
            }



        }
    }
    }

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
                1,35,342,32,145,23,452,34
            };
            
            Array.Sort(numbers);
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

        }
    }
    }

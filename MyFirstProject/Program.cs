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
            
            Array.Clear(numbers,3,5);
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

        }
    }
    }

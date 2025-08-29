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
            //bool success=int.TryParse("123", out int result);
            //Console.WriteLine(success);
            CreateAndPrintArray();


        }

        static void CreateAndPrintArray()
        {
            int[] numbers = new int[3] { 0, 1, 2 };
            foreach (int i in numbers)
            {
                Console.WriteLine($"{i}");
            }


        }
    }

    }



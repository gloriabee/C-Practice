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
        static string name = "Aba";
        static void Main(string[] args)
        {
            Console.Title = name;
            Console.WriteLine("Enter a number, I'll add 10 to it!");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write(AddTwoValues(num1,10));

        }

        static int AddTwoValues(int value1,int value2)
        {
            int result=value1+value2;
            return result;

        }
    }

    }



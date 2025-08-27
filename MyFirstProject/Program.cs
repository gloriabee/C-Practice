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
            string name = "blob";
            int age = 23;
            string test = string.Concat("Your name is ", name, " and your age is ", age);
            Console.WriteLine(test);

        }
        }
    }

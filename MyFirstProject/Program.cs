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
            Console.WriteLine("Enter your name: ");
            string name= Console.ReadLine();

            Console.WriteLine($"Your name is {name}");

            if (!name.Equals(""))
            {
                Console.WriteLine("0");
            }
            if (name != "")
            {
                Console.WriteLine("1");
            }
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("2");
            }
        }
    }
    }

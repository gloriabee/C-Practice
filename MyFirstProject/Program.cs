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
            Console.Write("Enter your message: ");
            string input = Console.ReadLine();
            Console.WriteLine(input[0]);
            Console.WriteLine(input.Length);

            for(int i = input.Length-1; i >=0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
    }

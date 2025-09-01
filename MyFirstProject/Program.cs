using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Aba";
            int age = 35;
            PrintDetails(name,age);

            if (age > 18)
            {
                Console.WriteLine("18+");
            }


            string message = ReadFromConsole("Enter anything: ");
            Console.WriteLine(message);
            Console.ReadLine();
        }

        static string ReadFromConsole(string str)
        {
            Console.Write(str);
            return Console.ReadLine();
        }
        static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
        }



    }

    }



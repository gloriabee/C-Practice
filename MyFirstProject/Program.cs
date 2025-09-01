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
            int result = Add(5);
            Console.WriteLine(result);
           

            PrintName("Aba");
            PrintName();
            Console.ReadLine();
        }

        static void PrintName(string name=default)
        {
            Console.WriteLine($"My name is {name}");
        }

        public static int Add(int a, int b=default)
        {
            Console.WriteLine($"‌ေa={a}and b= {b}");
            return a + b;
        }


    }

    }



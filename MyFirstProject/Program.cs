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

            Console.Write(AddTwoValues(100, 200));

        }

        static int AddTwoValues(int value1,int value2)
        {
            int result=value1+value2;
            return result;

        }
    }

    }



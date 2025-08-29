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
            int myNumber = 5;
            ModifyValue(ref myNumber);
            Console.WriteLine(myNumber);
        }

        static void ModifyValue(ref int number)
        {
            number += 10;
        }
        
        // ref The original value is changed because we passed it by reference.
      
    }

    }



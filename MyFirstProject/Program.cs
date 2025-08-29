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
            int myValue;
            GetValues(out myValue);
            Console.WriteLine(myValue);
        }

        static void GetValues(out int result)
        {
            result = 42;
        }
        
        // ref The original value is changed because we passed it by reference.
      
    }

    }



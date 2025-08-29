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
            int a = 5, b = 3, sum, product;
            Calculate(a,b,out sum,out product);
            Console.WriteLine();
        }

        static void Calculate(int x,int y, out int sum,out int product)
        {
            sum = x + y;
            product = x * y;
            Console.WriteLine($"Sum: {sum}, Product: {product}");
        }
      
    }

    }



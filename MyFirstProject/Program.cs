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
            int[] angles = new int[3];
            for (int i = 0; i < angles.Length; i++)
            {
                Console.Write($"Enter angle {i+1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            string isValid = angles.Sum() <= 180 ? "Valid" : "Invalid";
            Console.WriteLine(isValid);
            

        }
    }
    }

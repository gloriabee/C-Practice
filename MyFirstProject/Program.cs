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
            int[] numbers = new int[3];

            


            for (int i = 0; i < numbers.Length; i++)
            {

                Console.Write("Enter number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.WriteLine(numbers[i]);
                
            }

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
    }

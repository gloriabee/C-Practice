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
            int[] numbers = new int[4]
            {
                1,2,3,4 
            };

            List<int> listNumbers = new List<int>();
            listNumbers.Add(1);
            listNumbers.Add(2);
            listNumbers.Add(3);

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }

            listNumbers.Insert(3, 30);

            foreach (var i in listNumbers)
            {
                Console.WriteLine(i);
            }

            listNumbers.RemoveAt(2);
            foreach (var i in listNumbers)
            {
                Console.WriteLine(i);
            }

        }
    }
    }

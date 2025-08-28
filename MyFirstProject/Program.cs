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
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for(int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }
            Console.WriteLine("Odd Numbers");
            foreach (var item in odd)
            {
                Console.WriteLine(item+" ");
            }
            Console.WriteLine("Even Numbers");
            foreach (var item in even)
            {
               
                Console.WriteLine(item + " ");
            }
        }
    }
}

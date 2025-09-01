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
            int[] nums = {10,30,242,12,23};
            if (nums.Length == -1)
            {
                Console.WriteLine("Array is empty");
            }
            else
            {
                int sumResult=SumOfNumbers(nums);
                Console.WriteLine($"The sum of int array is {sumResult}");
            }

            Console.ReadKey();
        }
        static int SumOfNumbers(int[] nums)
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                
            };
            return sum
            ;
        }
        
        

    }

    }



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{

    internal class Program
    {

        // Functions 
        // <Access Specifier> <Return Type> <Method Name> (Parameters)

        //private static void SayHello()
        //{
        //    string name = "";
        //    Console.Write("What is your name: ");
        //    name = Console.ReadLine();
        //    Console.WriteLine($"Hello {name}");
        //}

        //static double GetSum(double x=1,double y = 1)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //    return x + y;
        //}


        //static void DoubleIt(int x,out int solution)
        //{
        //    solution = x * 2;
            
        //}

        //public static void Swap(ref int num3, ref int num4)
        //{
        //    int temp = num3;
        //    num3 = num4;
        //    num4 = temp;
        //}

        //static double GetSumMore(params double[] nums)
        //{
        //    double sum = 0;
        //    foreach(int i in nums)
        //    {
        //        sum += i;
               
        //    }
        //    return sum;

        //}

        //static void PrintInfo(string name,int zipCode)
        //{
        //    Console.WriteLine($"{name} lives in the zip code {zipCode}");
        //}

        static double GetSum2(double x=1,double y = 1)
        {
            return x + y;
        }

        static double GetSum2(string x="1",string y="2")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }


        // End of Functions 

        static void Main(string[] args)
        {
            //SayHello();
            //double x = 5, y = 4;
            //Console.WriteLine($"5+4 = {GetSum(x, y)}");
            //Console.WriteLine($"With default values: {GetSum()}");
            //Console.WriteLine($"X= {x}");
            //Console.WriteLine($"Y= {y}");


            //int solution;
            //DoubleIt(15, out solution);
            //Console.WriteLine($"15 *2 = {solution}");



            //int num3 = 10;
            //int num4 = 20;
            //Console.WriteLine($"Before Swap num1: {num3} and num4 {num4}");
            //Swap(ref num3,ref num4);
            //Console.WriteLine($"After Swap num1: {num3} and num4 {num4}");

            //Console.WriteLine($"1+2+3 ={GetSumMore(1,2,3)}");

            //PrintInfo(zipCode: 151437, name: "Derek");

            Console.WriteLine($"5.0 + 4.0 = {GetSum2(5.0,4.0)}");
            Console.WriteLine($"5.0 + 4.0 = {GetSum2("5.0", "4.0")}");
            Console.ReadKey();
        }


    }
}



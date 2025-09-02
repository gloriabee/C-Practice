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
            

            // Getting the current Date and Time
            Console.WriteLine($"Todays' Date: {DateTime.Today}");
            Console.WriteLine($"Todays' Date & Time : {DateTime.Now}");
            Console.WriteLine($"current UTC date & time : {DateTime.UtcNow}");

            // Creating Dates
            DateTime awesomeDate = new DateTime(1974, 12, 21);
            DateTime withTime = new DateTime(2025, 9, 2, 14, 30, 0);
            Console.WriteLine($"withTime: {withTime}");
            Console.WriteLine($"Day of the week : {awesomeDate.DayOfWeek}");


            // Date Arithmetic 
            DateTime tomorrow = DateTime.Now.AddDays(1);
            DateTime nextMonth = DateTime.Now.AddMonths(1);
            DateTime nextYear = DateTime.Now.AddYears(1);
            Console.WriteLine($"Tomorrow: {tomorrow}, next Month: {nextMonth}, next Year: {nextYear}");


            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine($"New Time: {lunchTime.ToString()}");
            TimeSpan duration = DateTime.Now - new DateTime(2024, 12, 6);
            Console.WriteLine(duration.Days);


            // Formatting Dates
            DateTime now = DateTime.Now;

            Console.WriteLine(now.ToString("yyyy-MM-dd"));
            Console.WriteLine(now.ToString("dddd,MMMM dd,yyyy"));
            Console.WriteLine(now.ToString("hh:mm tt"));
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortTimeString());

            // Parsing Strings to DateTime 
            string input = "09/02/2025 14:30";
            DateTime parsed = DateTime.Parse(input);
            Console.WriteLine(parsed);

            if(DateTime.TryParse(input,out DateTime safeParsed))
            {
                Console.WriteLine(safeParsed);
            }


            // Comparing Dates 
            DateTime d1 = DateTime.Now;
            DateTime d2 = d1.AddDays(1);

            Console.WriteLine(d1<d2);
            Console.WriteLine(d1==d2);

            int result = DateTime.Compare(d1, d2);
            Console.WriteLine(result);
            // -1 means earlier, 0 means same and 1 means d1. 
            

            //Calculating Age/Duration

            DateTime birthDate = new DateTime(2000, 11, 18);
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear) age--;
            Console.WriteLine($"Age: {age}");

            // Timespan with DateTime 
            DateTime start = DateTime.Now;
            DateTime end = start.AddHours(6).AddMinutes(45);

            TimeSpan diff = end - start;
            Console.WriteLine(diff.TotalMinutes);

            // Special Values
            Console.WriteLine(DateTime.MinValue);
            Console.WriteLine(DateTime.MaxValue);

            Console.ReadKey();
        }


    }
}



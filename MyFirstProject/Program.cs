using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{

    internal class Program
    {
        // default parameter
        static void Display(int x)
        {
            Console.WriteLine("Value Parameter: "+x);
        }

        //reference parameter 
        static void Update(ref int y)
        {
            y += 5;
            Console.WriteLine("Reference Parameter: "+y);
        }


        //output parameter 
        static void GetValues(out int z)
        {
            //assign value to output parameter
            z = 20;
            Console.WriteLine("Output parameter: "+z);
        }

        //returning multiple values
        static void Calculate(int x,int y,out int sum, out int product)
        {
            sum = x + y;
            product = x * y;
        }

        //in 
        static void PrintValue(in int number)
        {
            Console.WriteLine(number);
        }
        //Countdown Recursion
        static void CountDown(int number)
        {
            //Base Case: stop when we reach 0
            if (number == 0)
            {
                Console.WriteLine("Blast Off!");
                return;
            }

            Console.WriteLine(number);

            CountDown(number - 1);
        }


        //Factorial Function Using Recursion

        static int Factorial(int n)
        {
            if(n==0 || n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

        class MathOperations
        {
            public int Square(int number) => number * number;
        }

        class FileHandler
        {
            ~FileHandler() => Console.WriteLine("Finalizer called!");
        }

        class Collection
        {
            private int[] numbers = { 1, 2, 3, 4, 5 };
            public int this[int index]=> numbers[index];
             
        }

        static int AddNum(int firstNum,int secondNum)
        {
            return firstNum + secondNum;
        }

       
        static void Main(string[] args)

        {
            Notifier notifier = new Notifier();
            notifier.Send("Gloria", "Hello");
            notifier.Send("System updated");
            notifier.Send("Bob", "Busy", 1);
            Console.ReadLine();

            //Console.WriteLine(AddNum(15, 25));
            //Console.WriteLine(AddNum(firstNum: 23, secondNum: 21));
            //Console.WriteLine(AddNum(23, secondNum: 100));
            //Console.WriteLine(AddNum(firstNum:100,200));



        }
      

    }

    }



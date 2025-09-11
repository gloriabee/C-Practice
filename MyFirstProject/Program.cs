using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{

    internal class Program
    {
        // delegate declaration
        delegate void PrintDelegate(string text);

        //calling function inside other functions
        static void ConnectToDatabase(PrintDelegate log) {
            // do the insertion
            log("inserting a new record into the database");
            log("the record got inserted into the database");
            // insertion done
        }

        // static delegate instance
        static PrintDelegate PrintConsole = (string text) =>
            Console.WriteLine(text);

        static PrintDelegate PrintToFile = (string text) =>
        {
            File.AppendAllText("/logs.txt", text);
        };

        public delegate void Arithmetic(double num1, double num2);
        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1+num2}");
        }

        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1-num2}");
        }

        static void Main(string[] args)

        {
            PrintConsole("Hello World");
            ConnectToDatabase(PrintToFile);
            ConnectToDatabase(PrintConsole);
            Arithmetic add, sub,addSub;
            add = new Arithmetic(Add);
            sub = new Arithmetic(Subtract);
            addSub = add + sub;

            Console.WriteLine($"Add {6} & {10}");
            add(6, 10);
            Console.WriteLine($"Add & Subtract {10} & {4}");
            addSub(10, 4);

            Console.ReadLine();
        }
        }
       
        
        

    }





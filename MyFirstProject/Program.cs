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
            string nameInput = "Aba";
            int ageInput = 23;
            string addressInput = "1 Something road";

            PrintDetails(name:nameInput,
                age:ageInput, 
                address:addressInput);
            Console.ReadLine();
        }
        static void PrintDetails(string name,int age,string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }


    }

    }



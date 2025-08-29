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
            
            //Creating the object of the car
            Car audi= new Car("A3","Audi");
            
            Car bmw=new Car("I7","BMW");

            Console.WriteLine("Please enter the Brand name");

            audi.Brand = Console.ReadLine();

            //Getting Brandname
            Console.WriteLine("You entered "+audi.Brand);
           
            Console.ReadKey();
            
        }

    }

    }



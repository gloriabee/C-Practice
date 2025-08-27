using System;
using System.Collections.Generic;
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

            string name = "Aba";
            int age = 23;

            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Name: "+name+"\nAge: "+age);
            Console.WriteLine("Your name is {0} and your age is {1}",name,age);
            Console.WriteLine("Name: {0} \n Age:{1}",name,age);

        }
        }
    }

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

        // End of Functions 

        static void Main(string[] args)
        {
            // LINQ Method Syntax

            IList<string> stringList = new List<String>()
            {
                              "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };

            // LINQ Method Syntax 

            var result = stringList.Where(s => s.Contains("Tutorials"));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
        

    }
}




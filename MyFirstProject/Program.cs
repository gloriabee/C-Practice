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
            // LINQ Query Syntax
            IList<string> stringList = new List<string>()
            {
                           "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };

            var result= from s in stringList
                        where s.Contains("Tutorials")
                        select s;
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();

        }
        

    }
}




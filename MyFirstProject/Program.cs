using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Test
    {
        public static void something()
        {
            Console.WriteLine("something");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           //Test test = new Test();
            Test.something();
            WelcomeMessage();
           
        }
        // static means can call anywhere. don't need to create instance. accessible from everywhere.

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome user");
        }
    }
}

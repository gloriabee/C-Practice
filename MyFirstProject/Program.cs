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
            bool looping = true;
            while (looping)
            {
                try
                {

                    Console.WriteLine("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);
                    looping = false;
                }
                
                catch (OverflowException e)
                {
                    Console.WriteLine($"Errors: {e.Message}");
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something has went wrong");
                }

            }

            Console.WriteLine("GoodBye");
           

            Console.ReadLine();
        }



    }

    }



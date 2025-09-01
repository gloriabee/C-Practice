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
            
            int width = ReadInt("Enter Width: ");
            int height = ReadInt("Enter Height: ");

            int result= FindArea(width, height);
            Console.Write($"The area of the triangle is {result}");
            Console.ReadKey();

        }

        static int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

       
        static int FindArea(int width,int height)
        {
            return (width * height)/2;
        }
        
        

    }

    }



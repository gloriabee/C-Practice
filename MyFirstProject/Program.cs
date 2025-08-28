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
            Console.Write("Enter the password: ");
            string password = Console.ReadLine();

            Console.Write("Enter password again: ");
            string passwordC= Console.ReadLine();

            if (!password.Equals(string.Empty) && !passwordC.Equals(string.Empty))
            {
                if (password.Length >= 6 && passwordC.Length >= 6) {
                    if (password == passwordC)
                    {
                        Console.WriteLine("Password match");
                    }
                    else
                    {
                        Console.WriteLine("Password do not match");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter password count above 6 characters");
                }

               
            }
            else
            {
                Console.WriteLine("Enter password again");
            }
               
        }
    }
    }

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
            string[,,] simple3DArray =
            {
                {
                    { 
                        "000","001"
                    },
                    {
                        "010","011"
                    }
                },
                 {
                    {
                        "100","101"
                    },
                    {
                        "110","111"
                    }
                },

            };

            Console.WriteLine(simple3DArray[1,1,1]);
        }
    }
}

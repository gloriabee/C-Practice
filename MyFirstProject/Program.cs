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
            int[,] array2DDeclaration = new int[3, 3];
            // [0] [0] [0]
            // [0] [0] [0]
            // [0] [0] [0]

            int[,,] array3DDeclaration= new int[3,3,3];

            int[,] array2DInitialized = { {1,2}, {3,4} };
            // [1] [2]
            // [3] [4]

            Console.WriteLine(array2DInitialized[0,0]);
            array2DInitialized[0, 0] = 5;
            Console.WriteLine(array2DInitialized[0, 0]);

            string[,] tictactoe =
            {
                {
                    "O","X","X"
                },
                {
                    "O","O","X"
                },
                {
                    "X","X","O"
                }
            };

            Console.WriteLine(tictactoe[1,2]);


        }
    }
}

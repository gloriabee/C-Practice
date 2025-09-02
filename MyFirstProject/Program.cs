using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{

    internal class Program
    {
        enum CarColor: byte{
                Orange=1,
                Blue,
                Green,
                Red,
                Yellow
            };
      
            static void PaintCar(CarColor cc)
        {
            Console.WriteLine($"The car was painted {cc} with the code {(int)cc}");
        }
      
        // End of Functions 

        static void Main(string[] args)
        {

            CarColor car1 = CarColor.Blue;
            CarColor yellowCar = CarColor.Yellow;
            PaintCar(car1);
            PaintCar(yellowCar);
            Console.WriteLine(car1);
            Console.WriteLine(yellowCar);
            Console.ReadKey();
        }


    }
}



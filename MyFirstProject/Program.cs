using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
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
            // use inner class
            Animal.Info.ShowKingdom();

            // polymorphism: Base class reference can hold derived class objects 
            Animal myDog = new Dog("Buddy");
            Animal myCat = new Cat("Whiskers");

            // abstract+ override methods
            myDog.MakeSound();
            myCat.MakeSound();

            // virtual+ override methods 
            myDog.Eat();
            myCat.Eat();

            // Interface methods
            Imovable mover1 = new Dog("Max");
            Imovable mover2 = new Cat("Luna");
            mover1.Move();
            mover2.Move();

            // Normal method from abstract class
            myCat.Sleep();

            Console.ReadKey();

        }
        

    }
}




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



        static void Main(string[] args)

        {
            List<Animal> animalList = new List<Animal>();
            List<int> numList = new List<int>();

            numList.Add(24);

            animalList.Add(new Animal() { Name = "Dog" });
            animalList.Add(new Animal() { Name = "Paul" });
            animalList.Add(new Animal() { Name = "Sally" });

            animalList.Insert(1, new Animal() { Name = "steve" });
            animalList.RemoveAt(1);

            Console.WriteLine($"Num of Animals: {animalList.Count()}");

            foreach (Animal a in animalList)
            {
                Console.WriteLine(a.Name);
            }

            int x = 5, y = 4;
            Animal.GetSum<int>(ref x, ref y);

            string strX = "10", strY = "23";
            Animal.GetSum<string>(ref strX, ref strY);

            Rectangle<int> rec1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rec1.GetArea());

            Rectangle<string> rec2 = new Rectangle<string>("20", "12");
            Console.WriteLine(rec2.GetArea());
            Console.ReadLine();
        }

        public struct Rectangle<T>
        {
            private T width;
            private T length;

            public T Width
            {
                get { return width; }
                set { width=value; }
            }

            public T Length
            {
                get { return length; }
                set { length = value; }
            }

            public Rectangle(T w,T l)
            {
                width = w;
                length = l;
            }

            public string GetArea()
            {
                double dblWidth= Convert.ToDouble(width);
                double dblLength= Convert.ToDouble(length);
                return string.Format($"{Width} * {Length} = {dblWidth * dblLength}");
            }
        }


    }

    }





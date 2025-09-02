using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    struct Dimensions
    {
        public double Length;
        public double Width;

        public Dimensions(double length,double width)
        {
            Length = length;
            Width = width;
        }

        public double Area()
        {
            return Length * Width;
        }
    }
    internal class Animal
    {

        // static member (shared by all objects)
        public static int numOfAnimals = 0;

        // fields and properties 
        private string name;
        public string Sound { get; set; }
        public int Id { get; private set; }

        // Nullable type (age may or may not be known)
        public int? Age { get; set; }

        // Constructor 
        public Animal(string name, string sound, int? age = null)
        {
            this.name = name;
            this.Sound = sound;
            this.Age = age;

            numOfAnimals++;
            this.Id = numOfAnimals;
        }

        // Methods

        public string GetName() => name;

        public void PrintInfo()
        {
            string ageInfo = Age.HasValue ? Age.Value.ToString() : "Unknown";
            Console.WriteLine($"Animal {Id}: {name}, Sound: {Sound}, Age: {ageInfo}");
        }

    }
}

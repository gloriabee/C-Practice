using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    // interface
    interface Imovable
    {
        void Move();
    }
    
    internal abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        // abstract method (must be implemented by derived classes)
        public abstract void MakeSound();

        // Normal method (can be inherited directly_
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping...");
        }

        // Virtual method (can be overriden)
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating food...");
        }

      
        // Inner class
        public class Info
        {
            public static void ShowKingdom()
            {
                Console.WriteLine("All animals belong to Kingdom: Animalia");
            }
        }
    }
}

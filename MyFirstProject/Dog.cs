using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    // derived class (inherits from animal)
    internal class Dog:Animal,Imovable
    {
        public Dog(string name): base(name) { }

        // implement abstract method 
        public override void MakeSound()
        {
            Console.WriteLine($"{Name}  saus Woof Woof!!");
        }
        
        // override virtual method
        public override void Eat()
        {
            Console.WriteLine($"{Name} eats dog food");
        }

        // implement interface method
        public void Move()
        {
            Console.WriteLine($"{Name} runs quickly");
        }

    }
}

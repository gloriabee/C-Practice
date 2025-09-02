using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Cat: Animal, Imovable
    {
        public Cat(string name): base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Meow!");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} walks gracefully.");
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class ChildTricycle:Tricycle
    {

        public void Ride()
        {
           //calling protected method inside a derived class
            Pedal();
        }

        public void ShowWheels()
        {
            Console.WriteLine($"This tricycle has {wheels} wheels.");
        }
    }
}

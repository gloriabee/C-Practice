using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    // public class
    public class Tricycle
    {
        // protected method:
        protected void Pedal()
        {
            Console.WriteLine("Pedaling the tricycle");
        }

        //private method:
        private int _wheels = 3;

        // protected internal property:
        protected internal int wheels
        {
            get { return _wheels; }
        }

        //allowed inside the class
        public int GetWheelsCount()
        {
            return _wheels;
        }
    }
}

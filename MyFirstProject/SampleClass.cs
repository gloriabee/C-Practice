using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{

    // Declare a delegate 
    delegate void Callback();
    internal class SampleClass
    {
        public void InstanceMethod()
        {
            Console.WriteLine("A meessage from the instance method.");
        }

        static public void StaticMethod()
        {
            Console.WriteLine("A message from the static method");
        }
    }
}

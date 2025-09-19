using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Car
    {
        private string _model = "";
        private string _brand = "";
        private bool _isLuxury;

        public Car(string model,string brand,bool isLuxury=false)
        {
            _model= model;
            _brand = brand;
            _isLuxury=isLuxury;
        }

        public void Drive()
        {
            Console.WriteLine($"I am a {_model} and I am driving");
        }

        

    }
}

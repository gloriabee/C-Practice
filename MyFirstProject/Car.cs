using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Car
    {
        //ာmember variable 
        private string _model = "";
        private string _brand = "";

        //Constructor
        public Car(string model,string brand) {
            _model = model;
            _brand = brand;
            Console.WriteLine($"A {brand} of the model {_model} has been created");
        }





    }
}

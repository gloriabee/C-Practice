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

        //property
   
        public string Model { get => _model; set => _model = value; }
        public string Brand { get => _brand; 
            set{
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered nothing!");
                    _brand = "DefaultValue";
                }
                else
                {
                    _brand = value;
                }
                   
            } }



        //Constructor
        public Car(string model,string brand) {
            Model = model;
            Brand = brand;
            Console.WriteLine($"A {Brand} of the model {Model} has been created");

        }





    }
}

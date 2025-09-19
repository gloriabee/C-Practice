using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age {  get; set; }

        private string name;
        public Student(string name)=> this.name = name;

        public string Name => name;
    }
}

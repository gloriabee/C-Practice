﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{

    internal class Program
    {

        // End of Functions 

        static void Main(string[] args)
        {
            // LINQ Query Syntax
            IList<Student> studentList = new List<Student>()
          {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
          };

            var teenAgerStudent = from stu in studentList
                                  where stu.Age>12 && stu.Age < 20
                                  select stu;

            foreach (var student in teenAgerStudent)
            {
                Console.WriteLine(student.StudentID+" "+student.StudentName + " "+ student.Age);
            }

            Console.ReadKey();

        }
        

    }
}




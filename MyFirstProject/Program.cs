using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{

    internal class Program
    {
        //// declare delegate method
        //public delegate void Callback(string message);

        //// create a method for delegate
        //public static void DelegateMethod(string message)
        //{
        //    Console.WriteLine(message);
        //}


        //public static void MethodWithCallback(int param1, int param2, Callback callback)
        //{
        //    callback("The number is: "+ (param1 + param2).ToString());
        //}

        //delegate void Callback1();
        //delegate void Callback2();

        //static void method(Callback1 d,Callback2 e,System.Delegate f)
        //{
        //    // compile time error
        //    //Console.WriteLine(d==e);

        //    //Console.WriteLine(d==f);

        //}

        //delegate void Callback();
        //class SampleClass
        //{
        //    public void InstanceMethod()
        //    {
        //        Console.WriteLine("A meessage from the instance method.");
        //    }

        //    static public void StaticMethod()
        //    {
        //        Console.WriteLine("A message from the static method");
        //    }
        //}


        //delegate void Notify(string username);

        //static void SendEmail(string username)
        //{
        //    Console.WriteLine($"Email sent to {username}");
        //}

        //static void SendSMS(string username)
        //{
        //    Console.WriteLine($"SMS sent to {username}");
        //}


        //static void LogAction(string username)
        //{
        //    Console.WriteLine($"Action Logged for {username}");
        //}

        //static void SendFax(string username)
        //{
        //    Console.WriteLine($"Fax sent to {username}");
        //}



        //static void SendEmail(string studentName,string studentEmail){

        //    Console.WriteLine($"Email is sent to ${studentName}'s {studentEmail}");
         
        //}

        //public bool IsValid(int age) {
        //    if (age > 18)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        
        
        //public async Task<int> ExampleMethodAsync()
        //{
        //    var httpClient = new HttpClient();
        //    int exampleInt = (await httpClient.GetStringAsync("http://msdn.microsoft.com")).Length;
        //    return exampleInt;
        //}

        static void Main(string[] args)

        {
            Program program = new Program();
            //calling static method
            Print();
            //calling instance method
            program.DisplayMessage();
            Console.ReadLine();
        }
        //static method
        static void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Hello");
            Console.WriteLine();
        }
        //instance method
        void DisplayMessage()
        {
            Console.WriteLine("Hello from the Display " + "Message method!");
        }


    }

    }



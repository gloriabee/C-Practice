using System;
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


        delegate void Notify();

        static void SendEmail()
        {
            Console.WriteLine("Email sent");
        }

        static void SendSMS()
        {
            Console.WriteLine("SMS sent.");
        }


        static void LogAction()
        {
            Console.WriteLine("Action Logged");
        }


        static void Main(string[] args)

        {

            //    // instantiate the delegate.
            //    Callback handler = DelegateMethod;

            //    // call the delegate
            //    handler("Hello World");

            //    // pass the delegate created
            //    MethodWithCallback(1, 2, handler);

            //    var obj = new MethodClass();
            //    Callback d1 = obj.Method1;
            //    Callback d2 = obj.Method2;
            //    Callback d3 = DelegateMethod;

            //    // Both types of assignment are valid. 
            //    Callback allMethodDelegate = d1 + d2;
            //    allMethodDelegate += d3;

            //    // remove method 1 
            //    allMethodDelegate -= d1;


            //    // copy allmethodsdelegate while removing d2
            //    Callback oneMethodDelegate = (allMethodDelegate - d2);

            //    // number of methods in a delegate's invocation list, 
            //    int invocationCount = d1.GetInvocationList().GetLength(0);
            //    Console.WriteLine(invocationCount);

            //var sc = new SampleClass();


            ////Map the delegate to the instance method
            //Callback d = sc.InstanceMethod;
            //d();

            ////Map the delegate to the static method
            //d = SampleClass.StaticMethod;
            //d();

            Notify notifyDelegate = SendEmail;
            notifyDelegate += SendSMS;
            notifyDelegate += LogAction;

            notifyDelegate();

            Console.ReadLine();
        }




    }

    }





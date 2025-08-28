using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Dictionary<int, string> names=new Dictionary<int, string>();

            names.Add(1, "Gloria");
            names.Add(2, "Bo");
            names.Add(3, "Cece");

            Dictionary<int, string> addresses = new Dictionary<int, string>
            {
                {1,"Yangon" },
                {2,"Thailand" },
                {3,"Vietnam" }
            };

            for (int i = 0; i < addresses.Count; i++)
            {
                //Console.WriteLine(addresses.ElementAt(i));
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
                
            }       
            
            foreach(KeyValuePair<int,string> item in addresses)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
    }

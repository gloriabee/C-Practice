using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Notifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending general notification {message}");
        }

        public void Send(string receiver, string message)
        {
            Console.WriteLine($"Sending to {receiver}:{message}");
        }

        public void Send(string receiver,string message,int priority)
        {
            Console.WriteLine($"Sending to {receiver} [Priority {priority}]:{message}");
        }

    }
}

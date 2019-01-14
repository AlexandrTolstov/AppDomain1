using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AppDomain1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating new AppDomain.");
            AppDomain domain = AppDomain.CreateDomain("MyDomain");
            Console.WriteLine("Host domain: " + AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine("child domain: " + domain.FriendlyName);
        }
    }
}

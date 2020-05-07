
using System;

namespace ProjektHello
{
    class Program
    {
        static void Main(string[] args)
        {
         //   string name = args[0];
           // System.Console.WriteLine("Hello World!" + name);

            foreach (var item in args)
            {
                Console.WriteLine("Witaj " + item);

            }
            
        }
    }
}

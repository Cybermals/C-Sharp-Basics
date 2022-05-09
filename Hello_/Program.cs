using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Hello_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the user's name
            Console.Write("Name: ");
            string name = Console.ReadLine();

            //Say hello
            Console.WriteLine("Hello " + name + "!");
        }
    }
}

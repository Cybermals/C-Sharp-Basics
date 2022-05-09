using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PswdProtHello
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get username
            Console.Write("Name: ");
            string name = Console.ReadLine();

            //Get password
            Console.Write("Password: ");
            string pswd = Console.ReadLine();

            //Verify credentials
            if(name == "Dylan" && pswd == "cheetah")
            {
                Console.WriteLine("Hello " + name + "!");
            }
            else
            {
                Console.WriteLine("You aren't allowed here " + name + "!");
            }
        }
    }
}

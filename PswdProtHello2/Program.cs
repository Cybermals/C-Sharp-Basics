using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PswdProtHello2
{
    class Program
    {
        static string Prompt(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }

        static bool IsValid(string name, string pswd)
        {
            return name == "Dylan" & pswd == "cheetah";
        }

        static void Main(string[] args)
        {
            //Get username and password
            string name = Prompt("Name: ");
            string pswd = Prompt("Password: ");

            //Verify credentials
            if(IsValid(name, pswd))
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PswdProtHello3
{
    struct User
    {
        public string name;
        public string pswd;

        public User(string name, string pswd)
        {
            this.name = name;
            this.pswd = pswd;
        }
    }


    class Program
    {
        static User[] users = {
                                  new User("Dylan", "cheetah"),
                                  new User("Fiona", "fox"),
                                  new User("Daniel", "lion"),
                                  new User("Leila", "lioness"),
                                  new User("Serena", "squirrel")
                              };

        static string Prompt(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }

        static bool IsValid(string name, string pswd)
        {
            //Verify credentials
            for(int i = 0; i < users.Length; i++)
            {
                //Valid credentials?
                if(name == users[i].name && pswd == users[i].pswd)
                {
                    return true;
                }
            }

            return false;
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
                Console.WriteLine("Your not allowed here " + name + "!");
            }
        }
    }
}

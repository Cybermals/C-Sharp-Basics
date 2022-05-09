using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace PswdProtHello4
{
    class Program
    {
        static List<User> users = new List<User>();

        static bool LoadUserData()
        {
            //Load user data
            StreamReader usrCfg;

            try
            {
                usrCfg = new StreamReader("data/users.cfg");
            }
            catch(IOException)
            {
                return false;
            }

            while(!usrCfg.EndOfStream)
            {
                //Next line
                string line = usrCfg.ReadLine();

                //User section?
                if(line == "[User]")
                {
                    //Add new user
                    users.Add(new User());
                }
                //User name?
                else if(line.StartsWith("name = "))
                {
                    users[users.Count - 1].name = line.Substring(7);
                }
                //User password?
                else if(line.StartsWith("pswd = "))
                {
                    users[users.Count - 1].pswd = line.Substring(7);
                }
            }

            return true;
        }

        static string Prompt(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }

        static bool IsValid(string name, string pswd)
        {
            //Validate credentials
            foreach(User user in users)
            {
                //Valid credentials?
                if(name == user.name && pswd == user.pswd)
                {
                    return true;
                }
            }

            return false;
        }

        static int Main(string[] args)
        {
            //Load user data
            if(!LoadUserData())
            {
                Console.WriteLine("Failed to load user data.");
                return 1;
            }

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

            return 0;
        }
    }
}

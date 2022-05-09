using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PswdProtHello4
{
    class User
    {
        public string name;
        public string pswd;

        public User()
        {
        }

        public User(string name, string pswd)
        {
            this.name = name;
            this.pswd = pswd;
        }
    }
}

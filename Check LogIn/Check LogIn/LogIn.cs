using System;
using System.Collections.Generic;
using System.Text;

namespace Check_LogIn
{
    class LogIn
    {
        string email = "cavid@code.edu.az ";
        string password = "12345";

        public LogIn()
        {
            if (email == "cavid@code.edu.az " && password == "12345")
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }
           
        }

        public LogIn(string email, string password):this()
        {
            this.email = email;
            this.password = password;
        }
    }
}

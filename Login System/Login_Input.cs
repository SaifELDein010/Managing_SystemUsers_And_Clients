using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Login_System
{
    internal class Login_Input
    {

        static public string username;
        static public string password;
        static public short permission;


        static public void DisplayMessage(string message)
        {

            Console.Write(message);

        }

        static public string ReadTextInput()
        {

            return Console.ReadLine();

        }


    }

}

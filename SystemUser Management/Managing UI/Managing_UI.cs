using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Management.Managing_UI
{
    internal class Managing_UI
    {

        static public Handling_Storage.SystemUserInfo systemUser = new Handling_Storage.SystemUserInfo();

        static public void Header(string message)
        {

            Console.WriteLine($"\n\n\t  {message} Page\n");
            Console.WriteLine("\t ___________________________________________\n");

        }


        static public void DisplaySystemuserInfo()
        {

            Console.WriteLine($"\n\t  {systemUser.name} System user info ");
            Console.WriteLine("\t  --------------------------------------");

            Console.WriteLine($"\t  Name: {systemUser.name}");
            Console.WriteLine($"\t  Email: {systemUser.email}");
            Console.WriteLine($"\t  Phone number: {systemUser.phoneNumber}");
            Console.WriteLine($"\t  System user: {systemUser.accountName}");
            Console.WriteLine($"\t  Password: {systemUser.password}");
            Console.WriteLine($"\t  Permission: {systemUser.permission}\n");

        }

        static public void DisplaySystemUserInfo(Handling_Storage.SystemUserInfo _SystemUser)
        {

            Console.WriteLine($"\t {_SystemUser.name,15} | {_SystemUser.email,20} | {_SystemUser.phoneNumber,15} | " +
                $"{_SystemUser.accountName,10} | {_SystemUser.password,15} | {_SystemUser.permission}");

        }


        static public void ErrorMessage(string message)
        {

            Console.Write(message);

        }


        static public bool CountiesProcess()
        {

            char answer = Convert.ToChar(Console.ReadLine());

            if (answer == 'Y' || answer == 'y')
                return true;

            return false;

        }

    }

}

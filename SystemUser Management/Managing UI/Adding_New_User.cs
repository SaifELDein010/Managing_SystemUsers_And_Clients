using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Management.Managing_UI
{
    internal class Adding_New_User
    {

        static private void ReadSystemUserInfo()
        {

            Console.WriteLine("\t  Enter information: ");
            Console.WriteLine("\t  ---------------------");

            Console.Write("\t  Name of user: ");
            Managing_UI.systemUser.name = Console.ReadLine();

            Console.Write("\t  Email of user: ");
            Managing_UI.systemUser.email = Console.ReadLine();

            Console.Write("\t  Phone number of user: ");
            Managing_UI.systemUser.phoneNumber = Console.ReadLine();

            Console.Write("\t  System user name: ");
            Managing_UI.systemUser.accountName = Console.ReadLine();

            Console.Write("\t  Password of user: ");
            Managing_UI.systemUser.password = Console.ReadLine();

            // Why C# read input in string?
            Console.Write("\t  Permission of user: ");
            Managing_UI.systemUser.permission = Convert.ToInt16(Console.ReadLine());


        }

        static public void AddingSystemUser()
        {

            Managing_UI.Header("Adding new system user");
            ReadSystemUserInfo();

            while (Managing_Logic.Is_Exist.IsExist(Managing_UI.systemUser.accountName))
            {

                Managing_UI.ErrorMessage("\n\t There is error in system user name, Do you want to enter another system user name or finish?(Y/N): ");

                if (!Managing_UI.CountiesProcess())
                    return;

                Console.Write("\t  Another system user name: ");
                Managing_UI.systemUser.accountName = Console.ReadLine();

            }

            Managing_UI.DisplaySystemuserInfo();

            Console.Write("\t Ask user if he/she sure to adding this user account?(Y/N): ");
            if (!Managing_UI.CountiesProcess())
                return;


            if (Managing_Logic.Adding_New_SystemUser.AddingNewSystemUser(Managing_UI.systemUser) != 911)
            {
                Console.WriteLine("\t There is an error in system");
                return;
            }

            Console.WriteLine("\n\t System user adding successful");

        }
    }

}

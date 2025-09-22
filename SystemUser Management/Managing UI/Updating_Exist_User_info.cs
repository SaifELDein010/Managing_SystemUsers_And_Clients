using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Management.Managing_UI
{
    internal class Updating_Exist_User_info
    {

        static private void ReadUpdatingSystemUserInfo()
        {

            Console.WriteLine("\t  Enter information: ");
            Console.WriteLine("\t  ---------------------");

            Console.Write("\t  Name of user: ");
            Managing_UI.systemUser.name = Console.ReadLine();

            Console.Write("\t  Email of user: ");
            Managing_UI.systemUser.email = Console.ReadLine();

            Console.Write("\t  Phone number of user: ");
            Managing_UI.systemUser.phoneNumber = Console.ReadLine();

            Console.Write("\t  Password of user: ");
            Managing_UI.systemUser.password = Console.ReadLine();

            Console.Write("\t  Permission of user: ");
            Managing_UI.systemUser.permission = Convert.ToInt16(Console.ReadLine());

        }


        static public void UpdatingSystemUser()
        {

            Managing_UI.Header("Updating exist system user");

            Console.Write("\t Enter system user name: ");
            Managing_UI.systemUser.accountName = Console.ReadLine();

            while (!Managing_Logic.Is_Exist.IsExist(Managing_UI.systemUser.accountName))
            {

                Managing_UI.ErrorMessage("\n\t There is error in system user name, Do you want to enter another system user name or finish?(Y/N): ");

                if (!Managing_UI.CountiesProcess())
                    return;

                Console.Write("\t  system user name: ");
                Managing_UI.systemUser.accountName = Console.ReadLine();

            }

            Managing_UI.systemUser = Managing_Logic.Sending_Info_Of_SystemUser.SendingSystemUserInfo(Managing_UI.systemUser.accountName);

            Managing_UI.DisplaySystemuserInfo();

            ReadUpdatingSystemUserInfo();

            Managing_UI.DisplaySystemuserInfo();


            Console.Write("\t Ask system user if he/she sure to Updating this system user account?(Y/N): ");
            if (!Managing_UI.CountiesProcess())
                return;


            if (Managing_Logic.Updating_Exist_SystemUser.UpdatingExistSystemUserInfo(Managing_UI.systemUser) != 911)
            {
                Console.WriteLine("\t There is an error in system");
                return;
            }

            Console.WriteLine("\t system user Updating successful");

        }


    }


}

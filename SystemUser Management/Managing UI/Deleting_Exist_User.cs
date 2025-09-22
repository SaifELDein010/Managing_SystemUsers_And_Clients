using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Management.Managing_UI
{
    internal class Deleting_Exist_User
    {

        static public void DeletingSystemUser()
        {

            Managing_UI.Header("Deleting exist system user");

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

            Console.Write("\t Ask system user if he/she sure to deleting this user account?(Y/N): ");
            if (!Managing_UI.CountiesProcess())
                return;


            if (Managing_Logic.Deleting_Exist_SystemUser.DeletingEisxtSystemUser(Managing_UI.systemUser.accountName) != 911)
            {
                Console.WriteLine("\t There is an error in system");
                return;
            }

            Console.WriteLine("\t System user deleting successful");

        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Management.Managing_UI
{
    internal class Display_Info_Of_User
    {

        static public void FindSystemUser()
        {

            Managing_UI.Header("Finiding exist system user");

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


        }

        static public void DisplayAllUsers()
        {

            Managing_UI.Header("Display all Users");

            List<Handling_Storage.SystemUserInfo> systemUsers = new List<Handling_Storage.SystemUserInfo>();

            systemUsers = Managing_Logic.Sending_All_SystemUsers_Info.SendingAllSystemUserInfo();

            foreach (Handling_Storage.SystemUserInfo _User in systemUsers)
            {

                Managing_UI.DisplaySystemUserInfo(_User);

            }

        }


    }

}

using Bank_system.SystemUser_Management.Managing_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_system.SystemUser_Management.Handling_Storage;

namespace Bank_system.Login_System
{

    internal class Login_Input_Validation
    {

        static public bool InputValidation()
        {

            // Get Data of user system from username
            SystemUserInfo systemUserInfo = new SystemUserInfo();

            systemUserInfo = Sending_Info_Of_SystemUser.SendingSystemUserInfo(Login_Input.username);

            if (Login_Input.username == systemUserInfo.accountName)
            {

                if(Login_Input.password == systemUserInfo.password)
                {

                    // Get permission
                    Login_Input.permission = systemUserInfo.permission;

                    return true;
                    
                }

            }

            return false;

        }


    }


}

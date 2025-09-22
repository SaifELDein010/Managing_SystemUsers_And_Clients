using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_system.SystemUser_Management.Handling_Storage;

namespace Bank_system.SystemUser_Management.Managing_Logic
{
    internal class Sending_Info_Of_SystemUser
    {

        static public SystemUserInfo SendingSystemUserInfo(string systemUserName)
        {

            SystemUserInfo systemUserInfo = new SystemUserInfo();

            if (!Is_Exist.IsExist(systemUserName))
                return systemUserInfo;

            int indexOfClient = GetIndexOfSystemUser(systemUserName);

            systemUserInfo = Handling_Storage.systemUsers[indexOfClient];

            return systemUserInfo;

        }

    }

}

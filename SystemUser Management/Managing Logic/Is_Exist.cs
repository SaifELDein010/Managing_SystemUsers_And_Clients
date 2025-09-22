using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_system.SystemUser_Management.Handling_Storage;

namespace Bank_system.SystemUser_Management.Managing_Logic
{
    internal class Is_Exist
    {

        static public bool IsExist(string systemUserName)
        {

            ReadRecordsFromFile();

            foreach (SystemUserInfo systemUser in Handling_Storage.systemUsers)
            {

                if (systemUser.accountName == systemUserName) return true;

            }

            return false;

        }

    }

}

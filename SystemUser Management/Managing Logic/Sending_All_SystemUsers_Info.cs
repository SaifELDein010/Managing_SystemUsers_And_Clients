using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_system.SystemUser_Management.Handling_Storage;

namespace Bank_system.SystemUser_Management.Managing_Logic
{
    internal class Sending_All_SystemUsers_Info
    {

        static public List<SystemUserInfo> SendingAllSystemUserInfo()
        {

            // What if list is empty?

            ReadRecordsFromFile();

            return Handling_Storage.systemUsers;

        }

    }

}

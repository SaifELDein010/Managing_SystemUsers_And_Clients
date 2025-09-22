using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.SystemUser_Management.Managing_Logic
{
    internal class Deleting_Exist_SystemUser
    {

        static public short DeletingEisxtSystemUser(string systemUserName)
        {

            if (!Is_Exist.IsExist(systemUserName))
                return 404;


            int indexInSystemUsers = Handling_Storage.GetIndexOfSystemUser(systemUserName);

            if (indexInSystemUsers == -1)
            {
                return 404;
            }

            Handling_Storage.systemUsers.RemoveAt(indexInSystemUsers);

            Handling_Storage.UpdatingSystemUserInfoFile();


            return 911;

        }


    }

}

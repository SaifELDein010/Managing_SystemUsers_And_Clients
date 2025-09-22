using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_system.SystemUser_Management.Handling_Storage;

namespace Bank_system.SystemUser_Management.Managing_Logic
{
    internal class Updating_Exist_SystemUser
    {

        static public short UpdatingExistSystemUserInfo(SystemUserInfo updatingSystemUser)
        {

            if (!Is_Exist.IsExist(updatingSystemUser.accountName))
                return 404;

            if (Deleting_Exist_SystemUser.DeletingEisxtSystemUser(updatingSystemUser.accountName) != 911)
            {

                return 404;

            }

            if (Adding_New_SystemUser.AddingNewSystemUser(updatingSystemUser) != 911)
            {

                return 404;

            }

            return 911;

        }


    }

}

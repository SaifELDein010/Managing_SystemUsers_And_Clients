using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_system.SystemUser_Management.Handling_Storage;

namespace Bank_system.SystemUser_Management.Managing_Logic
{
    internal class Adding_New_SystemUser
    {


        static public short AddingNewSystemUser(SystemUserInfo newSystemUser)
        {

            if (Is_Exist.IsExist(newSystemUser.accountName))
                return 404;

            using (StreamWriter write = File.AppendText(Handling_Storage._path))
            {

                write.WriteLine(ConvertSystemUserIntoRecord(newSystemUser));

            }

            return 911;

        }


    }

}

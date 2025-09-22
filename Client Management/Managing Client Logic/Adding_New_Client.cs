using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_system.Client_Management.Handling_Client_Storage;

namespace Bank_system.Client_Management.Managing_Client_Logic
{
    internal class Adding_New_Client
    {

        static public short AddingNewClient(ClientInfo newClient)
        {

            if (Client_Is_Exist.IsExist(newClient.accountName))
                return 404;

            using (StreamWriter write = File.AppendText(_path))
            {

                write.WriteLine(ConvertClientIntoRecord(newClient));

            }

            return 911;

        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_system.Client_Management.Handling_Client_Storage;

namespace Bank_system.Client_Management.Managing_Client_Logic
{
    internal class Client_Is_Exist
    {

        static public bool IsExist(string accountName)
        {

            Handling_Client_Storage.ReadRecordsFromFile();

            foreach (ClientInfo clientInfo in clients)
            {

                if (clientInfo.accountName == accountName) return true;

            }

            return false;

        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_system.Client_Management.Handling_Client_Storage;

namespace Bank_system.Client_Management.Managing_Client_Logic
{
    internal class Sending_All_Clients_Info
    {

        static public List<ClientInfo> SendingAllClientInfo()
        {

            ReadRecordsFromFile();

            return clients;

        }

    }

}

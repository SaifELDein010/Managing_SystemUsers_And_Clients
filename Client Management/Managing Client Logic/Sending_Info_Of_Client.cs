using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_system.Client_Management.Handling_Client_Storage;

namespace Bank_system.Client_Management.Managing_Client_Logic
{
    internal class Sending_Info_Of_Client
    {

        static public ClientInfo SendingClientInfo(string accountName)
        {

            ClientInfo clientInfo = new ClientInfo();

            if (!Client_Is_Exist.IsExist(accountName))
                return clientInfo;

            int indexOfClient = GetIndexOfClient(accountName);

            clientInfo = clients[indexOfClient];

            return clientInfo;

        }

    }

}

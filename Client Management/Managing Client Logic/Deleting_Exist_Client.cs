using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.Client_Management.Managing_Client_Logic
{
    internal class Deleting_Exist_Client
    {
        static public short DeletingEisxtClient(string accountName)
        {

            if (!Client_Is_Exist.IsExist(accountName))
                return 404;


            int indexInClients = Handling_Client_Storage.GetIndexOfClient(accountName);

            if (indexInClients == -1)
            {
                return 404;
            }

            Handling_Client_Storage.clients.RemoveAt(indexInClients);

            Handling_Client_Storage.UpdatingClientInfoFile();


            return 911;

        }

    }

}

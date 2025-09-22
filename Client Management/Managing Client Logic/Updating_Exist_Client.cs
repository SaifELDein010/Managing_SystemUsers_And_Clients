using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_system.Client_Management.Handling_Client_Storage;

namespace Bank_system.Client_Management.Managing_Client_Logic
{
    internal class Updating_Exist_Client
    {

        static public short UpdatingExistClientInfo(ClientInfo updatingClient)
        {

            if (!Client_Is_Exist.IsExist(updatingClient.accountName))
                return 404;

            if (Deleting_Exist_Client.DeletingEisxtClient(updatingClient.accountName) != 911)
            {

                return 404;

            }

            if (Adding_New_Client.AddingNewClient(updatingClient) != 911)
            {

                return 404;

            }

            return 911;

        }


    }

}
